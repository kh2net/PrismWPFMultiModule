using FullApp1.Core;
using Module3.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module3.ViewModels
{
    public class TabHeaderModule3ViewModel
    {
        private readonly IRegionManager _regionManager;
      
        public TabHeaderModule3ViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
            OpenView1Command = new DelegateCommand(OpenView1CommandExec);
        }

        private void OpenView1CommandExec()
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ViewCViewModel));
        }
       
        public ICommand OpenView1Command { get; }
    }
}
