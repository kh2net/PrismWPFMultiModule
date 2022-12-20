using FullApp1.Core;
using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FullApp1.ViewModels
{
    public class TabHeaderViewModel
    {
        private readonly IRegionManager _regionManager;

        public TabHeaderViewModel(IRegionManager regionManager )
        {
            _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));

            UserProfileCommand = new DelegateCommand(() =>
                _regionManager.RequestNavigate(RegionNames.ContentRegion, "ProfileView"));
 
        }

        public ICommand UserProfileCommand { get; }

        public ICommand LogOutCommand { get; }
    }
}
