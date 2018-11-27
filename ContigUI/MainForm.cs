using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContigUI.Utilities;

namespace ContigUI
{
	// In powershell, contig.exe | foreach-object{ if($_ -match "(.*) is in (.*)"){ "`"$($Matches[1])`",`"$($Matches[2])`""}}

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
#if DEBUG == false
			AdminRelauncher();
#endif
			DriveListView.Items.Clear();
			FolderListView.Items.Clear();
			FileListView.Items.Clear();
			// Add Drives
			AddDrives();
		}

		#region Add Items to defrag

		private void AddDrives()
		{
			DriveListView.Items.Clear();

			var drives = System.IO.DriveInfo.GetDrives();
			foreach (var drive in drives)
			{
				if (drive.DriveType != System.IO.DriveType.Fixed) { continue; }
				var item = new ListViewItem(drive.Name, "Drive");
				var subItem = new ListViewItem.ListViewSubItem(item, (drive.TotalSize / 1024 / 1024 / 1024) + " GB");
				item.SubItems.Add(subItem);
				DriveListView.Items.Add(item);
			}
		}

		private void FolderBrowserButton_Click(object sender, EventArgs e)
		{
			if (FolderDialog.ShowDialog() == DialogResult.OK)
			{
				var folderName = FolderDialog.SelectedPath;
				var item = new ListViewItem(folderName, "Folder");
				//item.Checked = true;
				FolderListView.Items.Add(item);
			}
		}

		private void FileBrowserButton_Click(object sender, EventArgs e)
		{
			if (FileDialog.ShowDialog() == DialogResult.OK)
			{
				var files = FileDialog.FileNames;
				foreach (var file in files)
				{
					var item = new ListViewItem(file, "File");
					//item.Checked = true;
					FileListView.Items.Add(item);
				}
			}
		}

		#endregion

		#region Remove Items

		private void RemoveFolderButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in FolderListView.Items)
			{
				if (item.Checked)
				{
					FolderListView.Items.Remove(item);
				}
			}
		}

		private void RemoveFilesButton_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in FileListView.Items)
			{
				if (item.Checked)
				{
					FileListView.Items.Remove(item);
				}
			}
		}

		#endregion

		private void ExitButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure to exit the program?\n\n Defragmantation (if started) will continue in the background.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
			if (result == DialogResult.OK)
			{
				Close();
			}
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			var contigPath = GetContigPath();
			if (string.IsNullOrWhiteSpace(contigPath)) { return; }

			var outDir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), "ContiGUI"));

			var driveFileName = Path.Combine(Path.GetTempPath(), "ContigUI", "driveOut.log");
			var folderFileName = Path.Combine(Path.GetTempPath(), "ContigUI", "folderOut.log");
			var fileFileName = Path.Combine(Path.GetTempPath(), "ContigUI", "fileOut.log");

			var process = new ProcessUtility(contigPath);

			var driveParameters = new List<string>();
			var folderParameters = new List<string>();
			var fileParameters = new List<string>();

			foreach (ListViewItem item in DriveListView.Items)
			{
				if (item.Checked) { driveParameters.Add(item.Text); }
			}
			foreach (ListViewItem item in FolderListView.Items)
			{
				folderParameters.Add(item.Text);
			}

			foreach (ListViewItem item in FileListView.Items)
			{
				fileParameters.Add(item.Text);
			}

			Hide();
			foreach (var folder in folderParameters)
			{
				process.Arguments = "-v -s " + Path.Combine(folder, "*.*");
				//process.StandardErrorFileName = folderFileName;
				process.StandardOutputFileName = folderFileName;
				(new ProgressDialog()).ShowDialog(this);
				process.Run();
			}

			foreach (var file in fileParameters)
			{
				process.Arguments = "-v -s " + file;
				//process.StandardErrorFileName = fileFileName;
				process.StandardOutputFileName = fileFileName;
				process.Run();
			}

			foreach (var drive in driveParameters)
			{
				process.Arguments = "-v -s " + drive + "*.*";
				//process.StandardErrorFileName = driveFileName;
				process.StandardOutputFileName = driveFileName;
				process.Run();
			}

			MessageBox.Show("Process Complete","ContiGUI",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Show();
		}

		private string GetContigPath()
		{
			// Find if contig is available in any of the path
			var contigPath = GetFullPathFromWindows("contig.exe");

			if (string.IsNullOrWhiteSpace(contigPath))
			{
				//var message = "Unable to find \"Contig\". Would you like to provide the path of Contig yourself?" +
				//	"\n\nIf you choose \"No\" : Embedded verion of contig will be used (Currently 1.8)" +
				//	"\n\nIf you choose \"Cancel\" : Operation will be cancelled";
				//var result = MessageBox.Show(message, "Contig Path", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
				//switch (result)
				//{
				//	case DialogResult.Yes:
				//		// Open File dialog
				//		var contigDialog = new OpenFileDialog
				//		{
				//			Filter = "Contig Application|Contig.exe|All Files|*.*",
				//			Multiselect = false,
				//			AddExtension = true,
				//			AutoUpgradeEnabled = true,
				//			CheckFileExists = true,
				//			CheckPathExists = true,
				//			DereferenceLinks = true,
				//			FileName = "Contig.exe",
				//			SupportMultiDottedExtensions = true,
				//			Title = "Select path of Contig...",
				//			ValidateNames = true
				//		};

				//		result = contigDialog.ShowDialog();
				//		if (result == DialogResult.OK)
				//		{
				//			contigPath = contigDialog.FileName;
				//			if (!AuthenticodeTools.IsTrusted(contigPath))
				//			{
				//				MessageBox.Show("Unable to verify the signature of the file. Cannot use it.", "Unverified File");
				//				contigPath = null;
				//			}
				//		}
				//		break;
				//	case DialogResult.Cancel: contigPath = null; break;
				//	case DialogResult.No:
				//		// Prepare Contig Path
				//		contigPath = Path.Combine(Path.GetTempPath(), "Contig.exe");
				//		// Extract the Contig from here to temp
				//		File.WriteAllBytes(contigPath, Properties.Resources.Contig);
				//		break;
				//	default: break;
				//}
				// Prepare Contig Path
				contigPath = Path.Combine(Path.GetTempPath(), "Contig.exe");
				// Extract the Contig from here to temp
				File.WriteAllBytes(contigPath, Properties.Resources.Contig);
			}
			return contigPath;
		}

		/// <summary>
		/// Gets the full path of the given executable filename as if the user had entered this
		/// executable in a shell. So, for example, the Windows PATH environment variable will
		/// be examined. If the filename can't be found by Windows, null is returned.</summary>
		/// <param name="exeName"></param>
		/// <returns>The full path if successful, or null otherwise.</returns>
		public static string GetFullPathFromWindows(string exeName)
		{
			if (exeName.Length >= MAX_PATH) { throw new ArgumentException($"The executable name '{exeName}' must have less than {MAX_PATH} characters.", nameof(exeName)); }

			StringBuilder sb = new StringBuilder(exeName, MAX_PATH);
			return PathFindOnPath(sb, null) ? sb.ToString() : null;
		}

		// https://docs.microsoft.com/en-us/windows/desktop/api/shlwapi/nf-shlwapi-pathfindonpathw
		// https://www.pinvoke.net/default.aspx/shlwapi.PathFindOnPath
		[DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = false)]
		static extern bool PathFindOnPath([In, Out] StringBuilder pszFile, [In] string[] ppszOtherDirs);

		// from MAPIWIN.h :
		private const int MAX_PATH = 260;

		private void AdminRelauncher()
		{
			var message = "This application requires administrative privileges to perform optimally. \n\n Relaunch as Administrator";
			if (!IsRunAsAdmin())
			{
				if (MessageBox.Show(message, "Elevation required", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
				{
					ProcessStartInfo proc = new ProcessStartInfo();
					proc.UseShellExecute = true;
					proc.WorkingDirectory = Environment.CurrentDirectory;
					proc.FileName = Assembly.GetEntryAssembly().CodeBase;

					proc.Verb = "runas";

					try
					{
						Process.Start(proc);
						Environment.Exit(0);
					}
					catch (Exception ex)
					{
						Console.WriteLine("This program must be run as an administrator! \n\n" + ex.ToString());
					}
				}
				else
				{
					Environment.Exit(0);
				}
			}
		}

		private bool IsRunAsAdmin()
		{
			try
			{
				WindowsIdentity id = WindowsIdentity.GetCurrent();
				WindowsPrincipal principal = new WindowsPrincipal(id);
				return principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
