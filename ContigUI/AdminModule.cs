using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContigUI
{
	public class AdminModule
	{
		private void RunAsAdmin()
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
