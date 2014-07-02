using GEN_client.Business.CUP;
using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GEN_client.View.CU
{
    /// <summary>
    /// Logique d'interaction pour CU_files.xaml
    /// </summary>
    public partial class CU_Files : Window
    {

        private string file; 
        ObservableCollection<fichierDetail> listFile = new ObservableCollection<fichierDetail>();

        public ObservableCollection<fichierDetail> list
        {
            get { return listFile; }
        }

        public CU_Files()
        {
            InitializeComponent();
            listView.ItemsSource = list;


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

                        string waiting = "En cours";
                        string wainting2 = "Traitement non résolu";
                        string waiting3 = " Traitement résolu";
                        string wait = "";

                        if (waiting3 == " Traitement résolu")
                        {
                            wait = " Traitement résolu";
                        }

                        string img = "C:/Users/agathe/Desktop/load.png";

                        string path = "informations.xaml";
                        CheckBox check = new CheckBox();
                        Debug.Write(dlf);
                        listFile.Add(new fichierDetail
                        {
                            
                            nameFile = dlf,
                            pdfFile = wait,
                            img = img,
                            key = "toto",
                            email = "terroriste@viacesi.fr",
                            path = path,


                        });

                        space.Text = dlf;
                        string copy = System.IO.File.ReadAllText(dlf);
                        this.file = copy;

                    }
                }

            }
        }


        private void buttonSend_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(space.Text))
            {
                error.Content = "Le fichier n'a pas été trouvé.";
                error.Visibility = Visibility.Visible;
            }
            int length = space.Text.Length;
            string typeFile = space.Text.Substring(length - 4);

            if (typeFile != ".txt")
            {
                error.Content = "Le fichier n'est pas au format .txt ";
                error.Visibility = Visibility.Visible;
            }

            else
            {
                CL_CUP_Files files = new CL_CUP_Files();
                files.sendFiles(this.file);

            }

        }


        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonDetail.Visibility = Visibility.Visible;

        
        }
        
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {


            listFile.RemoveAt(listView.SelectedIndex);
    
        }

        private void buttonDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            listFile.Clear();
            
        }


        private void buttonDetail_Click(object sender, RoutedEventArgs e)
        {
            CU_SecretInformations window = new CU_SecretInformations(this.listFile[listView.SelectedIndex]);

            window.ShowDialog();
        }




    }



    public class fichierDetail
    {
        public string img { get; set; }
        public bool finish { get; set; }
        public string nameFile { get; set; }
        public string key { get; set; }
        public string pdfFile { get; set; }
        public string email { get; set; }
        public string path { get; set; }
        public ListViewItem FocusedItem { get; set; }
        

    }


}


