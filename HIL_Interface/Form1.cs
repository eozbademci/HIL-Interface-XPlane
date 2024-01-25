using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;  //Xplane iletisimi icin tanimlanmistir
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MathWorks.xPCTarget.FrameWork;




namespace HIL_Interface
{
  


    public partial class UserInterface : Form
    {
        //xPCSignal SigCmd;
        //xPCSignal SigFbk;
        //xPCParameter damping;
        xPCTargetPC tg = new xPCTargetPC();
        XPlane xplane = new XPlane();
        bool xplane_exe_flag = false;
        string xplane_path = @"C:\Users\Erdal\Desktop\X-Plane 11";
        public UserInterface()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void targetAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Before trying to connect, make sure we're disconnected first in case we are now connecting to a different target.
                if (tg.IsConnected == true)
                {
                    tg.Disconnect();
                    if (tg.IsConnected != false)
                        MessageBox.Show("Could not Disconnect!");
                }

                // Set the target TCP/IP address and port.
                tg.TcpIpTargetAddress = targetAddressTextBox.Text;
                tg.TcpIpTargetPort = targetPortTextBox.Text;

                // Now connect.
                tg.Connect();
                if (tg.IsConnected == true)
                {
                    MessageBox.Show("Connected!");

                    connectButton.Enabled = false;
                    //loadButton.Enabled = true;
                    //startButton.Enabled = false;
                    //stopButton.Enabled = false;
                    //unloadButton.Enabled = false;
                    disconnectButton.Enabled = true;
                }
                else
                    MessageBox.Show("Could not Connect!");
            }
            catch (xPCException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Disconnect from the target.
                tg.Disconnect();
                if (tg.IsConnected == false)
                {
                    MessageBox.Show("Disconnected!");

                    connectButton.Enabled = true;
                    //loadButton.Enabled = false;
                    //startButton.Enabled = false;
                    //stopButton.Enabled = false;
                    //unloadButton.Enabled = false;
                    disconnectButton.Enabled = false;
                }
                else
                    MessageBox.Show("Could not Disconnect!");
            }
            catch (xPCException me)
            {
                MessageBox.Show(me.Message);
            }
        }


        
        

        void menuClose()
        {
            try
            {
                string dosyaYolu = xplane_path + @"\Output\preferences\X-Plane.prf";
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                int indeks = -1;
                for (int i = 0; i < satirlar.Length; i++)
                {
                    if (satirlar[i].Contains("_show_qfl_on_start")) //satir bulunarak indeksi belirlenir
                    {
                        indeks = i;
                        break;
                    }
                }
                
                if (indeks != -1)
                {
                    satirlar[indeks] = "_show_qfl_on_start 0"; // _show_qfl_on_start bu deger degistirilerek menu ekranı kapatılır
                }
                
                File.WriteAllLines(dosyaYolu, satirlar);
                Console.WriteLine("Menu kapatildi.");

               
            }
            catch (IOException x)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(x.Message);
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string exeDosyaYolu = xplane_path + @"\X-Plane.exe";
            

            if (xplane_exe_flag == false) {
                menuClose();
                xplane.Start(exeDosyaYolu);
                xplane_exe_flag = true;
            }
            else {
                xplane.Close();
                xplane_exe_flag = false;
            }

        }
             

        private void InitialsButton_Click(object sender, EventArgs e)
        {
            // Yeni bir Form örneği oluşturarak açabilirsiniz
            loadingForm loadingFormx = new loadingForm();
            Form2 form = new Form2();
            loadingFormx.Show();
            form.Text = "Initial Conditions";
            form.Show();
            loadingFormx.Close();
        }
    }
}
 
class XPlane
{
    private Process myProcess;

    public void Start(string exeDosyaYolu)
    {
        ProcessStartInfo processStartInfo = new ProcessStartInfo
        {
            FileName = exeDosyaYolu,
            UseShellExecute = true
        };

        try
        {
            myProcess = Process.Start(processStartInfo);            
            Console.WriteLine("Uygulama başlatıldı.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }

    public void Close()
    {
        // && !myProcess.HasExited
        if (myProcess != null)
        {
            try
            {
                myProcess.Kill();

                Console.WriteLine("Uygulama kapatıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Uygulama zaten kapatılmış veya başlatılmamış.");
        }

    }
}