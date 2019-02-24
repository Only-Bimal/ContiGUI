using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContigUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Before running anything accept the EULA of Contig
			var contigPath = Utilities.GetContigPath();
			if (string.IsNullOrWhiteSpace(contigPath)) { return; }
			var process = new ProcessUtility(contigPath);
			process.Arguments = " -accepteula";
			process.Run();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
