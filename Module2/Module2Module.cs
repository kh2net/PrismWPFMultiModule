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

namespace Module2
{
    public class Module2Module : IModule
    {
        public Module2Module(IRegionManager regionManager)
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
            ViewModelLocationProvider.Register<TabHeaderModule2UserControl, TabHeaderModule2ViewModel>();
            containerRegistry.RegisterForNavigation<ViewB>(nameof(ViewBViewModel));
        }
    }
}