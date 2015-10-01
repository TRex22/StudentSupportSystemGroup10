using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MahApps.Metro.Controls.Dialogs;
using SSS_Library;

namespace VideoStoreExample
{
    public class DialogService
    {
        //TODO Make this into a new library
        public DialogService()
        {
        }

        public async Task<string> CallInputModal(object context, string title, string message)
        {
            var metroDialogSettings = new MetroDialogSettings
            {
                CustomResourceDictionary =
                    new ResourceDictionary
                    {
                        //TODO: Change from default
                        Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.MahApps.Dialogs.xaml")
                    },
                NegativeButtonText = "CANCEL",
                SuppressDefaultResources = true
            };

            return await DialogCoordinator.Instance.ShowInputAsync(context, title, message, metroDialogSettings);
        }

        public async void CallMessageModal(object context, string title, string message)
        {
            var metroDialogSettings = new MetroDialogSettings
            {
                
                CustomResourceDictionary =
                    new ResourceDictionary
                    {
                        //TODO: Change from default
                        Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.MahApps.Dialogs.xaml")
                    },
                NegativeButtonText = "CANCEL",
                SuppressDefaultResources = true
            };

            await DialogCoordinator.Instance.ShowMessageAsync(context, title, message, MessageDialogStyle.Affirmative, metroDialogSettings);
        }

        public async Task<bool> CallAcceptModal(object context, string title, string message)
        {
            var metroDialogSettings = new MetroDialogSettings
            {
                CustomResourceDictionary =
                    new ResourceDictionary
                    {
                        //TODO: Change from default
                        Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.MahApps.Dialogs.xaml")
                    },
                AffirmativeButtonText = "OK",
                NegativeButtonText = "CANCEL",
                SuppressDefaultResources = true
            };

            MessageDialogResult userChoice =  await DialogCoordinator.Instance.ShowMessageAsync(context, title, message, MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings);
            var result = userChoice == MessageDialogResult.Affirmative;
            return result;
        }

        private void LoginDialog()
        {
            //TODO Fix this
            throw new NotImplementedException();
            var metroDialogSettings = new MahApps.Metro.Controls.Dialogs.MetroDialogSettings();
            {
                
            };

            //DialogCoordinator.Instance.ShowLoginAsync(this, "Input Dialog", "Using Material Design Themes", metroDialogSettings);
        }
    }    
}
