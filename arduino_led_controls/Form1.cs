using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace arduino_led_controls
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        string[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            disableControls();

            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                comboBox_serialPort.Items.Add(port);
            }
            if (ports != null && ports.Length !=0 && ports[0] != null)
            {
                comboBox_serialPort.SelectedItem = ports[0];
            }
        }

        private void enableControls()
        {
            checkBox_led1.Enabled = true;
            checkBox_led2.Enabled = true;
            checkBox_led3.Enabled = true;
            groupBox_ledControl.Enabled = true;
        }

        private void disableControls()
        {
            checkBox_led1.Enabled = false;
            checkBox_led2.Enabled = false;
            checkBox_led3.Enabled = false;
            groupBox_ledControl.Enabled = false;
        }

        private void clicked_button_connect(object sender, EventArgs e)
        {
            if (ports == null || ports.Length == 0 || ports[0] == null || comboBox_serialPort.SelectedItem == null)
            {
                MessageBox.Show("Please select a serial port for connection", "Unable to connect");
            }
            else if (!isConnected)
            {
                comboBox_serialPort.Enabled = false;
                string selectedPort = comboBox_serialPort.GetItemText(comboBox_serialPort.SelectedItem);
                port = new SerialPort(selectedPort, 9600);
                port.Open();
                port.Write("Start\n");
                enableControls();

                isConnected = true;
                button_connect.Text = "Disconnect";
            } else
            {
                disableControls();
                port.Write("STOP\n");
                port.Close();
                comboBox_serialPort.Enabled = true;
                
                isConnected = false;
                button_connect.Text = "Connect";
            }
        }

        private void changed_led1(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox_led1.Checked)
                {
                    port.Write("LED1ON\n");
                } else
                {
                    port.Write("LED1OFF\n");
                }
            }
        }

        private void changed_led2(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox_led2.Checked)
                {
                    port.Write("LED2ON\n");
                }
                else
                {
                    port.Write("LED2OFF\n");
                }
            }
        }

        private void changed_led3(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox_led3.Checked)
                {
                    port.Write("LED3ON\n");
                }
                else
                {
                    port.Write("LED3OFF\n");
                }
            }
        }

        public void on_form_close()
        {
            if (isConnected)
            {
                port.Write("STOP\n");
                port.Close();
            }
        }
    }
}
