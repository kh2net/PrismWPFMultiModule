using FullApp1.Core;
using Module3;
using Module3.ViewModels;
using Module3.ViewModels;
using Module3.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Reflection;
using WpfLibrary1.Views;

namespace Module3
{
    public class Module3Module : IModule
    {
        public Module3Module(IRegionManager regionManager)
        {
            _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<TabHeaderModule3UserControl>(RegionNames.TabRegionName);

        }
        private readonly IRegionManager _regionManager;

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<TabHeaderModule3UserControl, TabHeaderModule3ViewModel>();
            containerRegistry.RegisterForNavigation<ViewC>(nameof(ViewCViewModel));
        }
    }
}