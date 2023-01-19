global using System;
global using System.Collections.Generic;
global using CommunityToolkit.Mvvm;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
global using System;
global using System.Collections.Generic;
global using System.Configuration;
global using System.Data;
global using System.Linq;
global using System.Threading.Tasks;
global using System.Windows;
global using MVVMLoginRapiD.Views;
global using MVVMLoginRapiD.ViewModel;

namespace MVVMLoginRapiD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainwindow = new MainWindow();
            mainwindow.DataContext = new MainViewModel();
            mainwindow.ShowDialog();
        }
        public App()
        {

        }

    }
}
