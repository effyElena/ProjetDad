using GEN_client.Business.CUP;
using GEN_client.CL_SERVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        private CL_CUP_Identity cupIdentify;
        public CU_Identify()
        {
            InitializeComponent();
            this.cupIdentify = new CL_CUP_Identity();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void LoginClick(object sender, RoutedEventArgs e)
        {

            STG msg = await this.cupIdentify.login(txtUsername.Text, txtPassword.Password);
          

            if (!msg.statut_op)
            {
                errorAuth.Visibility = Visibility.Visible;
            }


            else
            {
                CU_Files fenetre = new CU_Files(msg);
                fenetre.Show();
                this.Close();
            }
        }
    }
}
