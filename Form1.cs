using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
//using System.Threading.Tasks;

namespace Csharp_GUI
{
    public partial class Form1 : Form
    {
        int connection_status = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ON_OFF_button_Click_1(object sender, EventArgs e)
        {
            if (ON_OFF_button.Text == "TURN ON")
            {
                ON_OFF_button.BackColor = Color.Lime;
                ON_OFF_button.Text = "TURN OFF";
            }
            else if (ON_OFF_button.Text == "TURN OFF")
            {
                ON_OFF_button.BackColor = Color.Firebrick;
                ON_OFF_button.Text = "TURN ON";
            }
        }

        private void Speed20_Click_1(object sender, EventArgs e)
        {
           // if(ON_OFF_button.Text == "TURN OFF")
                label1.Text = "Speed: 20%";
        }

        private void Speed10_Click_1(object sender, EventArgs e)
        {
          //  if (ON_OFF_button.Text == "TURN OFF")
                label1.Text = "Speed: 10%";
        }

        private void Speed40_Click_1(object sender, EventArgs e)
        {
          //  if (ON_OFF_button.Text == "TURN OFF")
                label1.Text = "Speed: 40%";
        }

        private void Speed80_Click_1(object sender, EventArgs e)
        {
            //if (ON_OFF_button.Text == "TURN OFF")
                label1.Text = "Speed: 80%";
        }

        private void Connect_to_Machine_Click_1(object sender, EventArgs e)
        {
            connection_status = 1;
            SendTest();
            //PortChat.Serial_Connection();
        }


        private static void SendTest()
        {
            // Instantiate the communications
            // port with some basic settings
            SerialPort port = new SerialPort(
              "COM3", 9600, Parity.Odd, 8, StopBits.One);

            // Open the port for communications
            port.Open();

            // Write a string
            //System.Threading.Thread.Sleep(1000);
            //port.Write("kl\n");
            //System.Threading.Thread.Sleep(1000);
            //port.Write("kl\n");
            //System.Threading.Thread.Sleep(1000);
            //port.Write("cm\n");
            //System.Threading.Thread.Sleep(1000);
            //port.Write("cm\n");

            //Convert.ToByte("k");
            char[] kl = new char[3];
            kl[0] = 'k';
            kl[1] = 'l';
            kl[2] = '\n';

            char[] cm = new char[3];
            kl[0] = 'c';
            kl[1] = 'm';
            kl[2] = '\n';
            // Write a set of bytes
            //port.Write(new byte[] { 0x63, 0x6D, 0xFF }, 0, 3);
//            port.Write(new byte[] { 0x6B, 0x6C, 0xFF }, 0, 3);
          //  System.Threading.Thread.Sleep(1000);
           // port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            //if (port.ReadChar() != 'A')
            //{
            //    port.Close();
            //    throw new Exception("No acknowledge from target!");
            //}
         //   System.Threading.Thread.Sleep(1000);
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
           // System.Threading.Thread.Sleep(1000);
            port.Write("cm\r");
            //port.Write(new byte[] { 0x63, 0x6D, 0x0D }, 0, 3);
          //  System.Threading.Thread.Sleep(1000);
            //port.Write(new byte[] { 0x63, 0x6D, 0x0D }, 0, 3);
            // Close the port
            port.Close();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public class PortChat
        {
            static bool _continue;
            static SerialPort _serialPort;

            public static void Serial_Connection()
            {
                AllocConsole();
                string name;
                string message;
                StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
                Thread readThread = new Thread(Read);

                // Create a new SerialPort object with default settings.
                _serialPort = new SerialPort();

                // Allow the user to set the appropriate properties.
                _serialPort.PortName = SetPortName(_serialPort.PortName);
                _serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
                _serialPort.Parity = SetPortParity(_serialPort.Parity);
                _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
                _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
                _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;

                _serialPort.Open();
                _continue = true;
                readThread.Start();
                Console.Write("Name: ");
                name = Console.ReadLine();
                
                Console.WriteLine("Type QUIT to exit");

                while (_continue)
                {
                    message = Console.ReadLine();
                    //message = "quit";
                    if (stringComparer.Equals("quit", message))
                    {
                        _continue = false;
                    }
                    else
                    {
                        _serialPort.WriteLine(
                            String.Format("<{0}>: {1}", name, message));
                    }
                }

                readThread.Join();
                _serialPort.Close();
            }

            public static void Read()
            {
                while (_continue)
                {
                    try
                    {
                        string message = _serialPort.ReadLine();
                        Console.WriteLine(message);
                    }
                    catch (TimeoutException) { }
                }
            }

            // Display Port values and prompt user to enter a port.
            public static string SetPortName(string defaultPortName)
            {
                string portName;

                Console.WriteLine("Available Ports:");
                foreach (string s in SerialPort.GetPortNames())
                {
                    Console.WriteLine("   {0}", s);
                }

                Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
                portName = Console.ReadLine();
                portName = "COM2";
                if (portName == "" || !(portName.ToLower()).StartsWith("com"))
                {
                    portName = defaultPortName;
                }
                return portName;
            }
            // Display BaudRate values and prompt user to enter a value.
            public static int SetPortBaudRate(int defaultPortBaudRate)
            {
                string baudRate;

                Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
                baudRate = Console.ReadLine();
                baudRate = "9600";
                if (baudRate == "")
                {
                    baudRate = defaultPortBaudRate.ToString();
                }

                return int.Parse(baudRate);
            }

            // Display PortParity values and prompt user to enter a value.
            public static Parity SetPortParity(Parity defaultPortParity)
            {
                string parity;

                Console.WriteLine("Available Parity options:");
                foreach (string s in Enum.GetNames(typeof(Parity)))
                {
                    Console.WriteLine("   {0}", s);
                }

                Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
                parity = Console.ReadLine();
                parity = "None";
                if (parity == "")
                {
                    parity = defaultPortParity.ToString();
                }

                return (Parity)Enum.Parse(typeof(Parity), parity, true);
            }
            // Display DataBits values and prompt user to enter a value.
            public static int SetPortDataBits(int defaultPortDataBits)
            {
                string dataBits;

                Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
                dataBits = Console.ReadLine();
                dataBits = "8";
                if (dataBits == "")
                {
                    dataBits = defaultPortDataBits.ToString();
                }

                return int.Parse(dataBits.ToUpperInvariant());
            }

            // Display StopBits values and prompt user to enter a value.
            public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
            {
                string stopBits;

                Console.WriteLine("Available StopBits options:");
                foreach (string s in Enum.GetNames(typeof(StopBits)))
                {
                    Console.WriteLine("   {0}", s);
                }

                Console.Write("Enter StopBits value (None is not supported and \n" +
                 "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
                stopBits = Console.ReadLine();
                stopBits = "1";
                if (stopBits == "")
                {
                    stopBits = defaultPortStopBits.ToString();
                }

                return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
            }
            public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
            {
                string handshake;

                Console.WriteLine("Available Handshake options:");
                foreach (string s in Enum.GetNames(typeof(Handshake)))
                {
                    Console.WriteLine("   {0}", s);
                }

                Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
                handshake = Console.ReadLine();
                handshake = "None";
                if (handshake == "")
                {
                    handshake = defaultPortHandshake.ToString();
                }

                return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forward_or_backward_label_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Forward_or_backward_label.Text = "Forward";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forward_or_backward_label.Text = "Back";
        }

        private void Connection_Status_Click(object sender, EventArgs e)
        {

        }

        private void Disconnect_Button_Click(object sender, EventArgs e)
        {
            connection_status = 2;
        }

    }


}
