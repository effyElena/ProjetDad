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
    /// Logique d'interaction pour CU_secretInformations.xaml
    /// </summary>
    public partial class CU_SecretInformations : Window
    {
        fichierDetail fichierdetails;
        public CU_SecretInformations(fichierDetail fichier)
        {
            InitializeComponent();
            this.fichierdetails = fichier;
            this.titleFile.Content = this.fichierdetails.nameFile.SafeFileName;
            this.nameFile.Content = this.fichierdetails.nameFile.SafeFileName;
            this.code.Content = this.fichierdetails.key;
            this.secretInfo.Content = this.fichierdetails.email;
       
        }
    }
}
