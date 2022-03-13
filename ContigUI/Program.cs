using System;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ContigUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
		[STAThread]
		static void Main()
		{
			// Before running anything accept the EULA of Contig
			var contigPath = Utilities.GetContigPath();
			if (string.IsNullOrWhiteSpace(contigPath)) { return; }

			var process = new ProcessUtility(contigPath) {Arguments = " -accepteula"};
			process.Run();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
