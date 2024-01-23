using System;
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
                tg.TcpIpTargetPort = "22222";

                // Now connect.
                tg.Connect();
                if (tg.IsConnected == true)
                {
                    MessageBox.Show("Connected!");

                    connectButton.Enabled = false;
                    loadButton.Enabled = true;
                    startButton.Enabled = false;
                    stopButton.Enabled = false;
                    unloadButton.Enabled = false;
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
                    loadButton.Enabled = false;
                    startButton.Enabled = false;
                    stopButton.Enabled = false;
                    unloadButton.Enabled = false;
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
    }
}
