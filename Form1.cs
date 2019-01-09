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
        private readonly Mutex FluidxMutex = new Mutex();
        int connection_status = 0;
        public Form1()
        {
            InitializeComponent();
            Globals.FluidxPort = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
            try
            {
                Globals.FluidxPort.Open();
            }
            catch (Exception) { }
           // Globals.FluidxPort.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            portWrite("kl \r");
            portWrite("cm \r");

        }

        private void ON_OFF_button_Click_1(object sender, EventArgs e)
        {
            if (ON_OFF_button.Text == "TURN ON")
            {
                ON_OFF_button.BackColor = Color.Lime;
                ON_OFF_button.Text = "TURN OFF";
                //SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
                //port.Open();
                portWrite("kl \r");
                portWrite("PIN\r");
                portWrite("PTS 5000 700 1\r");
                //portClose();
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
            string Com_Number = Com_Select.Text;
            connection_status = 1;
            portWrite( "cm\r");
            //PortChat.Serial_Connection();
        }


        private void SendTest()
        {
            // Instantiate the communications
            // port with some basic settings
           // SerialPort port = new SerialPort(
            //  "COM3", 9600, Parity.Odd, 8, StopBits.One);

            // Open the port for communications
          //  port.Open();

            // Write a string
         //   System.Threading.Thread.Sleep(1000);
          //  port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            
           // port.Close();
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

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
            Globals.FluidxPort.Close();
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

        private void button13_Click(object sender, EventArgs e)
        {
            //SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

            //port.Open();
            //   System.Threading.Thread.Sleep(1000);
            //port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            
            portWrite( "dcap 11\r");
            portWrite( "PIN\r");
            portWrite( "LHP 11\r");
            portWrite( "PTS 2000 700 1\r");
            portWrite( "rcap 11\r");

            //port.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

           // port.Open();
           // port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);

            portWrite( "to \r");
            System.Threading.Thread.Sleep(6350);
            portWrite( "tc \r");

            //port.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

           // port.Open();
           // port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);

            portWrite( "dcap 11\r");
            portWrite( "pc 11 \r");
            portWrite( "gc 11 \r");
            portWrite( "rcap 11\r");

           // port.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fire_commands("dcap", "0-11\0", "", "", "");
            fire_commands("rcap", "0-11\0", "", "", "");
        }

        private void bulkfill_Click(object sender, EventArgs e)
        {
            //SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
            //port.Open();
           // port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            portWrite("LHBF 1000 500\r");
           // port.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string row_field = textBox8.Text + "\0";
            fire_commands("dcap", row_field,"","", "");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string row_field = textBox8.Text + "\0";
            fire_commands("rcap", row_field,"","", "");
        }//buttonclick

        private void fire_commands(string single_command, string row_field, string arg2, string arg3, string arg4)
        {
            
            StringBuilder return_code = new StringBuilder();
            int end_number = -1;
            StringBuilder end_string = new StringBuilder();
            bool hyphen = false;
            StringBuilder parameter = new StringBuilder();
            StringBuilder command = new StringBuilder();
            command.Append(single_command).Append(" ");
            StringBuilder forming_number_string = new StringBuilder();
            //string row_field = textBox8.Text + "\0";

            int max_rows = 11;
            int forming_number = -1;

            //SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
            //port.Open();
            //port.DtrEnable = true;
            //port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            portWrite("PIN\r");
            for (int i = 0; i < row_field.Length; i++)
            {
                if (hyphen == false && System.Char.IsDigit(row_field, i) == true && forming_number == -1)
                {
                    forming_number_string.Append(row_field[i]);
                    forming_number = (int)char.GetNumericValue(row_field[i]);
                }//if
                else if (System.Char.IsDigit(row_field, i) == true && hyphen == true && end_number == -1)
                {
                    end_string.Append(row_field[i]);
                    end_number = (int)char.GetNumericValue(row_field[i]);
                }
                else if (System.Char.IsDigit(row_field, i) == true && hyphen == true)
                {
                    end_string.Append(row_field[i]);
                    end_number = end_number * 10 + (int)char.GetNumericValue(row_field[i]);
                }
                else if (System.Char.IsDigit(row_field, i) == true && hyphen == false)
                {
                    forming_number_string.Append(row_field[i]);
                    forming_number = forming_number * 10 + (int)char.GetNumericValue(row_field[i]);
                }

                    //NO HYPHEN
                else if (hyphen == false && (row_field[i] == ',' || row_field[i] == ' ' || row_field[i] == '\n' || row_field[i] == '\0'))
                {
                    
                    if (forming_number > max_rows || forming_number == -1)
                    {
                        continue;
                    }

                    parameter.Append(forming_number_string);
                    command.Append(parameter).Append("\r");
                    if(single_command == "rcap"){
                      portWrite( "gc " + parameter.ToString() + "\r");                    
                      portWrite( command.ToString());
                    }
                    else if(single_command == "dcap"){
                      portWrite( command.ToString());
                      portWrite( "pc " + parameter.ToString() + "\r"); 
                    }
                    else if (single_command == "LHP")
                    {
                        portWrite( command.ToString());
                        portWrite( "PTS " + arg2 + " " + arg3 + arg4 + "\r");
                    }
                    else
                    {
                        Warning.Text = "Warning: Missed a single command";
                    }
                    parameter.Clear();
                    command.Clear();
                    command.Append(single_command).Append(" ");
                    forming_number_string.Clear();
                    forming_number = -1;
                    //status_report.Text = Globals.FluidxPort.ReadLine();
                }//elseif NO HYPHEN

                    //HYPHEN
                else if (hyphen == true && (row_field[i] == ',' || row_field[i] == ' ' || row_field[i] == '\n' || row_field[i] == '\0'))
                {

                    if (forming_number > max_rows || forming_number == -1)
                    {
                        continue;
                    }

                    for (int j = forming_number; j <= end_number; j++)
                    {
                        parameter.Append(forming_number_string);
                        command.Append(parameter).Append("\r");
                        if (single_command == "rcap")
                        {
                            portWrite( "gc " + parameter.ToString() + "\r");
                            portWrite(command.ToString());
                        }
                        else if (single_command == "dcap")
                        {
                            portWrite( command.ToString());
                            portWrite( "pc " + parameter.ToString() + "\r");
                        }
                        else if (single_command == "LHP")
                        {
                            portWrite(command.ToString());
                            portWrite( "PTS " + arg2 + " " + arg3 + arg4 + "\r");
                        }
                        else
                        {
                            Warning.Text = "Warning: Missed a single command";
                        }

                        parameter.Clear();
                        command.Clear();
                        command.Append(single_command).Append(" ");
                        forming_number_string.Clear();
                        if(j != end_number)
                        {
                            forming_number_string.Append((j+1).ToString());
                        }
                        //status_report.Text = Globals.FluidxPort.ReadLine();
                    }




                    parameter.Clear();
                    command.Clear();
                    command.Append(single_command).Append(" ");
                    forming_number_string.Clear();
                    forming_number = -1;
                    end_number = -1;
                    end_string.Clear();
                    //if (row_field[i] != ' ')
                    //{
                        hyphen = false;
                    //}
                }//elseif HYPHEN
                else if (row_field[i] == '-')
                {
                    hyphen = true;
                }

            }//for

           // port.Close();
        }//fire_commands

        private void thread_safe_port_write(string message)
        {
            FluidxMutex.WaitOne();
            try
            {
                Globals.FluidxPort.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
                Globals.FluidxPort.ReadLine();
                Globals.FluidxPort.Write(message);
                progress_report.Text = "Processing: " + message;
                status_report.Text = "Status report: " + Globals.FluidxPort.ReadLine();
            }
            finally
            {
                FluidxMutex.ReleaseMutex();
            }
        }

        private void portWrite(string message)
        {
          //  Thread t = new Thread(new ParameterizedThreadStart(thread_safe_port_write));

            FluidxMutex.WaitOne();
            try
            {
                Globals.FluidxPort.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
                Globals.FluidxPort.ReadLine();
                Globals.FluidxPort.Write(message);
                progress_report.Text = "Processing: " + message;
                status_report.Text = "Status report: " + Globals.FluidxPort.ReadLine();
            }
            finally
            {
                FluidxMutex.ReleaseMutex();
            }
        }



        private void select_command(SerialPort port)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string row_field = textBox3.Text + "\0";
            if (checkBox1.Text == "Checked")
            {
                fire_commands("LHP", row_field, textBox4.Text, textBox5.Text, " -1");
            }
            else
            {
                fire_commands("LHP", row_field, textBox4.Text, textBox5.Text, " 1");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            //SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

            //port.Open();
            //port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);

            portWrite("rcap 9\r");
            //label9.Text = port.ReadLine();
            //port.Close();
        }

        private void status_report_Click(object sender, EventArgs e)
        {

        }

        //private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        //{
        //    var port = (SerialPort)sender;
        //    string data = port.ReadExisting();

        //    UpdateGui(data);
        //}

        //private void UpdateGui(string data)
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke(new Action(d => UpdateGui(d)));
        //        return;
        //    }

        //    this.txtBox1.Text = data;
        //}
    }

    public class Globals
    {
        public static SerialPort FluidxPort;
        public static bool DeviceBusy = false;
    }
}
