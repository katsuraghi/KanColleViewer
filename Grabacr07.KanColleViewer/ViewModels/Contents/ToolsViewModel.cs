using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;
using Livet;

namespace Grabacr07.KanColleViewer.ViewModels.Contents
{
	public class ToolsViewModel : TabItemViewModel
	{
		public override string Name
		{
			get { return "ツール"; }
			protected set { throw new NotImplementedException(); }
		}

		#region Items 変更通知プロパティ

		private List<ToolViewModel> _Items;

		public List<ToolViewModel> Items
		{
			get { return this._Items; }
			set
			{
				if (this._Items != value)
				{
					this._Items = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		

		public ToolsViewModel()
		{
			this.Items = new List<ToolViewModel>(PluginHost.Instance.Tools.Select(x => new ToolViewModel(x)));
		}
	}

	public class ToolViewModel : ViewModel
	{
		private readonly IToolPlugin plugin;

		public string Name
		{
			get { return this.plugin.ToolName; }
		}

		public object View
		{
			get { return this.plugin.GetToolView(); }
		}

		public ToolViewModel(IToolPlugin plugin)
		{
			this.plugin = plugin;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
}
