using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Authentication;
using System.Security.Principal;
using System.Windows.Forms;

namespace ContigUI
{
	public static class AdminModule
	{
		public static void RunAsAdmin()
		{
			var message = "This application requires administrative privileges to perform optimally. \n\n Relaunch as Administrator";
			
			if (IsRunAsAdmin()) return;

			if (MessageBox.Show(message, "Elevation required", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
			{
				var proc = new ProcessStartInfo
				{
					UseShellExecute = true,
					WorkingDirectory = Environment.CurrentDirectory,
					FileName = Assembly.GetEntryAssembly()?.CodeBase ?? throw new InvalidOperationException("Unable to find/access the path of the application."),

					Verb = "runas"
				};

				try
				{
					Process.Start(proc);
					Environment.Exit(0);
				}
				catch (Exception ex)
				{
					throw new InvalidCredentialException($"This program must be run as an administrator! \n\n{ex}", ex);
				}
			}
			else
			{
				Environment.Exit(0);
			}
		}

		private static bool IsRunAsAdmin()
		{
			try
			{
				var id = WindowsIdentity.GetCurrent();
				var principal = new WindowsPrincipal(id);
				return principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
