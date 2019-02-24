using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContigUI
{

	internal class OutputAnalyzer
	{
		public FileSystemWatcher Watcher { get; set; } = new FileSystemWatcher() { NotifyFilter = NotifyFilters.Size, Filter = "*.*", EnableRaisingEvents = true };

		public OutputAnalyzer()
		{
			Watcher.Changed += OutputChanged;
		}

		private void OutputChanged(object sender, FileSystemEventArgs e)
		{
			throw new NotImplementedException();
		}
	}
}
