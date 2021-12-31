using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Soket için kütüphane
using System.Net.Sockets;

namespace SifrelemeAlgoritmalariOdev
{
    public partial class Sifreleme : Form
    {
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public byte[] dosyabuffer = new byte[10000];
        public int dosyastatus = 0;
        private DosyaGonder frmDosya;
        //InterNetwork = ipv4 ailesi için
        //SocketType.Dgram= UDP için
        //SocketType.Stream= TCP için
        //ProtocolType.IP = TCP ve UDP
        toROT13 Rot13 = new toROT13();


        public Sifreleme()
        {
            InitializeComponent();
        }
       public int listede_yok = 0; //yok
        byte[] receivedBuf = new byte[1024]; // Veri almak için yer ayırdık
        private void ReceiveData(IAsyncResult ar) // Burası asenkron oldugu için hep çalışır.(thread gibi veriyi almak için)
        {
            

            try
            {
                Socket socket = (Socket)ar.AsyncState; // Asenkron soketi alırız
                int received = socket.EndReceive(ar);  // Verinin toplam uzunluğu
                byte[] dataBuf = new byte[received];   // Veriyi byte çevirdik
                Array.Copy(receivedBuf, dataBuf, received); //dataBuf=receivedBuf ve received uzunluk
                string gelen = Encoding.ASCII.GetString(dataBuf).ToString(); //Serverdan gelen mesaj
                if (gelen.Contains("sil*"))
                {
                    string parcala = gelen.Substring(4, (gelen.Length - 4));
                    Console.WriteLine("degerim  " + parcala);
                    for (int j = 0; j < listBox1.Items.Count; j++) //ListBoxtan da kaldır
                    {
                        if (listBox1.Items[j].Equals(parcala))
                        {
                            listBox1.Items.RemoveAt(j);
                        }
                    }
                }

                else if (gelen.Contains("@")) //içerisinde @ içeriyorsa Client listeye eklenecek 
                {
                    for (int i = 0; i < listBox1.Items.Count; i++) // Listedeki itemler kadar dön
                    {
                        if (listBox1.Items[i].ToString().Equals(gelen)) // Client o listede varsa
                        {
                            listede_yok = 1; // Var
                        }
                    } 

                    if (listede_yok == 0) // Yoksa clienti ekle
                    {
                        string ben = "@" + txName.Text;
                        if (ben.Equals(gelen)) // Kendimi ekleme
                        {

                        }
                        else
                        {
                            listBox1.Items.Add(gelen);
                        }
                    }

                }

                else
                {
                    //label3.Text = (gelen);
                    rb_chat.AppendText(gelen + "\n");
                }
                //rb_chat.AppendText("\nServer: " + label3.Text);
                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
               
               
                /****
                    buffer = Türünde bir dizi Byte yani alınan veri için depolama konumu.
                    offset = Sıfır tabanlı konumu buffer , alınan verileri depolamak parametre.
                    size = Almak için bayt sayısı.
                    socketFlags = Bit seviyesinde birleşimini SocketFlags değerleri.
                    callback = Bir AsyncCallback işlemi tamamlandığında harekete geçirmek için bir yönteme başvuran bir temsilci.
                    state = Alma işlemi hakkında bilgi içeren bir kullanıcı tanımlı nesne.Bu nesne için geçirilen EndReceive işlemi tamamlandığında temsilci.
                ****/

            }
            catch (Exception e)
            {
                Console.WriteLine("ReceiveData() metodunda hata " + e.Message);
            }
        }

        private void SendLoop()
        {
            while (true)
            {
                //Console.WriteLine("Enter a request: ");
                //string req = Console.ReadLine();
                //byte[] buffer = Encoding.ASCII.GetBytes(req);
                //_clientSocket.Send(buffer);

                byte[] receivedBuf = new byte[1024];
                int rev = _clientSocket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    //label3.Text = ("Received: " + Encoding.ASCII.GetString(data));
                    rb_chat.AppendText("\nServer: " + Encoding.ASCII.GetString(data) + "\n");
                }
                else _clientSocket.Close();
            }
        }
       public int attempts = 0;
        private void LoopConnect()
        {
            
            while (!_clientSocket.Connected) // Server çalışmıyorsa (Çalışana kadar döngü döner)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect("127.0.0.1", 100); //127.0.0.1=IPAddress.Loopback demek 100 portuna bağlan
                }
                catch (SocketException)
                {
                    //Console.Clear();
                    //label3.Text = ("bağlantılar: " + attempts.ToString());
                    Console.WriteLine("bağlantılar: " + attempts.ToString());
                }
            }
            // SendLoop();
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket); //AsyncCallback thread gibi asenkron çalışıyor
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + txName.Text); // İsimlerin başına @@ konuldu
            Control.CheckForIllegalCrossThreadCalls = false;
            _clientSocket.Send(buffer); // Veri Servera gönderilir
            label3.Text = ("servere bağlandı!"); // Servera bağlandı
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(LoopConnect);
            t1.Start();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            // girilen metni hangi şifreleme algoritmasıyla yapılacağının kontrolü yapılır 
            if (TxtGirilecek.Text == "")
            {
                MessageBox.Show("Lütfen Bir Değer Girin... ");
            }
            else if (TxtGirilecek.Text != "" && sha256Check.Checked) //CheckBox' da SHA256 seçiliyse
            {
                string input = Console.ReadLine();
                input = TxtGirilecek.Text;
                TxtCevirilmis.Text = Hashing.ToSHA256(input);
            }
            else if (TxtGirilecek.Text != "" && rotCheck.Checked) // CheckBox' da SPN seçiliyse
            {
                string input = Console.ReadLine();
                input = TxtGirilecek.Text;
                TxtCevirilmis.Text = Rot13.toRot13(input);
            }
            else 
            {
                MessageBox.Show("Lütfen bir şifreleme algoritması giriniz...");
            }
        }
      // public string tmpStr = "";
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected) // Client Server'a bağlı ise
            {
                string tmpStr = "";
                foreach (var item in listBox1.SelectedItems) // Listboxtaki seçili itemlere
                {

                    tmpStr = listBox1.GetItemText(item); // İsimlerini
                    byte[] buffer = Encoding.ASCII.GetBytes(tmpStr + " :" + TxtCevirilmis.Text + "*" + txName.Text); // Byte çevirme işlemi
                    _clientSocket.Send(buffer); // Ve gönder
                    Thread.Sleep(20); 
                }
                if (tmpStr.Equals(""))
                {
                    MessageBox.Show("Lütfen listeden değer seçiniz....");
                }
                else
                {
                    rb_chat.AppendText(txName.Text + ": " + TxtCevirilmis.Text + "\n");
                }
            }
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            Thread t1 = new Thread(LoopConnect); //Serverla bağlantı kurulur
            t1.Start();
        }

        private void btn_Dosya_Click(object sender, EventArgs e) 
        {
            // Dosya gönderme ve alma işlemi için form ekranı
            DosyaGonder frm = new DosyaGonder(this);
            frm.list = listBox1;
            frmDosya = frm;
            frm.Show();
            
        }

        private void Sifreleme_Load(object sender, EventArgs e)
        {

        }
        public string tmpStr = "";
        public void sendFile()
        {
            if (dosyastatus == 1)
            {
                if (_clientSocket.Connected) // Client Server'a bağlı ise
                {
                    //string mesaj = dosyabuffer.ToString();
                    
                    foreach (var item in frmDosya.listBox1Dosya.SelectedItems) // Listboxtaki seçili itemlere
                    {

                        tmpStr = listBox1.GetItemText(item); // İsimlerini
                                                             //dosyabuffer += ;
                       // byte[] buffer = Encoding.ASCII.GetBytes(tmpStr + " :" + "dosya gönderildi"+ "*" + txName.Text);
                        _clientSocket.Send(dosyabuffer); // Ve gönder
                        Thread.Sleep(20);
                    }
                    if (tmpStr.Equals(""))
                    {
                        MessageBox.Show("Lütfen listeden değer seçiniz....");
                    }
                    else
                    {
                        rb_chat.AppendText(txName.Text + ": dosyaZIP :" + "dosya gönderildi" + "\n");
                    }
                }

            }
            else
                MessageBox.Show("Hata!");
        }
    }
}
