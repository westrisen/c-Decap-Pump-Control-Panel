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
            Com_selection.Enabled = false;
            Com_selection.Visible = false;
            Com_Select.Enabled = false;
            Com_Select.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            panel3.Visible = true;
            panel4.Visible = true;
            string Com_Number = Com_Select.Text;
            connection_status = 1;

            Globals.FluidxPort = new SerialPort("COM" + Com_Number, 9600, Parity.Odd, 8, StopBits.One);
            try
            {
                Globals.FluidxPort.Open();
            }
            catch (Exception) { Application.Exit(); }

            // Globals.FluidxPort.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            portWrite("kl \r");
            portWrite("cm \r");
            portWrite("kl \r");
            portWrite("PIN\r");
            portWrite("seto 0 \r");

//foreach(Panel
            Globals.hrows = new List<Panel> { panel14, panel16, panel17, panel18, panel10, panel11, panel12, panel13, panel8, panel9, panel7, panel15, };
            Globals.vrows = new List<Panel> {panel23, panel24, panel25, panel26, panel21, panel22, panel26, panel19 };
            Globals.currently_active = new List<Panel> { };
            
            
            radioButton10.Checked = true;
            One_Cycle.Checked = true;
            tabControl1.Enabled = true;
            tabControl1.Visible = true;
            Stop_Button.Enabled = true;
            Stop_Button.Visible = true;
            button30.Enabled = true;
            button30.Visible = true;
            button31.Enabled = true;
            button31.Visible = true;
            button32.Enabled = true;
            button32.Visible = true;
            panel5.Visible = true;
            panel5.Enabled = true;
            groupBox6.Visible = true;
            groupBox6.Enabled = true;
            progress_report.Text = "Processing:";
            panel27.Enabled = true;
            panel27.Visible = true;
            panel6.Visible = false;
            panel6.Enabled = false;

            //PortChat.Serial_Connection();
        }


        private void SendTest()
        {

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
            StartButtonThread(tsFillDemo1);
        }

        public int tsFillDemo1()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("dcap " + Globals.Max_string + "\r");
                portWrite("PIN\r");
                portWrite("LHP " + Globals.Max_string + "\r");
                portWrite("PTS 2000 700 1\r");
                portWrite("rcap " + Globals.Max_string + "\r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsTrayDemo);
        }

        public int tsTrayDemo()
        {
            for(int i = 0; i < Globals.demo_cycles; i++) {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("to \r");
                if (Globals.cycleHalt == false && Globals.Halt == false)
                {
                    System.Threading.Thread.Sleep(3000);
                }
                portWrite("tc \r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }                
            }
            closeThread();
            return 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsCapDemo2);
        }

        public int tsCapDemo2()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("dcap " + Globals.Max_string + "\r");
                portWrite("pc " + Globals.Max_string + " \r");
                portWrite("gc " + Globals.Max_string + " \r");
                portWrite("rcap " + Globals.Max_string + "\r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsCapDemo4);
        }

        public int tsCapDemo4()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                fire_commands("dcap", "0-" + Globals.Max_string + "\0", "", "", "");
                fire_commands("rcap", "0-" + Globals.Max_string + "\0", "", "", "");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void bulkfill_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsBulkFill);
        }

        public int tsBulkFill()
        {
            fire_commands("LHP", "0-" + Globals.Max_string + "\0", textBox2.Text, textBox1.Text, " -1");
            closeThread();
            return 0;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsDecapRow);
        }

        public int tsDecapRow()
        {
            string row_field = textBox8.Text + "\0";
            fire_commands("dcap", row_field, "", "", "");
            Globals.FluidxBusy = false;
            closeThread();
            return 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsCapRow);
        }//buttonclick

        public int tsCapRow()
        {
            string row_field = textBox8.Text + "\0";
            fire_commands("rcap", row_field, "", "", "");
            Globals.FluidxBusy = false;
            closeThread();
            return 0;
        }//17

        public void closeThread()
        {
            label35.Text = "";
            progress_report.Text = "Processing:";
            groupBox6.Enabled = true;
            tabControl1.Enabled = true;
            panel5.Enabled = true;
            Globals.Halt = false;
            Globals.cycleHalt = false;
        }

        public bool LockFluidx()
        {
            if(Globals.FluidxBusy == false)
            {
                Globals.FluidxBusy = true;
                return true;
            }
            return false;
        }

        public Thread StartButtonThread(Func<int> functionName)
        {
            tabControl1.Enabled = false;
            groupBox6.Enabled = false;
            panel5.Enabled = false;
            var t = new Thread(() => functionName());
            t.Start();
            return t;
        }


        public int LockThread(Func<int>functionName)
        {

            return 0;
        }

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
                else if (hyphen == false && (row_field[i] == '.' || row_field[i] == ',' || row_field[i] == ' ' || row_field[i] == '\n' || row_field[i] == '\0'))
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
                else if (hyphen == true && (row_field[i] == '.' || row_field[i] == ',' || row_field[i] == ' ' || row_field[i] == '\n' || row_field[i] == '\0'))
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

        public void row_field_parser(string single_command, string row_field, string arg2, string arg3, string arg4)
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
                else if (hyphen == false && (row_field[i] == '.' || row_field[i] == ',' || row_field[i] == ' ' || row_field[i] == '\n' || row_field[i] == '\0'))
                {

                    if (forming_number > max_rows || forming_number == -1)
                    {
                        continue;
                    }

                    parameter.Append(forming_number_string);
                    command.Append(parameter).Append("\r");
                    if (single_command == "rcap")
                    {
                    }
                    else if (single_command == "dcap")
                    {
                    }
                    else if (single_command == "LHP")
                    {
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
                else if (hyphen == true && (row_field[i] == '.' || row_field[i] == ',' || row_field[i] == ' ' || row_field[i] == '\n' || row_field[i] == '\0'))
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
                        }
                        else if (single_command == "dcap")
                        {
                        }
                        else if (single_command == "LHP")
                        {
     
                        }
                        else
                        {
                            Warning.Text = "Warning: Missed a single command";
                        }

                        parameter.Clear();
                        command.Clear();
                        command.Append(single_command).Append(" ");
                        forming_number_string.Clear();
                        if (j != end_number)
                        {
                            forming_number_string.Append((j + 1).ToString());
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
        }

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
            //Thread t = new Thread(new ParameterizedThreadStart(thread_safe_port_write));

            if (Globals.Halt == true)
            {
                return;
            }
            Globals.FluidxPort.Write(new byte[] { 0x6B, 0x6C, 0x0D }, 0, 3);
            Globals.FluidxPort.ReadLine();
            Globals.FluidxPort.Write(message);
            progress_report.Text = "Processing: " + message;
            status_report.Text = "Status report: " + Globals.FluidxPort.ReadLine();

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
            StartButtonThread(tsFillRow);
        }

        public int tsFillRow()
        {
            StringBuilder rows_by_checkboxes = new StringBuilder();
            if(checkBox2.Checked == true)
                rows_by_checkboxes.Append("0,");
            else if(checkBox3.Checked == true)
                rows_by_checkboxes.Append("1,");
            else if (checkBox4.Checked == true)
                rows_by_checkboxes.Append("2,");
            else if (checkBox7.Checked == true)
                rows_by_checkboxes.Append("3,");
            else if (checkBox6.Checked == true)
                rows_by_checkboxes.Append("4,");
            else if (checkBox5.Checked == true)
                rows_by_checkboxes.Append("5,");
            else if (checkBox13.Checked == true)
                rows_by_checkboxes.Append("6,");
            else if (checkBox12.Checked == true)
                rows_by_checkboxes.Append("7,");
            else if (checkBox11.Checked == true)
                rows_by_checkboxes.Append("8,");
            else if (checkBox10.Checked == true)
                rows_by_checkboxes.Append("9,");
            else if (checkBox9.Checked == true)
                rows_by_checkboxes.Append("10,");
            else if (checkBox8.Checked == true)
                rows_by_checkboxes.Append("11,");

            string row_field = textBox3.Text + "\0";
            if (checkBox1.Checked == true)
            {
                fire_commands("LHP", row_field, textBox4.Text, textBox5.Text, " -1");
            }
            else
            {
                fire_commands("LHP", row_field, textBox4.Text, textBox5.Text, " 1");
            }
            closeThread();
            return 0;
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

        private void Warning_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            if (tabControl1.Enabled == false)
            {
                Globals.Halt = true;
                progress_report.Text = "Processing:";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsCapDemo1);
        }

        public int tsCapDemo1()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("dcap " + Globals.Max_string + "\r");
                portWrite("to \r");
                portWrite("rcap " + Globals.Max_string + "\r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }



        private void button24_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsFillDemo2);
        }

        public int tsFillDemo2()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("dcap " + Globals.Max_string + "\r");
                portWrite("pc " + Globals.Max_string + " \r");
                portWrite("PIN\r");
                portWrite("LHP " + Globals.Max_string + "\r");
                portWrite("PTS 2000 700 1\r");
                portWrite("gc " + Globals.Max_string + " \r");
                portWrite("rcap " + Globals.Max_string + "\r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsCapDemo3);
        }

        public int tsCapDemo3()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("dcap 0\r");
                portWrite("pc 0 \r");
                portWrite("gc 0 \r");
                portWrite("rcap 0\r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsFillDemo4);
        }

        public int tsFillDemo4()
        {
            for (int k = 0; k < Globals.demo_cycles; k++)
            {
                int j = k + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                for (int i = 0; i < Globals.Max_int + 1; i++)
                {

                    portWrite("dcap " + i.ToString() + "\r");
                    portWrite("LHP " + i.ToString() + "\r");
                    portWrite("PTS 2000 700 1\r");
                    portWrite("rcap " + i.ToString() + "\r");
                }
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsFillDemo3);
        }

        public int tsFillDemo3()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                portWrite("dcap 0\r");
                portWrite("PIN\r");
                portWrite("LHP 0\r");
                portWrite("PTS 2000 700 1\r");
                portWrite("rcap 0\r");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to fill the whole rack?", "Liquid Handling Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                StartButtonThread(tsFillDemo5);
            }
        }

        public int tsFillDemo5()
        {
            for (int i = 0; i < Globals.demo_cycles; i++)
            {
                int j = i + 1;
                label35.Text = "cycle " + j.ToString() + " out of " + Globals.demo_cycles;
                fire_commands("LHP", "0-" + Globals.Max_string + "\0", " 2000 ", "500 ", " -1");
                if (Globals.cycleHalt == true)
                {
                    closeThread();
                    return 0;
                }
            }
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Five_Cycles_CheckedChanged(object sender, EventArgs e)
        {
            Globals.demo_cycles = 5;
        }

        private void One_Cycle_CheckedChanged(object sender, EventArgs e)
        {
            Globals.demo_cycles = 1;
        }

        private void tencycles_CheckedChanged(object sender, EventArgs e)
        {
            Globals.demo_cycles = 10;
        }

        private void fifty_cycles_CheckedChanged(object sender, EventArgs e)
        {
            Globals.demo_cycles = 50;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label10.Text = button20.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label10.Text = button22.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label10.Text = button21.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label10.Text = button19.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsStrip);
        }

        public int tsStrip()
        {
            portWrite("to \r");
            portWrite("stp \r");
            closeThread();
            return 0;
        }

        private void Com_Select_TextChanged(object sender, EventArgs e)
        {

        }

        private void Com_Select_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Connect_to_Machine_Click_1(sender, e);
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Globals.cycleHalt = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsTrayOut);
        }

        public int tsTrayOut()
        {
            portWrite("to \r");
            closeThread();
            return 0;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsTrayIn);
        }

        public int tsTrayIn()
        {
            portWrite("tc \r");
            closeThread();
            return 0;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            StartButtonThread(tsCM);
        }

        public int tsCM()
        {
            portWrite("cm \r");
            closeThread();
            return 0;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            panel6.Visible = false;
            panel6.Enabled = false;
            panel27.Visible = true;
            panel27.Enabled = true;
            portWrite("seto 0 \r");
            portWrite("LCDP 4 \r");
            Globals.Max_int = 7;
            Globals.Max_string = "7";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            panel27.Visible = false;
            panel27.Enabled = false;
            panel6.Visible = true;
            panel6.Enabled = true;
            portWrite("seto 1 \r");
            portWrite("LCDP 5 \r");
            Globals.Max_int = 11;
            Globals.Max_string = "11";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton89_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_mouse_down(object sender, MouseEventArgs e)//horizontal
        {
            init_rect(sender, e);            
        }



        public void remove_row(string x)
        {
            textBox3.Text = textBox3.Text.Replace(x, "");
        }

        public void GUI_to_text()
        {
            bool has_row = false;
            int straight_count = 0;
            bool consecutive = false;
            int first;
            int last;
            textBox3.Text = "";
            StringBuilder row_field = new StringBuilder();
            for (int i = 0; i < Globals.Max_int + 1; i++)
            {
                if (i == Globals.Max_int && Globals.hrows[i].BackColor == Color.Gold)
                {
                    straight_count++;
                    has_row = true;
                    if (consecutive == true)
                    {
                        row_field.Append("-" + i.ToString());//WOOLOO
                    }
                    else
                    {
                        row_field.Append("," + i.ToString());//WOOLOO
                    }
                }
                else if (Globals.hrows[i].BackColor == Color.Gold)
                {
                    if (Globals.hrows[i].BackColor == Color.Gold)
                    {

                    }
                    has_row = true;

                    if (consecutive == false)
                    {
                        straight_count++;
                        consecutive = true;
                        row_field.Append("," + i.ToString());//WOOLOO
                    }
                    else//if consecutive
                    {
                        straight_count++;
                        // row_field.Append("-");

                    }
                }
                else //if darkturquiose
                {

                    if (consecutive == true && straight_count > 1)
                    {
                        int j = i - 1;//WOOLOO
                        row_field.Append("-" + j.ToString());//WOOLOO
                    }
                    consecutive = false;
                    //row_field.Append(",");
                    straight_count = 0;
                }
            }
            if (row_field.Length > 1)
            {
                row_field.Remove(0, 1);
            }
            if (has_row == true)
            {
                textBox3.Text = row_field.ToString();
            }
            else
            {
                textBox3.Text = "";
            }

        }

        public void init_rect(object sender, MouseEventArgs e)
        {
            bool CtrlPressed = ModifierKeys.HasFlag(Keys.Control);
            StringBuilder row_field = new StringBuilder();
            Panel senderobj = (Panel)sender;
            Point relative_location = senderobj.Location;
            Globals.panel_6_cursor = e.Location;
            Globals.panel_6_cursor.X = Globals.panel_6_cursor.X + relative_location.X;
            Globals.panel_6_cursor.Y = Globals.panel_6_cursor.Y + relative_location.Y;
            //textBox3
            Globals.mouse_down = 1;
            if (CtrlPressed == false)
            {
                textBox3.Text = "";
            }
            for (int i = 0; i < 12; i++)
            {
                
                Rectangle panel_rect = new Rectangle(Globals.hrows[i].Location.X, Globals.hrows[i].Location.Y, Globals.hrows[i].Width, Globals.hrows[i].Height);
                if (panel_rect.Contains(Globals.panel_6_cursor) == true)
                {
                    
                    if (Globals.hrows[i].BackColor == Color.DarkTurquoise)
                    {
                        Globals.hrows[i].BackColor = Color.Gold;
                        //GUI_to_text();
                        //if (CtrlPressed == false)
                        //{
                        //    textBox3.Text = i.ToString() + ",";//WOOLOO
                        //}
                        //else
                        //{
                        //    textBox3.Text = textBox3.Text + i.ToString() + ",";//WOOLOO
                        //}
                    }
                    else
                    {
                        //remove_row(i.ToString() + ",");//WOOLOO
                        
                        Globals.hrows[i].BackColor = Color.DarkTurquoise;
                        //GUI_to_text();
                    }
                    Globals.currentPanel = Globals.hrows[i];
                    Globals.currently_active.Add(Globals.hrows[i]);
                }
                else
                {
                    if (CtrlPressed == false)
                    {
                        Globals.hrows[i].BackColor = Color.DarkTurquoise;
                    }
                    
                }
            }
            GUI_to_text();
        }

        public void drag_rect(object sender, MouseEventArgs e)
        {
            if (Globals.mouse_down == 0)
            {
                return;
            }
            bool change_occurred = false;
            bool CtrlPressed = ModifierKeys.HasFlag(Keys.Control);
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            Panel senderobj = (Panel)sender;
            Point relative_location = senderobj.Location;

            Point a_corner_point = e.Location;
            a_corner_point.X = a_corner_point.X + relative_location.X;
            a_corner_point.Y = a_corner_point.Y + relative_location.Y;

            int temp = 0;

            //label36.Text = "Mouse Move: " + Globals.panel_6_cursor.X.ToString() + "," + Globals.panel_6_cursor.Y.ToString();

            Globals.select_roi.X = Globals.panel_6_cursor.X;
            Globals.select_roi.Y = Globals.panel_6_cursor.Y;

            if (Globals.select_roi.X > a_corner_point.X)//see if need to swap
            {
                temp = Globals.select_roi.X;
                Globals.select_roi.X = a_corner_point.X;
                a_corner_point.X = temp;
            }

            if (Globals.select_roi.Y > a_corner_point.Y)//see if need to swap
            {
                temp = Globals.select_roi.Y;
                Globals.select_roi.Y = a_corner_point.Y;
                a_corner_point.Y = temp;
            }

            Globals.select_roi.Width = a_corner_point.X - Globals.select_roi.X;
            Globals.select_roi.Height = a_corner_point.Y - Globals.select_roi.Y;

          //  label36.Text = "Mouse Move: " + Globals.select_roi.X.ToString() + " , " + Globals.select_roi.Y.ToString()
          //      + " , " + Globals.select_roi.Width.ToString() + " , " + Globals.select_roi.X.ToString();

            label36.Text = "Mouse Move: " + Globals.currentPanel.Location.X.ToString() + " , " + Globals.currentPanel.Location.Y.ToString()
                +" and list is this long: "+ Globals.currently_active.Count.ToString();

            for (int i = 0; i < 12; i++)
            {
                Rectangle panel_rect = new Rectangle(Globals.hrows[i].Location.X, Globals.hrows[i].Location.Y, Globals.hrows[i].Width, Globals.hrows[i].Height);
                if (Globals.select_roi.IntersectsWith(panel_rect))
                {
                    if (Globals.currentPanel != Globals.hrows[i] )
                    {
                        if (!Globals.currently_active.Contains(Globals.hrows[i]))
                        {
                            if (Globals.hrows[i].BackColor == Color.DarkTurquoise)
                            {
                                
                                //textBox3.Text = textBox3.Text + i.ToString() + ",";//WOOLOO
                                
                                Globals.hrows[i].BackColor = Color.Gold;
                                change_occurred = true;
                                //Globals.currentPanel = Globals.hrows[i];
                            }
                            else
                            {
                                
                                //remove_row(i.ToString() + ",");//WOOLOO
                                Globals.hrows[i].BackColor = Color.DarkTurquoise;
                                change_occurred = true;
                                //Globals.currentPanel = Globals.hrows[i];
                            }
                            //Rectangle last_active = new Rectangle(Globals.currentPanel.Location.X, Globals.currentPanel.Location.Y, Globals.currentPanel.Width, Globals.currentPanel.Height);
                            //if (!Globals.select_roi.IntersectsWith(last_active))
                            //{
                            //    Globals.currently_active.Remove(Globals.currentPanel);
                            //    Globals.currentPanel.BackColor = Color.DarkTurquoise;
                            //}
                            
                            Globals.currently_active.Add(Globals.hrows[i]);
                        }
                        else
                        {
                            Rectangle last_active = new Rectangle(Globals.currentPanel.Location.X, Globals.currentPanel.Location.Y, Globals.currentPanel.Width, Globals.currentPanel.Height);
                            if (!Globals.select_roi.IntersectsWith(last_active))
                            {
                                //label37.Text = ()
                                Globals.currently_active.Remove(Globals.currentPanel);
                                //if()
                                if (Globals.currentPanel.BackColor == Color.Gold)
                                {
                                    
                                    //remove_row(Globals.hrows.IndexOf(Globals.currentPanel).ToString() + ",");//WOOLOO
                                    Globals.currentPanel.BackColor = Color.DarkTurquoise;
                                    change_occurred = true;
                                    //Globals.currentPanel = Globals.hrows[i];
                                }
                                else
                                {
                                    Globals.currentPanel.BackColor = Color.Gold;
                                    change_occurred = true;
                                    //textBox3.Text = textBox3.Text + Globals.hrows.IndexOf(Globals.currentPanel).ToString() + ",";//WOOLOO
                                }
                                label37.Text = "If Good" ;
                            }
                            else
                            {
                              //  label37.Text = "Else Bad\n";
                            }
                        }
                        Globals.currentPanel = Globals.currently_active[Globals.currently_active.Count - 1];
                        //Globals.currentPanel = Globals.hrows[i];
                    }// if not in same pamel
                    else
                    {
                        
                    }
                }
                else//not intersect with roi
                {
                    if (Globals.currentPanel != Globals.hrows[i])
                    {
                        if (Globals.currently_active.Contains(Globals.hrows[i]))
                        {
                           // Globals.currently_active.Remove(Globals.currentPanel);
                        }
                    }

                    if (Globals.currently_active.Contains(Globals.hrows[i]) )
                    {
                        if (CtrlPressed == false)
                        {
                         //   Globals.currently_active.Remove(Globals.hrows[i]);
                         //   Globals.currentPanel.BackColor = Color.DarkTurquoise;
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                        //Globals.currently_active.Remove(Globals.currentPanel);

                    }
                    //
                    //if (CtrlPressed == false)
                    //{
                    //    Globals.hrows[i].BackColor = Color.DarkTurquoise;
                    //}
                }
            }
            if (change_occurred == true)
            {
                GUI_to_text();
            }
        }

        private void panel6_mouse_move(object sender, MouseEventArgs e)
        {
            drag_rect(sender, e);
        }

        public bool boundary_detection(Panel panel)
        {
            
            if (panel.Location.X == 0)
            {
            }
            return false;
        }

        private void panel6_mouse_up(object sender, MouseEventArgs e)
        {
            mouse_up();
        }

        public void mouse_up()
        {
            Globals.mouse_down = 0;
            Globals.currentPanel = hiddenPanel;
            Globals.currently_active.RemoveRange(0, Globals.currently_active.Count);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton70_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton201_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vpanel_onclick(object sender, EventArgs e)
        {
           // panel6_mouse_down(sender,e);
        }

        private void Vpanel_clicked(object sender, MouseEventArgs e)
        {
            init_rect(sender, e);
        }

        private void Vpanel_mouse_move(object sender, MouseEventArgs e)
        {
            
            drag_rect(sender, e);
        }

        private void Vpanel_mouse_up(object sender, MouseEventArgs e)
        {
            mouse_up();
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
        public static List<Panel> currently_active;
        public static Panel currentPanel;
        public static bool CtrlKeyPressed = false;
        public static Rectangle select_roi = new Rectangle(0,0,0,0);
        public static List<Panel> hrows;
        public static List<Panel> vrows;
        public static Point panel_6_cursor;
        public static Point panel_27_cursor;
        public static int mouse_down = 0;
        public static int mouse_up = 1;
        public static int Max_int = 7;
        public static string Max_string = "7";
        public static int hMax_int = 7;
        public static string hMax_string = "7";
        public static int vMax_int = 11;
        public static string vMax_string = "11";
        public static bool trayVert = false;
        public static bool Halt = false;
        public static bool FluidxBusy = false;
        public static SerialPort FluidxPort;
        public static readonly object FluidxLock;
        public static int demo_cycles = 1;
        public static int cap_cycles = 1;
        public static bool cycleHalt = false;
        //public static bool DeviceBusy = false;
    }

}
