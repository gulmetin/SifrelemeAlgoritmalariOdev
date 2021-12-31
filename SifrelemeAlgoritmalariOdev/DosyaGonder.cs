using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

// Sıkıştırma kütüphaneleri
using System.IO;
using System.IO.Compression;

namespace SifrelemeAlgoritmalariOdev
{
    public partial class DosyaGonder : Form
    {
        private static string shortFileName = "";
        public ListBox list = new ListBox();

        private Sifreleme frmsifre;

        byte[] bufferzip = new byte[10000];

        private void DosyaGonder_Load(object sender, EventArgs e)
        {
            foreach (var item in list.Items)
            {
                listBox1Dosya.Items.Add(item);
            }

            string tmpStr = "";
            foreach (var item in listBox1Dosya.SelectedItems) // Listboxtaki seçili itemlere
            {

                tmpStr = listBox1Dosya.GetItemText(item); // İsimlerini
                frmsifre.dosyabuffer = bufferzip;
                //byte[] buffer = Encoding.ASCII.GetBytes(tmpStr + " :" + TxtCevirilmis.Text + "*" + txName.Text); // Byte çevirme işlemi
                //_clientSocket.Send(buffer); // Ve gönder
                //Thread.Sleep(20);
            }
            if (tmpStr.Equals(""))
            {
                MessageBox.Show("Lütfen listeden değer seçiniz....");
            }
        }

        public DosyaGonder(Sifreleme frmsifre)
        {
            InitializeComponent();
            this.frmsifre = frmsifre;

        }
        public DosyaGonder()
        {
            InitializeComponent();
           

        }

        private void btn_Zip_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // Bilgisayardaki dosyala görebilmek için 
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // Klasörler arasında gezinmek ve bir klasör seçmek için
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Ionic.Zip.ZipFile zf = new Ionic.Zip.ZipFile("‪C:\\Users\\Lenovo\\Desktop\\NewZip.zip"); // Iconic.zip kullanılarak seçilen dizindeki
                zf.AddFile(ofd.FileName, "");                                                       // istenilen dosya veya belge zip dosyasına döüştürülür.
                zf.Save("C:\\Users\\Lenovo\\Desktop\\NewZip.zip"); // NewZip adında dosya oluşturulur ve dizine kaydedilir.
                MessageBox.Show("Dosyanız ziplenmiştir.");
                txtUrl.Text = "C:\\Users\\Lenovo\\Desktop\\NewZip.zip";
            }
        }

        private void btn_yUkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); // Bilgisayar dosya gezgini açılır. 
            dlg.Title = "Dosya Yükleme";
  
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = dlg.FileName;
                shortFileName = dlg.SafeFileName;
                string fileName = dlg.FileName;
                try
                {
                    frmsifre.dosyabuffer = File.ReadAllBytes(fileName);

                }
                catch (Exception) { }
            }
        }

        private void btn_Al_Click(object sender, EventArgs e)
        { 
            //Gönderilen dosyanın bilgisayar üzerinde hangi dizine kaydedeileceği işlemidir
            //Dosya alma kısmı yok

            SaveFileDialog sfd = new SaveFileDialog(); // Dosyanın hangi dizine kaydedileceği
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg; *png|Bitmap(*.bmp)|*.bmp"; // Gelen dosyanın hangi uzantıyla kaydedileceğini seçmek için
            sfd.DefaultExt = "txt"; //Varsayılan dosya uzantısı
            sfd.Title = "Dosya Kayıt";
            DialogResult sonuç = sfd.ShowDialog();
            sfd.FileName = "New File"; //Varsayılan dosya adı
            MessageBox.Show("Dosyanız seçtiğiniz dizine kaydedildi.");
        }

       
        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            frmsifre.dosyastatus = 1;
            frmsifre.sendFile();
        }
    }
}