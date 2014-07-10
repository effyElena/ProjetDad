using GEN_client.Business.CUP;
using GEN_client.CL_SERVC;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        private List<FILE> filesByUser;
        ObservableCollection<fichierDetailByUser> listFileByUser;
        private STG msg;
        private CL_CUP_Files cupFiles;
        
        private async void getListHistoFiles()
        {
            this.filesByUser = await this.cupFiles.getListFileHisto(this.msg);

            if (this.filesByUser.Count != 0)
            {
                foreach (FILE file in this.filesByUser)
                {
                    System.Uri uri = new System.Uri(file.file_url);
                    this.hyperlink.NavigateUri = uri;

                    listFileByUser.Add(new fichierDetailByUser
                    {

                        nameFile = file.file_name,
                        date = file.file_date,
                        key = file.file_code,
                        email = file.file_email,
                        pdfFile = uri

                    });
                }
                this.listViewByUser.ItemsSource = listFileByUser;

            }
        }
        public CU_FilesByUser(STG msg)
        {
            this.msg = msg;

            InitializeComponent();
            this.cupFiles = new CL_CUP_Files();
            this.listFileByUser = new ObservableCollection<fichierDetailByUser>();
            this.getListHistoFiles();

        }


        public class fichierDetailByUser
        {

            public string nameFile { get; set; }
            public string key { get; set; }
            public DateTime date { get; set; }
            public string email { get; set; }
            public System.Uri pdfFile { get; set; }

        }

        private void SelectionChanged_FileByUser(object sender, SelectionChangedEventArgs e)
        {
            this.textBlock.Visibility = Visibility.Visible;
        }



        private void returnClick(object sender, RoutedEventArgs e)
        {
            this.msg = this.cupFiles.resetMsg(this.msg);
            CU_Files win = new CU_Files(this.msg);
            win.Show();
            this.Close();
        }

        private void requestNavigateHyperlink(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

     

    }
}
