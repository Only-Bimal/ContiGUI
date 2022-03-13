using System;
using System.Globalization;
using System.IO;
using System.Linq;
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
			AdminModule.RunAsAdmin();
#endif
			DriveListView.Items.Clear();
			FolderListView.Items.Clear();
			FileListView.Items.Clear();
			// Add Drives
			AddDrives();
		}

		private string _logFilePath;
		private string LogFilePath
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(_logFilePath)) { return _logFilePath; }

				var outDir = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), "ContigUI"));

				var logFileName = $"ContigUi {DateTime.Now.ToString("yyyy-MMM-dd", CultureInfo.CurrentCulture)}.log";

				_logFilePath = Path.Combine(outDir.FullName, logFileName);

				if (File.Exists(_logFilePath)) { File.Delete(_logFilePath); }
				return _logFilePath;
			}
		}

		private OutputAnalyzer _logWatcher;
		private OutputAnalyzer Watcher
		{
			get
			{
				if (_logWatcher != null) { return _logWatcher; }

				_logWatcher = new OutputAnalyzer(LogFilePath);
				return _logWatcher;
			}
		}
		#region Add Items to defrag

		private void AddDrives()
		{
			DriveListView.Items.Clear();

			var drives = Drive.GetDrives();

			foreach (var drive in drives)
			{
				var item = new ListViewItem($"{drive.DriveLabel} ({drive.DriveLetter})", "Drive")
				{
					Tag = drive.DriveLetter
				};

				var typeSubItem = new ListViewItem.ListViewSubItem(item, (drive.DriveType.ToString()));
				item.SubItems.Add(typeSubItem);
				var sizeSubItem = new ListViewItem.ListViewSubItem(item, drive.DriveSize);
				item.SubItems.Add(sizeSubItem);
				DriveListView.Items.Add(item);
			}
		}

		private void FolderBrowserButton_Click(object sender, EventArgs e)
		{
			if (FolderDialog.ShowDialog() != DialogResult.OK) { return; }

			var folderName = FolderDialog.SelectedPath;
			var item = new ListViewItem(folderName, "Folder");
			FolderListView.Items.Add(item);
		}

		private void FileBrowserButton_Click(object sender, EventArgs e)
		{
			if (FileDialog.ShowDialog() != DialogResult.OK) { return; }

			var files = FileDialog.FileNames;
			foreach (var file in files)
			{
				var item = new ListViewItem(file, "File");
				//item.Checked = true;
				FileListView.Items.Add(item);
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
				Watcher.Stop();
				Watcher.Dispose();
				Close();
			}
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			var contigPath = GetContigPath();
			if (string.IsNullOrWhiteSpace(contigPath)) { return; }

			var process = new ProcessUtility(contigPath);

			var driveParameters = (from ListViewItem item in DriveListView.Items where item.Checked select item.Tag.ToString()).ToList();

			var folderParameters = (from ListViewItem item in FolderListView.Items select item.Text).ToList();

			var fileParameters = (from ListViewItem item in FileListView.Items select item.Text).ToList();

			// Start Watching Log
			Watcher.Start();
			//Hide();
			foreach (var folder in folderParameters)
			{
				process.Arguments = "-v -s " + Path.Combine(folder, "*.*");
				process.StandardOutputFileName = LogFilePath;
				process.ProcessCompleted += Process_ProcessCompleted;
				process.Run();
			}

			foreach (var file in fileParameters)
			{
				process.Arguments = "-v -s " + file;
				process.StandardOutputFileName = LogFilePath;
				process.Run();
			}

			foreach (var drive in driveParameters)
			{
				process.Arguments = "-v -s " + drive + "*.*";
				process.StandardOutputFileName = LogFilePath;
				process.Run();
			}
			// Stop Watching Log
			//Watcher.Stop();

			//MessageBox.Show("Process Complete", "ContigUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Show();
		}

		private void Process_ProcessCompleted(object sender, EventArgs e)
		{
			MessageBox.Show(OutputAnalyzer.Count.ToString());
		}

		#region Toolbar Orientation

		private void MainToolStripContainer_LeftToolStripPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			SetToolbarOrientation((ToolStrip)e.Control, ToolStripTextDirection.Vertical270);
		}

		private void MainToolStripContainer_RightToolStripPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			SetToolbarOrientation((ToolStrip)e.Control, ToolStripTextDirection.Vertical90);
		}

		private void MainToolStripContainer_TopToolStripPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			SetToolbarOrientation((ToolStrip)e.Control, ToolStripTextDirection.Horizontal);
		}

		private void MainToolStripContainer_BottomToolStripPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			SetToolbarOrientation((ToolStrip)e.Control, ToolStripTextDirection.Horizontal);
		}

		private void SetToolbarOrientation(ToolStrip toolBar, ToolStripTextDirection textDirection)
		{
			toolBar.TextDirection = textDirection;
		}
		#endregion
	}
}
