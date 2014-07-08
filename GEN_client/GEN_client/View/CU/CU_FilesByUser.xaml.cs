using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Logique d'interaction pour CU_FilesByUser.xaml
    /// </summary>
    public partial class CU_FilesByUser : Window
    {
        List<String> filesByUser = new List<string>();
        ObservableCollection<fichierDetailByUser> listFile = new ObservableCollection<fichierDetailByUser>();

        public ObservableCollection<fichierDetailByUser> list
        {
            get { return listFile; }
        }

        public CU_FilesByUser()
        {
            InitializeComponent();
            filesByUser.Add("azz");
            filesByUser.Add("sdsd");
            listViewByUser.ItemsSource = list;

                foreach (string files in filesByUser)
                {
                  
                    listFile.Add(new fichierDetailByUser
                    {

                        nameFile = "rger",
                        date = "19/03/1993",
                        key = "toto2",
                        email = "terroriste@viacesi.fr"

                    });
                }
            
        }


        public class fichierDetailByUser
        {

            public string nameFile { get; set; }
            public string key { get; set; }
            public string date { get; set; }
            public string email { get; set; }

        }

        private void SelectionChanged_FileByUser(object sender, SelectionChangedEventArgs e)
        {
            buttonSeeDetails.Visibility = Visibility.Visible;
        }
    }
}
