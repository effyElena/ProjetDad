using GEN_client.Business.CUP;
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

namespace GEN_client.View.CU
{
    /// <summary>
    /// Logique d'interaction pour CU_Identify.xaml
    /// </summary>
    public partial class CU_Identify : Window
    {
        public CU_Identify()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {

            CL_CUP_Identity identity = new CL_CUP_Identity();

            if (!identity.login(txtUsername.Text, txtPassword.Password))
            {
                errorAuth.Visibility = Visibility.Visible;
            }


            else
            {
                CU_Files fenetre = new CU_Files();
                fenetre.Show();
                this.Close();
            }
        }
    }
}
