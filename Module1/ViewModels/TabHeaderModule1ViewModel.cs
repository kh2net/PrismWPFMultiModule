using FullApp1.Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module1.ViewModels
{
    public class TabHeaderModule1ViewModel
    {
        private readonly IRegionManager _regionManager;
      
        public TabHeaderModule1ViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            OpenView1Command = new DelegateCommand(OpenView1CommandExec);
        }

        private void OpenView1CommandExec()
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ViewAViewModel));
        }

        public ICommand OpenView1Command { get; }
    }
}
