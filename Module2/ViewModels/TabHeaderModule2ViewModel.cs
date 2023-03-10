using FullApp1.Core;
using Module2.ViewModels;
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
    public class TabHeaderModule2ViewModel
    {
        private readonly IRegionManager _regionManager;
      
        public TabHeaderModule2ViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            OpenView1Command = new DelegateCommand(OpenView1CommandExec);
            OpenView2Command = new DelegateCommand(OpenView2CommandExec);
        }

        private void OpenView1CommandExec()
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ViewBViewModel));
        }
        private void OpenView2CommandExec()
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ViewCViewModel));
        }
        public ICommand OpenView1Command { get; }
        public ICommand OpenView2Command { get; }
    }
}
