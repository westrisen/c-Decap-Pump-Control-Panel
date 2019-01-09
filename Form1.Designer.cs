using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Csharp_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.Com_Select = new System.Windows.Forms.TextBox();
            this.Com_selection = new System.Windows.Forms.Label();
            this.Connection_Status_Indicator = new System.Windows.Forms.Label();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Forward_or_backward_label = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ON_OFF_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fifty_cycles = new System.Windows.Forms.RadioButton();
            this.tencycles = new System.Windows.Forms.RadioButton();
            this.Five_Cycles = new System.Windows.Forms.RadioButton();
            this.One_Cycle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Warning = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button15 = new System.Windows.Forms.Button();
            this.status_report = new System.Windows.Forms.Label();
            this.progress_report = new System.Windows.Forms.Label();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.Com_Select);
            this.tabPage1.Controls.Add(this.Com_selection);
            this.tabPage1.Controls.Add(this.Connection_Status_Indicator);
            this.tabPage1.Controls.Add(this.Disconnect_Button);
            this.tabPage1.Controls.Add(this.Forward_or_backward_label);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ON_OFF_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pump Controls";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Location = new System.Drawing.Point(283, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 94);
            this.panel2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(65, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tube Diameter:  5mm";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(211, 58);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 23);
            this.button19.TabIndex = 3;
            this.button19.Text = "20mm";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(25, 58);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "5mm";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(149, 58);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "15mm";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(87, 58);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 23);
            this.button22.TabIndex = 2;
            this.button22.Text = "10mm";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // Com_Select
            // 
            this.Com_Select.Location = new System.Drawing.Point(54, 39);
            this.Com_Select.Name = "Com_Select";
            this.Com_Select.Size = new System.Drawing.Size(56, 20);
            this.Com_Select.TabIndex = 10;
            // 
            // Com_selection
            // 
            this.Com_selection.AutoSize = true;
            this.Com_selection.Location = new System.Drawing.Point(14, 42);
            this.Com_selection.Name = "Com_selection";
            this.Com_selection.Size = new System.Drawing.Size(34, 13);
            this.Com_selection.TabIndex = 9;
            this.Com_selection.Text = "COM:";
            // 
            // Connection_Status_Indicator
            // 
            this.Connection_Status_Indicator.AutoSize = true;
            this.Connection_Status_Indicator.Location = new System.Drawing.Point(214, 50);
            this.Connection_Status_Indicator.Name = "Connection_Status_Indicator";
            this.Connection_Status_Indicator.Size = new System.Drawing.Size(79, 13);
            this.Connection_Status_Indicator.TabIndex = 8;
            this.Connection_Status_Indicator.Text = "Not Connected";
            this.Connection_Status_Indicator.Click += new System.EventHandler(this.Connection_Status_Click);
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(212, 6);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(75, 23);
            this.Disconnect_Button.TabIndex = 7;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Forward_or_backward_label
            // 
            this.Forward_or_backward_label.AutoSize = true;
            this.Forward_or_backward_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_or_backward_label.Location = new System.Drawing.Point(110, 272);
            this.Forward_or_backward_label.Name = "Forward_or_backward_label";
            this.Forward_or_backward_label.Size = new System.Drawing.Size(67, 20);
            this.Forward_or_backward_label.TabIndex = 5;
            this.Forward_or_backward_label.Text = "Forward";
            this.Forward_or_backward_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Forward_or_backward_label.Click += new System.EventHandler(this.Forward_or_backward_label_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(154, 231);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Forward";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(54, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect To Machine";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Connect_to_Machine_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(283, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 94);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed:  0%";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "80%";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Speed80_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "10%";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Speed10_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "40%";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Speed40_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(87, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "20%";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Speed20_Click_1);
            // 
            // ON_OFF_button
            // 
            this.ON_OFF_button.BackColor = System.Drawing.Color.Firebrick;
            this.ON_OFF_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ON_OFF_button.Location = new System.Drawing.Point(54, 120);
            this.ON_OFF_button.Name = "ON_OFF_button";
            this.ON_OFF_button.Size = new System.Drawing.Size(175, 81);
            this.ON_OFF_button.TabIndex = 0;
            this.ON_OFF_button.Text = "TURN ON";
            this.ON_OFF_button.UseVisualStyleBackColor = false;
            this.ON_OFF_button.Click += new System.EventHandler(this.ON_OFF_button_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(651, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fill Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Test";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(459, 163);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 7;
            this.button18.Text = "Magic";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Location = new System.Drawing.Point(6, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 238);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Row Fill";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ms";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(134, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Reverse after dispense";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 158);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 20);
            this.textBox5.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Speed";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(200, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Horizontal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(134, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Vertical";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Row #";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(176, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 111);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Fill Row";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bulk Fill";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vertical";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(206, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Horizontal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Fill All";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.bulkfill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fifty_cycles);
            this.tabPage3.Controls.Add(this.tencycles);
            this.tabPage3.Controls.Add(this.Five_Cycles);
            this.tabPage3.Controls.Add(this.One_Cycle);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(651, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "    Demo     ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fifty_cycles
            // 
            this.fifty_cycles.AutoSize = true;
            this.fifty_cycles.Location = new System.Drawing.Point(560, 14);
            this.fifty_cycles.Name = "fifty_cycles";
            this.fifty_cycles.Size = new System.Drawing.Size(71, 17);
            this.fifty_cycles.TabIndex = 4;
            this.fifty_cycles.TabStop = true;
            this.fifty_cycles.Text = "50 Cycles";
            this.fifty_cycles.UseVisualStyleBackColor = true;
            // 
            // tencycles
            // 
            this.tencycles.AutoSize = true;
            this.tencycles.Location = new System.Drawing.Point(483, 14);
            this.tencycles.Name = "tencycles";
            this.tencycles.Size = new System.Drawing.Size(71, 17);
            this.tencycles.TabIndex = 3;
            this.tencycles.TabStop = true;
            this.tencycles.Text = "10 Cycles";
            this.tencycles.UseVisualStyleBackColor = true;
            // 
            // Five_Cycles
            // 
            this.Five_Cycles.AutoSize = true;
            this.Five_Cycles.Location = new System.Drawing.Point(412, 14);
            this.Five_Cycles.Name = "Five_Cycles";
            this.Five_Cycles.Size = new System.Drawing.Size(65, 17);
            this.Five_Cycles.TabIndex = 2;
            this.Five_Cycles.TabStop = true;
            this.Five_Cycles.Text = "5 Cycles";
            this.Five_Cycles.UseVisualStyleBackColor = true;
            // 
            // One_Cycle
            // 
            this.One_Cycle.AutoSize = true;
            this.One_Cycle.Location = new System.Drawing.Point(346, 14);
            this.One_Cycle.Name = "One_Cycle";
            this.One_Cycle.Size = new System.Drawing.Size(60, 17);
            this.One_Cycle.TabIndex = 1;
            this.One_Cycle.TabStop = true;
            this.One_Cycle.Text = "1 Cycle";
            this.One_Cycle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 354);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(327, 180);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(317, 171);
            this.button13.TabIndex = 3;
            this.button13.Text = "Decap, Fill, Recap";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(3, 180);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(316, 171);
            this.button12.TabIndex = 2;
            this.button12.Text = "Decap and Recap Full Rack";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(3, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(316, 171);
            this.button11.TabIndex = 1;
            this.button11.Text = "Tray In, Tray Out";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(327, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(317, 171);
            this.button10.TabIndex = 0;
            this.button10.Text = "Decap, Set Caps on Cap Tray, Retrieve Caps, Recap";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Warning);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(651, 394);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Capping Commands";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(467, 160);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(50, 13);
            this.Warning.TabIndex = 9;
            this.Warning.Text = "Warning:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Location = new System.Drawing.Point(6, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 282);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Row Cap/Decap";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 45);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 25);
            this.button17.TabIndex = 7;
            this.button17.Text = "Cap Row";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(200, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Horizontal";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(134, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(60, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Vertical";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Row #";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(176, 69);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 74);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 25);
            this.button14.TabIndex = 0;
            this.button14.Text = "Decap Row";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.radioButton7);
            this.groupBox4.Controls.Add(this.radioButton8);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 97);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bulk Cap/Decap";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 60);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 4;
            this.button16.Text = "Decap All";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(140, 47);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(60, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Vertical";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(206, 47);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(72, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Horizontal";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 31);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 1;
            this.button15.Text = "Cap All";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // status_report
            // 
            this.status_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.status_report.AutoSize = true;
            this.status_report.Location = new System.Drawing.Point(138, 435);
            this.status_report.Name = "status_report";
            this.status_report.Size = new System.Drawing.Size(10, 13);
            this.status_report.TabIndex = 1;
            this.status_report.Text = ".";
            this.status_report.Click += new System.EventHandler(this.status_report_Click);
            // 
            // progress_report
            // 
            this.progress_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progress_report.AutoSize = true;
            this.progress_report.Location = new System.Drawing.Point(138, 466);
            this.progress_report.Name = "progress_report";
            this.progress_report.Size = new System.Drawing.Size(10, 13);
            this.progress_report.TabIndex = 2;
            this.progress_report.Text = ".";
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stop_Button.Location = new System.Drawing.Point(22, 438);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 44);
            this.Stop_Button.TabIndex = 3;
            this.Stop_Button.Text = "Stop Current Process";
            this.Stop_Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 494);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.progress_report);
            this.Controls.Add(this.status_report);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Control Panel";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ON_OFF_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Button button1;
        private Button button6;
        private Button button7;
        private GroupBox groupBox2;
        private Button button9;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label3;
        private Button button8;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label7;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Label label8;
        private Label Forward_or_backward_label;
        private TabPage tabPage3;
        private Button Disconnect_Button;
        private Label Connection_Status_Indicator;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private TabPage tabPage4;
        private GroupBox groupBox3;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button button14;
        private GroupBox groupBox4;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Button button15;
        private Label label12;
        private TextBox textBox8;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label label9;
        private Label status_report;
        private Label progress_report;
        private Label Warning;
        private Label Com_selection;
        private TextBox Com_Select;
        private Panel panel2;
        private Label label10;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private RadioButton One_Cycle;
        private RadioButton Five_Cycles;
        private RadioButton tencycles;
        private RadioButton fifty_cycles;
        private Button Stop_Button;

    }


}

