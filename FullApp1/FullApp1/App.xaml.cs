using FullApp1.Core;
using FullApp1.Modules.ModuleName;
using FullApp1.Services;
using FullApp1.Services.Interfaces;
using FullApp1.Views;
using Module1;
using Module2;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Windows;

namespace FullApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            Container.Resolve<IRegionManager>()
                       .RegisterViewWithRegion<TabHeaderUserControl>(RegionNames.TabRegionName);
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
            moduleCatalog.AddModule<Module1Module>();
            moduleCatalog.AddModule<Module2Module>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            //return new XamlModuleCatalog(new Uri(@"/ModulesCatalog.xaml", UriKind.Relative));
             return base.CreateModuleCatalog();
        }
    }
}
