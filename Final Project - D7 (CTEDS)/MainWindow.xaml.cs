using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Project___D7__CTEDS_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailInput.Text;
            string password = PasswordInput.Password;
            AutenticationPopUp autenticationPopUp;

            if (Autentication.AutenticateUser(email, password))
            {
                CurrentUser.UserEmail = email;
                CurrentUser.LoginStatus = "autenticaded";

                autenticationPopUp = new AutenticationPopUp();
                autenticationPopUp.Show();
                this.Close();
            } else
            {
                autenticationPopUp = new AutenticationPopUp();
                autenticationPopUp.Show();
            }
        }
    }
}
