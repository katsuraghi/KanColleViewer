using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grabacr07.KanColleViewer.Composition;

namespace Counter
{
	[Export(typeof(IToolPlugin))]
	public class KanColleCounter : IToolPlugin
	{




		public object GetSettingsView()
		{
			return null;
		}

		public object GetToolView()
		{
			return null;
		}
	}
}
