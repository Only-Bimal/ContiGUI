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
			RunAsAdmin();
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

			//Hide();
			foreach (var folder in folderParameters)
			{
				process.Arguments = "-v -s " + Path.Combine(folder, "*.*");
				//process.StandardErrorFileName = folderFileName;
				process.StandardOutputFileName = folderFileName;
				//new ProgressDialog().ShowDialog(this);
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

			MessageBox.Show("Process Complete", "ContiGUI", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Show();
		}

		
	}
}
