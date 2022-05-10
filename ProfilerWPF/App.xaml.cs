using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using ProfilerWPF.data;
using ProfilerWPF.data.Contexts;
using ProfilerWPF.gui.Services;
using ProfilerWPF.gui.ViewModels.DialogWindows;
using ProfilerWPF.gui.ViewModels.Settings;
using ProfilerWPF.gui.Views;
using ProfilerWPF.gui.Views.DialogWindows;
using ProfilerWPF.gui.Views.Drawers.FileMenu;
using ProfilerWPF.gui.Views.Settings;
using ProfilerWPF.gui.Views.Settings.Tools;
using ProfilerWPF.rendering.renderer;
using ProfilerWPF.gui.Views.Sidebar.Menus;
using ProfilerWPF.interOp;
using ProfilerWPF.Services;
// using ProfilerWPF.src.AmcMediator;
using ProfilerWPF.src;
using ProfilerWPF.src.Services;

namespace ProfilerWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<SettingsPopup, SettingsPopupViewModel>();


            //containerRegistry.RegisterDialog<SettingsView,SettingsViewModel>();
            containerRegistry.RegisterForNavigation<Tools>();

            //Database Connection Dependency Injection
            containerRegistry.RegisterSingleton<ISqlLiteSettings, SqlLiteSettings>();

            //Data access Layer Dependency Injection

            //Services Dependency Injection

            // containerRegistry.RegisterSingleton<IAmcMediator, AmcMediator>();

            //Renderer Dependency Injection - ultimately communication with renderer should be mediated purely through the event aggregator
            containerRegistry.RegisterSingleton<IAmcMediator, AmcMediator>();
            containerRegistry.RegisterSingleton<IRobotSystemsXS2515SQLiteformat3Context, RobotSystemsXS2515SQLiteformat3Context>();
            containerRegistry.RegisterSingleton<IFilePathGenerator, FilePathGenerator>();
            containerRegistry.RegisterSingleton<IDRMHandler, DRMHandler>();
            containerRegistry.RegisterSingleton<IRSQdbo, RSQdbo>();
            containerRegistry.RegisterSingleton<IDXFService, DXFService>();
            containerRegistry.RegisterInstance(new Renderer(Container.Resolve<IEventAggregator>(),Container.Resolve<IAmcMediator>()));
            containerRegistry.RegisterSingleton<IFileService, FileService>();

            //Dialog Services
            //containerRegistry.RegisterDialog<SettingsPopup,SettingsPopupViewModel>();
            containerRegistry.RegisterDialog<ConfirmationDialog, ConfirmationDialogViewModel>();

            //Region Views Registration
            containerRegistry.RegisterForNavigation<TransformContent>();
            containerRegistry.RegisterForNavigation<Tools>();
            containerRegistry.RegisterForNavigation<OpenFileContent>();
            containerRegistry.RegisterForNavigation<SaveFileContent>();
            containerRegistry.RegisterForNavigation<ImportFileContent>();
            containerRegistry.RegisterForNavigation<DefaultFileContent>();

            //AmcMediator Dependency Injection 
            //containerRegistry.RegisterInstance(new AmcMediator(Container.Resolve<IEventAggregator>()));
            containerRegistry.RegisterSingleton<IShellService, ShellService>();
            

        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var _regionManager = Container.Resolve<RegionManager>();
            _regionManager.RegisterViewWithRegion("MainScreenContent", typeof(SettingsPopup));

        }

    }
}
