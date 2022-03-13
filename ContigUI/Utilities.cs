using System.IO;

namespace ContigUI
{
	public class Utilities
	{
		
		internal static string GetContigPath()
		{
			// Find if contig is available in any of the path
			var contigPath = NativeMethods.GetFullPathFromWindows("contig.exe");

			if (!string.IsNullOrWhiteSpace(contigPath))
			{
				return contigPath;
			}

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
			return contigPath;
		}
	}
}