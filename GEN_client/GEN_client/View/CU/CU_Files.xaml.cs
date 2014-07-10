using GEN_client.Business.CUP;
using GEN_client.Business.SERVU;
using GEN_client.CL_SERVC;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GEN_client.View.CU
{
    /// <summary>
    /// Logique d'interaction pour CU_files.xaml
    /// </summary>
    public partial class CU_Files : Window 
    {

        private List<FILE> files;
        private ObservableCollection<fichierDetail> listFile;
        private STG msg;
        private string img ;
        private string path = "informations.xaml";
        private string state;
        private CL_CUP_Files cupFiles;

        public CU_Files(STG msg)
        {
            InitializeComponent();
            this.cupFiles = new CL_CUP_Files();
            this.listFile = new ObservableCollection<fichierDetail>();
            this.msg = msg;
            this.files = this.cupFiles.getListFile(this.msg);

            foreach(FILE file in this.files){
                this.listFile.Add(new fichierDetail
                {
                    nameFile = file.file_name,
                    state = "En cours de traitement",
                    img = "C:/Users/agathe/Desktop/load.png",
                    key = file.file_code,
                    email = file.file_email,
                    path = this.path,
                    pdfFile = file.file_url,
                    dateFile = file.file_date
                });
            }
            this.listView.ItemsSource = this.listFile;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.DefaultExt = "txt";
            dlg.Filter = " Text files (*.txt)|*.txt";
            //Open the Pop-Up Window to select the file 
            if (dlg.ShowDialog() == true)
            {
                foreach (string dlf in dlg.FileNames)
                {
                    new FileInfo(dlf);
                    using (Stream s = dlg.OpenFile())
                    {

                        var onlyFileName = System.IO.Path.GetFileName(dlf);
                     
                        listFile.Add(new fichierDetail
                        {

                            nameFile = onlyFileName,
                            state = "Non envoyé",
                            key = "",
                            email = "",
                            path = this.path,
                            pdfFile = ""


                        });

                        space.Text = dlf;

                        FILE remplirFile = new FILE();
                        remplirFile.file_name = onlyFileName;
                        remplirFile.content = System.IO.File.ReadAllText(dlf);
                        remplirFile.file_email = null;
                        remplirFile.file_code = null;
                        remplirFile.file_date = DateTime.Now;
                        remplirFile.file_url = null;
                        remplirFile.state = 4;

                        this.files.Add(remplirFile);

                    }
                }

            }
        }


        private async void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            Boolean condition =false;
            foreach(FILE file in this.files)
            {
               if (file.state == 4)
                    {
                        file.state = 3;
                        condition = true;
                    }
            }

            if (!condition)
            {
                this.error.Content = "Aucun fichier à envoyer";
                this.error.Visibility = Visibility.Visible;
            }

            else
            {
                this.error.Content = "";
                //this.refresh();
                STG msg = await this.cupFiles.uploadFiles(this.files,this.msg);
                this.refresh();

            }

        }


        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (FILE file in this.files)
            {
                if (file.state == 1)
                {
                    this.buttonDetail.Visibility = Visibility.Visible;
                }
                else
                {
                    this.buttonDetail.Visibility = Visibility.Hidden;
                }
            }
        }

 



        private void buttonDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            List<FILE> newList = new List<FILE>();
            

            if (this.files.Count != 0)
            { 

                foreach (FILE file in this.files)
                {
                    if (file.state == 4)
                    {
                        newList.Add(file); 
                    }
                }

                foreach (FILE newFile in newList)
                {
                    this.files.Remove(newFile);
                }

                this.refresh();
  
            }
        }


        private void buttonDetail_Click(object sender, RoutedEventArgs e)
        {
            CU_SecretInformations window = new CU_SecretInformations(this.listFile[listView.SelectedIndex]);
            window.ShowDialog();
        }


        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CU_FilesByUser window = new CU_FilesByUser(this.msg);
            window.Show();
   
        }

        private void actu_click(object sender, MouseButtonEventArgs e) 
        {
            this.refresh();
        }

        private async void refresh()
        {

            this.msg = await this.cupFiles.refresh(this.files, this.msg);
            this.files = null;
            this.files = this.cupFiles.getListFile(this.msg);
            this.listFile = null;
            this.listFile = new ObservableCollection<fichierDetail>();

            foreach (FILE file in this.files)
            {
                if (file.state == 0)
                {
                    this.state = "En cours de traitement";
                    this.img = "C:/Users/agathe/Desktop/load.png";
                }
                if (file.state == 1)
                {
                    this.state = "Décrypté";
                    this.img = "C:/Users/agathe/Desktop/check.png";
                }
                if (file.state == 2)
                {
                    this.state = "Non décrypté";
                    this.img = "C:/Users/agathe/Desktop/fail.png";
                }
                if (file.state == 3)
                {
                    this.state = "En cours d'envoi";
                    this.img = "C:/Users/agathe/Desktop/load.png";
                }

                this.listFile.Add(new fichierDetail
                {
                    nameFile = file.file_name,
                    state = this.state,
                    img = this.img,
                    key = file.file_code,
                    email = file.file_email,
                    path = this.path,
                    pdfFile = file.file_url,
                    dateFile = file.file_date
                });
            }
           
            this.listView.ItemsSource = this.listFile;
            ICollectionView view = CollectionViewSource.GetDefaultView(this.listView.ItemsSource);
            view.Refresh();
        }
    }



    public class fichierDetail
    {
        public string img { get; set; }
        public bool finish { get; set; }
        public string nameFile { get; set; }
        public string key { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public string path { get; set; }
        public string pdfFile { get; set; }
        public ListViewItem FocusedItem { get; set; }
        public DateTime dateFile { get; set; }
        

    }


}


