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
                SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
                port.Open();
                port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
                port.Write("PIN\r");
                port.Write("PTS 5000 700 1\r");
                port.Close();
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
         //   System.Threading.Thread.Sleep(1000);
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            port.Write("cm\r");
            port.Close();
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
            SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

            port.Open();
            //   System.Threading.Thread.Sleep(1000);
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            
            port.Write("dcap 11\r");
            port.Write("PIN\r");
            port.Write("LHP 11\r");
            port.Write("PTS 2000 700 1\r");
            port.Write("rcap 11\r");

            port.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

            port.Open();
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);

            port.Write("to \r");
            System.Threading.Thread.Sleep(6350);
            port.Write("tc \r");

            port.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);

            port.Open();
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);

            port.Write("dcap 11\r");
            port.Write("pc 11 \r");
            port.Write("gc 11 \r");
            port.Write("rcap 11\r");

            port.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
            port.Open();
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            port.Write("dcap 11\r");
            port.Write("pc 11 \r");
            port.Write("dcap 10\r");
            port.Write("pc 10 \r");
            port.Write("dcap 9\r");
            port.Write("pc 9 \r");
            port.Write("dcap 8\r");
            port.Write("pc 8 \r");
            port.Write("dcap 7\r");
            port.Write("pc 7 \r");
            port.Write("dcap 6\r");
            port.Write("pc 6 \r");
            port.Write("dcap 5\r");
            port.Write("pc 5 \r");
            port.Write("dcap 4\r");
            port.Write("pc 4 \r");
            port.Write("dcap 3\r");
            port.Write("pc 3 \r");
            port.Write("dcap 2\r");
            port.Write("pc 2 \r");
            port.Write("dcap 1\r");
            port.Write("pc 1 \r");
            port.Write("dcap 0\r");
            port.Write("pc 0 \r");

            port.Write("rcap 11\r");
            port.Write("pc 11 \r");
            port.Write("rcap 10\r");
            port.Write("pc 10 \r");
            port.Write("rcap 9\r");
            port.Write("gc 9 \r");
            port.Write("rcap 8\r");
            port.Write("gc 8 \r");
            port.Write("rcap 7\r");
            port.Write("gc 7 \r");
            port.Write("rcap 6\r");
            port.Write("gc 6 \r");
            port.Write("rcap 5\r");
            port.Write("gc 5 \r");
            port.Write("rcap 4\r");
            port.Write("gc 4 \r");
            port.Write("rcap 3\r");
            port.Write("gc 3 \r");
            port.Write("rcap 2\r");
            port.Write("gc 2 \r");
            port.Write("rcap 1\r");
            port.Write("gc 1 \r");
            port.Write("rcap 0\r");
            port.Write("gc 0 \r");
            port.Close();
        }

        private void bulkfill_Click(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
            port.Open();
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            port.Write("LHBF 1000 500\r");
            port.Close();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string row_field = textBox8.Text + "\0";
            fire_commands("dcap", row_field);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string row_field = textBox8.Text + "\0";
            fire_commands("rcap", row_field);
        }//buttonclick

        private void fire_commands(string single_command, string row_field)
        {
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

            SerialPort port = new SerialPort("COM3", 9600, Parity.Odd, 8, StopBits.One);
            port.Open();
            port.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            for (int i = 0; i < row_field.Length; i++)
            {
                if (hyphen == false && System.Char.IsDigit(row_field, i) == true && forming_number == -1)
                {
                    forming_number_string.Append(row_field[i]);
                    forming_number = (int)char.GetNumericValue(row_field[i]);
                    label9.Text = "isdigit" + forming_number.ToString();
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
                    label9.Text = "multi_digit" + forming_number.ToString();
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
                      port.Write("gc " + parameter.ToString() + "\r");                    
                      port.Write(command.ToString());
                    }
                    else if(single_command == "dcap"){
                      port.Write(command.ToString());
                      port.Write("pc " + parameter.ToString() + "\r"); 
                    }
                    label9.Text = command.ToString();
                    parameter.Clear();
                    command.Clear();
                    command.Append(single_command).Append(" ");
                    forming_number_string.Clear();
                    forming_number = -1;
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
                            port.Write("gc " + parameter.ToString() + "\r");
                            port.Write(command.ToString());
                        }
                        else if (single_command == "dcap")
                        {
                            port.Write(command.ToString());
                            port.Write("pc " + parameter.ToString() + "\r");
                        }

                        parameter.Clear();
                        command.Clear();
                        command.Append(single_command).Append(" ");
                        forming_number_string.Clear();
                        forming_number_string.Append((j+1).ToString());
                    }




                    parameter.Clear();
                    command.Clear();
                    command.Append(single_command).Append(" ");
                    forming_number_string.Clear();
                    forming_number = -1;
                    end_number = -1;
                    end_string.Clear();

                    hyphen = false;
                }//elseif HYPHEN
                else if (row_field[i] == '-')
                {
                    hyphen = true;
                }

            }//for

            port.Close();
        }//fire_commands

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }


}
