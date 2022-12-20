using FullApp1.Core;
using Module1.ViewModels;
using Module1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace Module1
{
    public class Module1Module : IModule
    {
        public Module1Module(IRegionManager regionManager)
        {
            _regionManager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion<TabHeaderModule1UserControl>(RegionNames.TabRegionName);
        }

        private readonly IRegionManager _regionManager;

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<TabHeaderModule1UserControl, TabHeaderModule1ViewModel>();
            containerRegistry.RegisterForNavigation<ViewA>(nameof(ViewAViewModel));
        }
    }
}