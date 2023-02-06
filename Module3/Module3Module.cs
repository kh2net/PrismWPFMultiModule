using FullApp1.Core;
using Module1;
using Module1.ViewModels;
using Module2.ViewModels;
using Module2.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Reflection;

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
            _regionManager.RegisterViewWithRegion<TabHeaderModule2UserControl>(RegionNames.TabRegionName);

        }
        private readonly IRegionManager _regionManager;

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<TabHeaderModule2UserControl, TabHeaderModule3ViewModel>();
            containerRegistry.RegisterForNavigation<ViewC>(nameof(ViewCViewModel));
        }
    }
}