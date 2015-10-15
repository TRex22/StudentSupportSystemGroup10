using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace SSS_Materials_Design_Forms
{
    public class DialogService
    {
        //TODO Make this into a new library
        public DialogService()
        {
        }

        public async Task<string> CallInputModal(MetroWindow metroWindow, string title, string message)
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

            return await metroWindow.ShowInputAsync(title, message, metroDialogSettings);
        }

        public async void CallMessageModal(MetroWindow metroWindow, string title, string message)
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
            await metroWindow.ShowMessageAsync(title, message, MessageDialogStyle.Affirmative, metroDialogSettings);
        }

        public async Task<bool> CallAcceptModal(MetroWindow metroWindow, string title, string message)
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
            
            MessageDialogResult userChoice =  await metroWindow.ShowMessageAsync(title, message, MessageDialogStyle.AffirmativeAndNegative, metroDialogSettings);
            var result = userChoice == MessageDialogResult.Affirmative;
            return result;
        }

        private void LoginDialog()
        {
            //TODO Fix this
            throw new NotImplementedException();
            
            //DialogCoordinator.Instance.ShowLoginAsync(this, "Input Dialog", "Using Material Design Themes", metroDialogSettings);
        }
        //http://mahapps.com/controls/dialogs.html
        //TODO progress dialogue
    }
}
