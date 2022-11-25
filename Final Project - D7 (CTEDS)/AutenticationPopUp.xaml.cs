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
using System.Windows.Shapes;

namespace Final_Project___D7__CTEDS_
{
    /// <summary>
    /// Interaction logic for AutenticationPopUp.xaml
    /// </summary>
    public partial class AutenticationPopUp : Window
    {
        public AutenticationPopUp()
        {
            InitializeComponent();
            if(CurrentUser.LoginStatus == "not autenticated")
            {
                AutenticationMessage.Content = "Credenciais inválidas";
            } else if(CurrentUser.LoginStatus == "autenticaded")
            {
                AutenticationMessage.Content = "Usuário autenticado!";
            }
        }
    }
}
