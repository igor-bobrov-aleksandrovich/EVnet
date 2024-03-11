//using MVVMsmoke.ViewModel;
//using MVVMsmoke.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVnet.View;

namespace EVnet
{
    abstract class WindowsBuilder
    {
        public static void ShowMainWindow()
        {
            var window = new MainForm();
            var viewModel = new MainWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }       
        /*public static void ShowRegWindow()
        {
            var window = new RegistrationWindow();
            var viewModel = new RegistrationWindowModel();
            window.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { window.Close(); };
            window.Show();
        }
        public static void ShowStoreWindow()
        {
            StoreWindow storeWindow = new StoreWindow();
            var viewModel = new StoreWindowModel();
            storeWindow.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { storeWindow.Close(); };
            storeWindow.Show();
        }*/
    }
}
