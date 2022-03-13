using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Threading;

/*
* Based on Answer from the link https://stackoverflow.com/a/16256623/561256 by Mattthew Watson
*/
namespace ContigUI
{
	/// <summary>
	/// Encapsulates an executable program.
	/// This class makes it easy to run a console app and have that application's output appear
	/// in the parent console's window, and to redirect input and output from/to files.
	/// </summary>
	/// <remarks>
	/// To use this class:
	/// (1) Create an instance.
	/// (2) Set the ProgramFileName property if a filename wasn't specified in the constructor.
	/// (3) Set other properties if required.
	/// (4) Call Run().
	/// </remarks>

	public class ProcessUtility
	{
		public event EventHandler ProcessCompleted;

		#region Constructor

		/// <summary>Runs the specified program file name.</summary>
		/// <param name="programFileName">Name of the program file to run.</param>
		public ProcessUtility(string programFileName)
		{
			ProgramFileName = programFileName;

			_processStartInfo.ErrorDialog = false;
			_processStartInfo.CreateNoWindow = false;
			_processStartInfo.UseShellExecute = false;
			_processStartInfo.RedirectStandardOutput = false;
			_processStartInfo.RedirectStandardError = false;
			_processStartInfo.RedirectStandardInput = false;
			_processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			_processStartInfo.Arguments = "";
			_processStartInfo.CreateNoWindow = true;
		}

		/// <summary>Constructor.</summary>

		public ProcessUtility() : this(string.Empty)
		{
		}

		#endregion  // Constructor

		#region Public Properties

		/// <summary>The filename (full pathname) of the executable.</summary>

		public string ProgramFileName
		{
			get => _processStartInfo.FileName;
			set => _processStartInfo.FileName = value;
		}

		/// <summary>The command-line arguments passed to the executable when run. </summary>
		public string Arguments
		{
			get => _processStartInfo.Arguments;
			set => _processStartInfo.Arguments = value;
		}

		/// <summary>The working directory set for the executable when run.</summary>

		public string WorkingDirectory
		{
			get => _processStartInfo.WorkingDirectory;
			set => _processStartInfo.WorkingDirectory = value;
		}

		/// <summary>
		/// The file to be used if standard input is redirected,
		/// or null or string.Empty to not redirect standard input.
		/// </summary>
		public string StandardInputFileName
		{
			set
			{
				_standardInputFileName = value;
				_processStartInfo.RedirectStandardInput = !string.IsNullOrEmpty(value);
			}
			get => _standardInputFileName;
		}

		/// <summary>
		/// The file to be used if standard output is redirected,
		/// or null or string.Empty to not redirect standard output.
		/// </summary>
		public string StandardOutputFileName
		{
			set
			{
				_standardOutputFileName = value;
				_processStartInfo.RedirectStandardOutput = !string.IsNullOrEmpty(value);
			}
			get => _standardOutputFileName;
		}

		/// <summary>
		/// The file to be used if standard error is redirected,
		/// or null or string.Empty to not redirect standard error.
		/// </summary>
		public string StandardErrorFileName
		{
			set
			{
				_standardErrorFileName = value;
				_processStartInfo.RedirectStandardError = !string.IsNullOrEmpty(value);
			}
			get => _standardErrorFileName;
		}

		#endregion  // Public Properties

		#region Public Methods

		/// <summary>Add a set of name-value pairs into the set of environment variables available to the executable.</summary>
		/// <param name="variables">The name-value pairs to add.</param>
		public void AddEnvironmentVariables(StringDictionary variables)
		{
			if (variables == null) { throw new ArgumentNullException(nameof(variables)); }

			var environmentVariables = _processStartInfo.EnvironmentVariables;

			foreach (DictionaryEntry e in variables) { environmentVariables[(string)e.Key] = (string)e.Value; }
		}

		/// <summary>Run the executable and wait until the it has terminated.</summary>
		/// <returns>The exit code returned from the executable.</returns>
		public int Run()
		{
			Thread standardInputThread = null;
			Thread standardOutputThread = null;
			Thread standardErrorThread = null;

			_standardInput = null;
			_standardError = null;
			_standardOutput = null;

			var exitCode = -1;

			try
			{
				using (var process = new Process())
				{
					process.StartInfo = _processStartInfo;
					process.EnableRaisingEvents = true;
					process.Exited += Process_Exited;
					process.Start();

					if (process.StartInfo.RedirectStandardInput)
					{
						_standardInput = process.StandardInput;
						standardInputThread = StartThread(new ThreadStart(SupplyStandardInput), "StandardInput");
					}

					if (process.StartInfo.RedirectStandardError)
					{
						_standardError = process.StandardError;
						standardErrorThread = StartThread(new ThreadStart(WriteStandardError), "StandardError");
					}

					if (process.StartInfo.RedirectStandardOutput)
					{
						_standardOutput = process.StandardOutput;
						standardOutputThread = StartThread(new ThreadStart(WriteStandardOutput), "StandardOutput");
					}
					
					//process.WaitForExit();
					//exitCode = process.ExitCode;
				}
			}

			finally  // Ensure that the threads do not persist beyond the process being run
			{
				standardInputThread?.Join();

				standardOutputThread?.Join();

				standardErrorThread?.Join();
			}

			return exitCode;
		}

		private void Process_Exited(object sender, EventArgs e)
		{
			OnProcessCompleted(e);
		}

		protected virtual void OnProcessCompleted(EventArgs e)
		{
			EventHandler handler = ProcessCompleted;
			handler?.Invoke(this, e);
		}

		#endregion  // Public Methods

		#region Private Methods

		/// <summary>Start a thread.</summary>
		/// <param name="startInfo">start information for this thread</param>
		/// <param name="name">name of the thread</param>
		/// <returns>thread object</returns>

		private static Thread StartThread(ThreadStart startInfo, string name)
		{
			var t = new Thread(startInfo)
			{
				IsBackground = true,
				Name = name
			};
			t.Start();
			return t;
		}

		/// <summary>Thread which supplies standard input from the appropriate file to the running executable.</summary>

		private void SupplyStandardInput()
		{
			// feed text from the file a line at a time into the standard input stream

			using (var reader = File.OpenText(_standardInputFileName))
			{
				using (var writer = _standardInput)
				{
					writer.AutoFlush = true;

					for (; ; )
					{
						var textLine = reader.ReadLine();

						if (textLine == null)
							break;

						writer.WriteLine(textLine);
					}
				}
			}
		}

		/// <summary>Thread which outputs standard output from the running executable to the appropriate file.</summary>

		private void WriteStandardOutput()
		{
			using (var writer = File.CreateText(_standardOutputFileName))
			{
				using (var reader = _standardOutput)
				{
					writer.AutoFlush = true;

					for (; ; )
					{
						var textLine = reader.ReadLine();

						if (textLine == null) break;

						writer.WriteLine(textLine);
					}
				}
			}

			if (File.Exists(_standardOutputFileName))
			{
				var info = new FileInfo(_standardOutputFileName);

				// if the error info is empty or just contains eof etc.

				if (info.Length < 4) { info.Delete(); }
			}
		}

		/// <summary>Thread which outputs standard error output from the running executable to the appropriate file.</summary>

		private void WriteStandardError()
		{
			using (var writer = File.CreateText(_standardErrorFileName))
			{
				using (var reader = _standardError)
				{
					writer.AutoFlush = true;

					for (; ; )
					{
						var textLine = reader.ReadLine();

						if (textLine == null)
							break;

						writer.WriteLine(textLine);
					}
				}
			}

			if (File.Exists(_standardErrorFileName))
			{
				var info = new FileInfo(_standardErrorFileName);

				// if the error info is empty or just contains eof etc.

				if (info.Length < 4) { info.Delete(); }
			}
		}

		#endregion  // Private Methods

		#region Private Fields

		private StreamReader _standardError;
		private StreamReader _standardOutput;
		private StreamWriter _standardInput;

		private string _standardInputFileName;
		private string _standardOutputFileName;
		private string _standardErrorFileName;

		ProcessStartInfo _processStartInfo = new ProcessStartInfo();


		#endregion  // Private Fields
	}
}