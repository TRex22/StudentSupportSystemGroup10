using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace SSS_Materials_Design_Forms
{
    /// <summary>
    /// Interaction logic for CreatePassword.xaml
    /// </summary>
    public partial class CreatePassword : MetroWindow
    {
        private readonly DialogService _dialogService = new DialogService();

        public string Password
        {
            get { return PasswordTextBox.Password; }
            set { PasswordTextBox.Password = value; }
        }
        public bool CreatedPassword { get; set; }
        
        public CreatePassword()
        {
            InitializeComponent();
            CreatedPassword = false;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //check they dont equal
            if (!PasswordTextBox.Password.Equals(ConfirmPasswordTextBox.Password))
            {
                _dialogService.CallMessageModal(this, "", SSS.Properties.Resources.PassWordCreateDoNotMatchError);
            }
            else if (PasswordTextBox.Password.Equals(ConfirmPasswordTextBox.Password))
            {
                this.Password = ConfirmPasswordTextBox.Password;
                DialogResult = true;
                this.CreatedPassword = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Password = null;
            this.CreatedPassword = false;
            this.Close();
        }
        
        /*public DialogResult ShowDialog(out string result)
        {
            DialogResult dr = ShowDialog();
            result = (dr.Equals(""))
               ? null
               : Password;
            return dr;
        }*/
    }
}
