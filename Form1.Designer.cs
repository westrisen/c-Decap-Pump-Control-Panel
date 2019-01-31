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
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.Forward_or_backward_label = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ON_OFF_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.radioButton155 = new System.Windows.Forms.RadioButton();
            this.radioButton156 = new System.Windows.Forms.RadioButton();
            this.radioButton157 = new System.Windows.Forms.RadioButton();
            this.radioButton158 = new System.Windows.Forms.RadioButton();
            this.radioButton159 = new System.Windows.Forms.RadioButton();
            this.radioButton160 = new System.Windows.Forms.RadioButton();
            this.radioButton161 = new System.Windows.Forms.RadioButton();
            this.radioButton162 = new System.Windows.Forms.RadioButton();
            this.radioButton163 = new System.Windows.Forms.RadioButton();
            this.radioButton164 = new System.Windows.Forms.RadioButton();
            this.radioButton165 = new System.Windows.Forms.RadioButton();
            this.radioButton166 = new System.Windows.Forms.RadioButton();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.radioButton191 = new System.Windows.Forms.RadioButton();
            this.radioButton192 = new System.Windows.Forms.RadioButton();
            this.radioButton193 = new System.Windows.Forms.RadioButton();
            this.radioButton194 = new System.Windows.Forms.RadioButton();
            this.radioButton195 = new System.Windows.Forms.RadioButton();
            this.radioButton196 = new System.Windows.Forms.RadioButton();
            this.radioButton197 = new System.Windows.Forms.RadioButton();
            this.radioButton198 = new System.Windows.Forms.RadioButton();
            this.radioButton199 = new System.Windows.Forms.RadioButton();
            this.radioButton200 = new System.Windows.Forms.RadioButton();
            this.radioButton201 = new System.Windows.Forms.RadioButton();
            this.radioButton202 = new System.Windows.Forms.RadioButton();
            this.panel21 = new System.Windows.Forms.Panel();
            this.radioButton131 = new System.Windows.Forms.RadioButton();
            this.radioButton132 = new System.Windows.Forms.RadioButton();
            this.radioButton133 = new System.Windows.Forms.RadioButton();
            this.radioButton134 = new System.Windows.Forms.RadioButton();
            this.radioButton135 = new System.Windows.Forms.RadioButton();
            this.radioButton136 = new System.Windows.Forms.RadioButton();
            this.radioButton137 = new System.Windows.Forms.RadioButton();
            this.radioButton138 = new System.Windows.Forms.RadioButton();
            this.radioButton139 = new System.Windows.Forms.RadioButton();
            this.radioButton140 = new System.Windows.Forms.RadioButton();
            this.radioButton141 = new System.Windows.Forms.RadioButton();
            this.radioButton142 = new System.Windows.Forms.RadioButton();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.panel25 = new System.Windows.Forms.Panel();
            this.radioButton179 = new System.Windows.Forms.RadioButton();
            this.radioButton180 = new System.Windows.Forms.RadioButton();
            this.radioButton181 = new System.Windows.Forms.RadioButton();
            this.radioButton182 = new System.Windows.Forms.RadioButton();
            this.radioButton183 = new System.Windows.Forms.RadioButton();
            this.radioButton184 = new System.Windows.Forms.RadioButton();
            this.radioButton185 = new System.Windows.Forms.RadioButton();
            this.radioButton186 = new System.Windows.Forms.RadioButton();
            this.radioButton187 = new System.Windows.Forms.RadioButton();
            this.radioButton188 = new System.Windows.Forms.RadioButton();
            this.radioButton189 = new System.Windows.Forms.RadioButton();
            this.radioButton190 = new System.Windows.Forms.RadioButton();
            this.panel22 = new System.Windows.Forms.Panel();
            this.radioButton143 = new System.Windows.Forms.RadioButton();
            this.radioButton144 = new System.Windows.Forms.RadioButton();
            this.radioButton145 = new System.Windows.Forms.RadioButton();
            this.radioButton146 = new System.Windows.Forms.RadioButton();
            this.radioButton147 = new System.Windows.Forms.RadioButton();
            this.radioButton148 = new System.Windows.Forms.RadioButton();
            this.radioButton149 = new System.Windows.Forms.RadioButton();
            this.radioButton150 = new System.Windows.Forms.RadioButton();
            this.radioButton151 = new System.Windows.Forms.RadioButton();
            this.radioButton152 = new System.Windows.Forms.RadioButton();
            this.radioButton153 = new System.Windows.Forms.RadioButton();
            this.radioButton154 = new System.Windows.Forms.RadioButton();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.panel24 = new System.Windows.Forms.Panel();
            this.radioButton167 = new System.Windows.Forms.RadioButton();
            this.radioButton168 = new System.Windows.Forms.RadioButton();
            this.radioButton169 = new System.Windows.Forms.RadioButton();
            this.radioButton170 = new System.Windows.Forms.RadioButton();
            this.radioButton171 = new System.Windows.Forms.RadioButton();
            this.radioButton172 = new System.Windows.Forms.RadioButton();
            this.radioButton173 = new System.Windows.Forms.RadioButton();
            this.radioButton174 = new System.Windows.Forms.RadioButton();
            this.radioButton175 = new System.Windows.Forms.RadioButton();
            this.radioButton176 = new System.Windows.Forms.RadioButton();
            this.radioButton177 = new System.Windows.Forms.RadioButton();
            this.radioButton178 = new System.Windows.Forms.RadioButton();
            this.panel20 = new System.Windows.Forms.Panel();
            this.radioButton119 = new System.Windows.Forms.RadioButton();
            this.radioButton120 = new System.Windows.Forms.RadioButton();
            this.radioButton121 = new System.Windows.Forms.RadioButton();
            this.radioButton122 = new System.Windows.Forms.RadioButton();
            this.radioButton123 = new System.Windows.Forms.RadioButton();
            this.radioButton124 = new System.Windows.Forms.RadioButton();
            this.radioButton125 = new System.Windows.Forms.RadioButton();
            this.radioButton126 = new System.Windows.Forms.RadioButton();
            this.radioButton127 = new System.Windows.Forms.RadioButton();
            this.radioButton128 = new System.Windows.Forms.RadioButton();
            this.radioButton129 = new System.Windows.Forms.RadioButton();
            this.radioButton130 = new System.Windows.Forms.RadioButton();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.radioButton115 = new System.Windows.Forms.RadioButton();
            this.radioButton107 = new System.Windows.Forms.RadioButton();
            this.radioButton116 = new System.Windows.Forms.RadioButton();
            this.radioButton117 = new System.Windows.Forms.RadioButton();
            this.radioButton108 = new System.Windows.Forms.RadioButton();
            this.radioButton118 = new System.Windows.Forms.RadioButton();
            this.radioButton109 = new System.Windows.Forms.RadioButton();
            this.radioButton110 = new System.Windows.Forms.RadioButton();
            this.radioButton111 = new System.Windows.Forms.RadioButton();
            this.radioButton112 = new System.Windows.Forms.RadioButton();
            this.radioButton113 = new System.Windows.Forms.RadioButton();
            this.radioButton114 = new System.Windows.Forms.RadioButton();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.radioButton51 = new System.Windows.Forms.RadioButton();
            this.radioButton52 = new System.Windows.Forms.RadioButton();
            this.radioButton53 = new System.Windows.Forms.RadioButton();
            this.radioButton54 = new System.Windows.Forms.RadioButton();
            this.radioButton55 = new System.Windows.Forms.RadioButton();
            this.radioButton56 = new System.Windows.Forms.RadioButton();
            this.radioButton57 = new System.Windows.Forms.RadioButton();
            this.radioButton58 = new System.Windows.Forms.RadioButton();
            this.panel14 = new System.Windows.Forms.Panel();
            this.radioButton67 = new System.Windows.Forms.RadioButton();
            this.radioButton68 = new System.Windows.Forms.RadioButton();
            this.radioButton69 = new System.Windows.Forms.RadioButton();
            this.radioButton70 = new System.Windows.Forms.RadioButton();
            this.radioButton71 = new System.Windows.Forms.RadioButton();
            this.radioButton72 = new System.Windows.Forms.RadioButton();
            this.radioButton74 = new System.Windows.Forms.RadioButton();
            this.radioButton73 = new System.Windows.Forms.RadioButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.radioButton83 = new System.Windows.Forms.RadioButton();
            this.radioButton84 = new System.Windows.Forms.RadioButton();
            this.radioButton85 = new System.Windows.Forms.RadioButton();
            this.radioButton86 = new System.Windows.Forms.RadioButton();
            this.radioButton87 = new System.Windows.Forms.RadioButton();
            this.radioButton88 = new System.Windows.Forms.RadioButton();
            this.radioButton89 = new System.Windows.Forms.RadioButton();
            this.radioButton90 = new System.Windows.Forms.RadioButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.radioButton91 = new System.Windows.Forms.RadioButton();
            this.radioButton92 = new System.Windows.Forms.RadioButton();
            this.radioButton93 = new System.Windows.Forms.RadioButton();
            this.radioButton94 = new System.Windows.Forms.RadioButton();
            this.radioButton95 = new System.Windows.Forms.RadioButton();
            this.radioButton96 = new System.Windows.Forms.RadioButton();
            this.radioButton97 = new System.Windows.Forms.RadioButton();
            this.radioButton98 = new System.Windows.Forms.RadioButton();
            this.panel18 = new System.Windows.Forms.Panel();
            this.radioButton99 = new System.Windows.Forms.RadioButton();
            this.radioButton100 = new System.Windows.Forms.RadioButton();
            this.radioButton101 = new System.Windows.Forms.RadioButton();
            this.radioButton102 = new System.Windows.Forms.RadioButton();
            this.radioButton103 = new System.Windows.Forms.RadioButton();
            this.radioButton104 = new System.Windows.Forms.RadioButton();
            this.radioButton105 = new System.Windows.Forms.RadioButton();
            this.radioButton106 = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioButton35 = new System.Windows.Forms.RadioButton();
            this.radioButton36 = new System.Windows.Forms.RadioButton();
            this.radioButton37 = new System.Windows.Forms.RadioButton();
            this.radioButton38 = new System.Windows.Forms.RadioButton();
            this.radioButton39 = new System.Windows.Forms.RadioButton();
            this.radioButton40 = new System.Windows.Forms.RadioButton();
            this.radioButton41 = new System.Windows.Forms.RadioButton();
            this.radioButton42 = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.radioButton43 = new System.Windows.Forms.RadioButton();
            this.radioButton44 = new System.Windows.Forms.RadioButton();
            this.radioButton45 = new System.Windows.Forms.RadioButton();
            this.radioButton46 = new System.Windows.Forms.RadioButton();
            this.radioButton47 = new System.Windows.Forms.RadioButton();
            this.radioButton48 = new System.Windows.Forms.RadioButton();
            this.radioButton49 = new System.Windows.Forms.RadioButton();
            this.radioButton50 = new System.Windows.Forms.RadioButton();
            this.panel13 = new System.Windows.Forms.Panel();
            this.radioButton59 = new System.Windows.Forms.RadioButton();
            this.radioButton60 = new System.Windows.Forms.RadioButton();
            this.radioButton61 = new System.Windows.Forms.RadioButton();
            this.radioButton62 = new System.Windows.Forms.RadioButton();
            this.radioButton63 = new System.Windows.Forms.RadioButton();
            this.radioButton64 = new System.Windows.Forms.RadioButton();
            this.radioButton65 = new System.Windows.Forms.RadioButton();
            this.radioButton66 = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.radioButton33 = new System.Windows.Forms.RadioButton();
            this.radioButton34 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.radioButton75 = new System.Windows.Forms.RadioButton();
            this.radioButton76 = new System.Windows.Forms.RadioButton();
            this.radioButton77 = new System.Windows.Forms.RadioButton();
            this.radioButton78 = new System.Windows.Forms.RadioButton();
            this.radioButton79 = new System.Windows.Forms.RadioButton();
            this.radioButton80 = new System.Windows.Forms.RadioButton();
            this.radioButton81 = new System.Windows.Forms.RadioButton();
            this.radioButton82 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.fifty_cycles = new System.Windows.Forms.RadioButton();
            this.tencycles = new System.Windows.Forms.RadioButton();
            this.Five_Cycles = new System.Windows.Forms.RadioButton();
            this.button11 = new System.Windows.Forms.Button();
            this.One_Cycle = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.Warning = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.hiddenPanel = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.Com_Select = new System.Windows.Forms.TextBox();
            this.Com_selection = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.status_report = new System.Windows.Forms.Label();
            this.progress_report = new System.Windows.Forms.Label();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label35 = new System.Windows.Forms.Label();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 640);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.Forward_or_backward_label);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ON_OFF_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pump Controls";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button19);
            this.panel2.Controls.Add(this.button20);
            this.panel2.Controls.Add(this.button21);
            this.panel2.Controls.Add(this.button22);
            this.panel2.Location = new System.Drawing.Point(322, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 94);
            this.panel2.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tube Diameter:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(172, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = " 5mm";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(211, 58);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 23);
            this.button19.TabIndex = 3;
            this.button19.Text = "2.79mm";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(25, 58);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 23);
            this.button20.TabIndex = 0;
            this.button20.Text = "1.02mm";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(149, 58);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 23);
            this.button21.TabIndex = 1;
            this.button21.Text = "2.06mm";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(87, 58);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 23);
            this.button22.TabIndex = 2;
            this.button22.Text = "1.42mm";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // Forward_or_backward_label
            // 
            this.Forward_or_backward_label.AutoSize = true;
            this.Forward_or_backward_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_or_backward_label.Location = new System.Drawing.Point(149, 369);
            this.Forward_or_backward_label.Name = "Forward_or_backward_label";
            this.Forward_or_backward_label.Size = new System.Drawing.Size(67, 20);
            this.Forward_or_backward_label.TabIndex = 5;
            this.Forward_or_backward_label.Text = "Forward";
            this.Forward_or_backward_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Forward_or_backward_label.Click += new System.EventHandler(this.Forward_or_backward_label_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(193, 328);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Forward";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(93, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.panel1.Location = new System.Drawing.Point(322, 204);
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
            this.ON_OFF_button.Location = new System.Drawing.Point(93, 217);
            this.ON_OFF_button.Name = "ON_OFF_button";
            this.ON_OFF_button.Size = new System.Drawing.Size(175, 81);
            this.ON_OFF_button.TabIndex = 0;
            this.ON_OFF_button.Text = "TURN ON";
            this.ON_OFF_button.UseVisualStyleBackColor = false;
            this.ON_OFF_button.Click += new System.EventHandler(this.ON_OFF_button_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.panel27);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fill Commands";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(179, 468);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 13);
            this.label38.TabIndex = 62;
            this.label38.Text = "Hmm...";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(171, 420);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 13);
            this.label37.TabIndex = 61;
            this.label37.Text = "Hmm...";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(171, 505);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 13);
            this.label36.TabIndex = 60;
            this.label36.Text = "Rows Selected:";
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.AliceBlue;
            this.panel27.Controls.Add(this.panel23);
            this.panel27.Controls.Add(this.checkBox14);
            this.panel27.Controls.Add(this.panel26);
            this.panel27.Controls.Add(this.panel21);
            this.panel27.Controls.Add(this.checkBox15);
            this.panel27.Controls.Add(this.panel25);
            this.panel27.Controls.Add(this.panel22);
            this.panel27.Controls.Add(this.checkBox16);
            this.panel27.Controls.Add(this.panel24);
            this.panel27.Controls.Add(this.panel20);
            this.panel27.Controls.Add(this.checkBox17);
            this.panel27.Controls.Add(this.panel19);
            this.panel27.Controls.Add(this.checkBox21);
            this.panel27.Controls.Add(this.checkBox18);
            this.panel27.Controls.Add(this.checkBox20);
            this.panel27.Controls.Add(this.checkBox19);
            this.panel27.Location = new System.Drawing.Point(332, 306);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(400, 299);
            this.panel27.TabIndex = 59;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel23.Controls.Add(this.radioButton155);
            this.panel23.Controls.Add(this.radioButton156);
            this.panel23.Controls.Add(this.radioButton157);
            this.panel23.Controls.Add(this.radioButton158);
            this.panel23.Controls.Add(this.radioButton159);
            this.panel23.Controls.Add(this.radioButton160);
            this.panel23.Controls.Add(this.radioButton161);
            this.panel23.Controls.Add(this.radioButton162);
            this.panel23.Controls.Add(this.radioButton163);
            this.panel23.Controls.Add(this.radioButton164);
            this.panel23.Controls.Add(this.radioButton165);
            this.panel23.Controls.Add(this.radioButton166);
            this.panel23.Location = new System.Drawing.Point(108, 59);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(245, 21);
            this.panel23.TabIndex = 50;
            // 
            // radioButton155
            // 
            this.radioButton155.AutoSize = true;
            this.radioButton155.BackColor = System.Drawing.Color.Transparent;
            this.radioButton155.Enabled = false;
            this.radioButton155.Location = new System.Drawing.Point(226, 4);
            this.radioButton155.Name = "radioButton155";
            this.radioButton155.Size = new System.Drawing.Size(14, 13);
            this.radioButton155.TabIndex = 47;
            this.radioButton155.TabStop = true;
            this.radioButton155.UseVisualStyleBackColor = false;
            // 
            // radioButton156
            // 
            this.radioButton156.AutoSize = true;
            this.radioButton156.BackColor = System.Drawing.Color.Transparent;
            this.radioButton156.Enabled = false;
            this.radioButton156.Location = new System.Drawing.Point(146, 4);
            this.radioButton156.Name = "radioButton156";
            this.radioButton156.Size = new System.Drawing.Size(14, 13);
            this.radioButton156.TabIndex = 5;
            this.radioButton156.TabStop = true;
            this.radioButton156.UseVisualStyleBackColor = false;
            // 
            // radioButton157
            // 
            this.radioButton157.AutoSize = true;
            this.radioButton157.BackColor = System.Drawing.Color.Transparent;
            this.radioButton157.Enabled = false;
            this.radioButton157.Location = new System.Drawing.Point(166, 4);
            this.radioButton157.Name = "radioButton157";
            this.radioButton157.Size = new System.Drawing.Size(14, 13);
            this.radioButton157.TabIndex = 44;
            this.radioButton157.TabStop = true;
            this.radioButton157.UseVisualStyleBackColor = false;
            // 
            // radioButton158
            // 
            this.radioButton158.AutoSize = true;
            this.radioButton158.BackColor = System.Drawing.Color.Transparent;
            this.radioButton158.Enabled = false;
            this.radioButton158.Location = new System.Drawing.Point(206, 4);
            this.radioButton158.Name = "radioButton158";
            this.radioButton158.Size = new System.Drawing.Size(14, 13);
            this.radioButton158.TabIndex = 46;
            this.radioButton158.TabStop = true;
            this.radioButton158.UseVisualStyleBackColor = false;
            // 
            // radioButton159
            // 
            this.radioButton159.AutoSize = true;
            this.radioButton159.BackColor = System.Drawing.Color.Transparent;
            this.radioButton159.Enabled = false;
            this.radioButton159.Location = new System.Drawing.Point(26, 4);
            this.radioButton159.Name = "radioButton159";
            this.radioButton159.Size = new System.Drawing.Size(14, 13);
            this.radioButton159.TabIndex = 7;
            this.radioButton159.TabStop = true;
            this.radioButton159.UseVisualStyleBackColor = false;
            // 
            // radioButton160
            // 
            this.radioButton160.AutoSize = true;
            this.radioButton160.BackColor = System.Drawing.Color.Transparent;
            this.radioButton160.Enabled = false;
            this.radioButton160.Location = new System.Drawing.Point(186, 4);
            this.radioButton160.Name = "radioButton160";
            this.radioButton160.Size = new System.Drawing.Size(14, 13);
            this.radioButton160.TabIndex = 45;
            this.radioButton160.TabStop = true;
            this.radioButton160.UseVisualStyleBackColor = false;
            // 
            // radioButton161
            // 
            this.radioButton161.AutoSize = true;
            this.radioButton161.BackColor = System.Drawing.Color.Transparent;
            this.radioButton161.Enabled = false;
            this.radioButton161.Location = new System.Drawing.Point(46, 4);
            this.radioButton161.Name = "radioButton161";
            this.radioButton161.Size = new System.Drawing.Size(14, 13);
            this.radioButton161.TabIndex = 0;
            this.radioButton161.TabStop = true;
            this.radioButton161.UseVisualStyleBackColor = false;
            // 
            // radioButton162
            // 
            this.radioButton162.AutoSize = true;
            this.radioButton162.BackColor = System.Drawing.Color.Transparent;
            this.radioButton162.Enabled = false;
            this.radioButton162.Location = new System.Drawing.Point(6, 4);
            this.radioButton162.Name = "radioButton162";
            this.radioButton162.Size = new System.Drawing.Size(14, 13);
            this.radioButton162.TabIndex = 6;
            this.radioButton162.TabStop = true;
            this.radioButton162.UseVisualStyleBackColor = false;
            // 
            // radioButton163
            // 
            this.radioButton163.AutoSize = true;
            this.radioButton163.BackColor = System.Drawing.Color.Transparent;
            this.radioButton163.Enabled = false;
            this.radioButton163.Location = new System.Drawing.Point(66, 4);
            this.radioButton163.Name = "radioButton163";
            this.radioButton163.Size = new System.Drawing.Size(14, 13);
            this.radioButton163.TabIndex = 1;
            this.radioButton163.TabStop = true;
            this.radioButton163.UseVisualStyleBackColor = false;
            // 
            // radioButton164
            // 
            this.radioButton164.AutoSize = true;
            this.radioButton164.BackColor = System.Drawing.Color.Transparent;
            this.radioButton164.Enabled = false;
            this.radioButton164.Location = new System.Drawing.Point(86, 4);
            this.radioButton164.Name = "radioButton164";
            this.radioButton164.Size = new System.Drawing.Size(14, 13);
            this.radioButton164.TabIndex = 2;
            this.radioButton164.TabStop = true;
            this.radioButton164.UseVisualStyleBackColor = false;
            // 
            // radioButton165
            // 
            this.radioButton165.AutoSize = true;
            this.radioButton165.BackColor = System.Drawing.Color.Transparent;
            this.radioButton165.Enabled = false;
            this.radioButton165.Location = new System.Drawing.Point(126, 4);
            this.radioButton165.Name = "radioButton165";
            this.radioButton165.Size = new System.Drawing.Size(14, 13);
            this.radioButton165.TabIndex = 4;
            this.radioButton165.TabStop = true;
            this.radioButton165.UseVisualStyleBackColor = false;
            // 
            // radioButton166
            // 
            this.radioButton166.AutoSize = true;
            this.radioButton166.BackColor = System.Drawing.Color.Transparent;
            this.radioButton166.Enabled = false;
            this.radioButton166.Location = new System.Drawing.Point(106, 4);
            this.radioButton166.Name = "radioButton166";
            this.radioButton166.Size = new System.Drawing.Size(14, 13);
            this.radioButton166.TabIndex = 3;
            this.radioButton166.TabStop = true;
            this.radioButton166.UseVisualStyleBackColor = false;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(48, 202);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(57, 17);
            this.checkBox14.TabIndex = 58;
            this.checkBox14.Text = "Row 8";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel26.Controls.Add(this.radioButton191);
            this.panel26.Controls.Add(this.radioButton192);
            this.panel26.Controls.Add(this.radioButton193);
            this.panel26.Controls.Add(this.radioButton194);
            this.panel26.Controls.Add(this.radioButton195);
            this.panel26.Controls.Add(this.radioButton196);
            this.panel26.Controls.Add(this.radioButton197);
            this.panel26.Controls.Add(this.radioButton198);
            this.panel26.Controls.Add(this.radioButton199);
            this.panel26.Controls.Add(this.radioButton200);
            this.panel26.Controls.Add(this.radioButton201);
            this.panel26.Controls.Add(this.radioButton202);
            this.panel26.Location = new System.Drawing.Point(108, 119);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(245, 21);
            this.panel26.TabIndex = 47;
            // 
            // radioButton191
            // 
            this.radioButton191.AutoSize = true;
            this.radioButton191.BackColor = System.Drawing.Color.Transparent;
            this.radioButton191.Enabled = false;
            this.radioButton191.Location = new System.Drawing.Point(226, 4);
            this.radioButton191.Name = "radioButton191";
            this.radioButton191.Size = new System.Drawing.Size(14, 13);
            this.radioButton191.TabIndex = 47;
            this.radioButton191.TabStop = true;
            this.radioButton191.UseVisualStyleBackColor = false;
            // 
            // radioButton192
            // 
            this.radioButton192.AutoSize = true;
            this.radioButton192.BackColor = System.Drawing.Color.Transparent;
            this.radioButton192.Enabled = false;
            this.radioButton192.Location = new System.Drawing.Point(146, 4);
            this.radioButton192.Name = "radioButton192";
            this.radioButton192.Size = new System.Drawing.Size(14, 13);
            this.radioButton192.TabIndex = 5;
            this.radioButton192.TabStop = true;
            this.radioButton192.UseVisualStyleBackColor = false;
            // 
            // radioButton193
            // 
            this.radioButton193.AutoSize = true;
            this.radioButton193.BackColor = System.Drawing.Color.Transparent;
            this.radioButton193.Enabled = false;
            this.radioButton193.Location = new System.Drawing.Point(166, 4);
            this.radioButton193.Name = "radioButton193";
            this.radioButton193.Size = new System.Drawing.Size(14, 13);
            this.radioButton193.TabIndex = 44;
            this.radioButton193.TabStop = true;
            this.radioButton193.UseVisualStyleBackColor = false;
            // 
            // radioButton194
            // 
            this.radioButton194.AutoSize = true;
            this.radioButton194.BackColor = System.Drawing.Color.Transparent;
            this.radioButton194.Enabled = false;
            this.radioButton194.Location = new System.Drawing.Point(206, 4);
            this.radioButton194.Name = "radioButton194";
            this.radioButton194.Size = new System.Drawing.Size(14, 13);
            this.radioButton194.TabIndex = 46;
            this.radioButton194.TabStop = true;
            this.radioButton194.UseVisualStyleBackColor = false;
            // 
            // radioButton195
            // 
            this.radioButton195.AutoSize = true;
            this.radioButton195.BackColor = System.Drawing.Color.Transparent;
            this.radioButton195.Enabled = false;
            this.radioButton195.Location = new System.Drawing.Point(26, 4);
            this.radioButton195.Name = "radioButton195";
            this.radioButton195.Size = new System.Drawing.Size(14, 13);
            this.radioButton195.TabIndex = 7;
            this.radioButton195.TabStop = true;
            this.radioButton195.UseVisualStyleBackColor = false;
            // 
            // radioButton196
            // 
            this.radioButton196.AutoSize = true;
            this.radioButton196.BackColor = System.Drawing.Color.Transparent;
            this.radioButton196.Enabled = false;
            this.radioButton196.Location = new System.Drawing.Point(186, 4);
            this.radioButton196.Name = "radioButton196";
            this.radioButton196.Size = new System.Drawing.Size(14, 13);
            this.radioButton196.TabIndex = 45;
            this.radioButton196.TabStop = true;
            this.radioButton196.UseVisualStyleBackColor = false;
            // 
            // radioButton197
            // 
            this.radioButton197.AutoSize = true;
            this.radioButton197.BackColor = System.Drawing.Color.Transparent;
            this.radioButton197.Enabled = false;
            this.radioButton197.Location = new System.Drawing.Point(46, 4);
            this.radioButton197.Name = "radioButton197";
            this.radioButton197.Size = new System.Drawing.Size(14, 13);
            this.radioButton197.TabIndex = 0;
            this.radioButton197.TabStop = true;
            this.radioButton197.UseVisualStyleBackColor = false;
            // 
            // radioButton198
            // 
            this.radioButton198.AutoSize = true;
            this.radioButton198.BackColor = System.Drawing.Color.Transparent;
            this.radioButton198.Enabled = false;
            this.radioButton198.Location = new System.Drawing.Point(6, 4);
            this.radioButton198.Name = "radioButton198";
            this.radioButton198.Size = new System.Drawing.Size(14, 13);
            this.radioButton198.TabIndex = 6;
            this.radioButton198.TabStop = true;
            this.radioButton198.UseVisualStyleBackColor = false;
            // 
            // radioButton199
            // 
            this.radioButton199.AutoSize = true;
            this.radioButton199.BackColor = System.Drawing.Color.Transparent;
            this.radioButton199.Enabled = false;
            this.radioButton199.Location = new System.Drawing.Point(66, 4);
            this.radioButton199.Name = "radioButton199";
            this.radioButton199.Size = new System.Drawing.Size(14, 13);
            this.radioButton199.TabIndex = 1;
            this.radioButton199.TabStop = true;
            this.radioButton199.UseVisualStyleBackColor = false;
            // 
            // radioButton200
            // 
            this.radioButton200.AutoSize = true;
            this.radioButton200.BackColor = System.Drawing.Color.Transparent;
            this.radioButton200.Enabled = false;
            this.radioButton200.Location = new System.Drawing.Point(86, 4);
            this.radioButton200.Name = "radioButton200";
            this.radioButton200.Size = new System.Drawing.Size(14, 13);
            this.radioButton200.TabIndex = 2;
            this.radioButton200.TabStop = true;
            this.radioButton200.UseVisualStyleBackColor = false;
            // 
            // radioButton201
            // 
            this.radioButton201.AutoSize = true;
            this.radioButton201.BackColor = System.Drawing.Color.Transparent;
            this.radioButton201.Enabled = false;
            this.radioButton201.Location = new System.Drawing.Point(126, 4);
            this.radioButton201.Name = "radioButton201";
            this.radioButton201.Size = new System.Drawing.Size(14, 13);
            this.radioButton201.TabIndex = 4;
            this.radioButton201.TabStop = true;
            this.radioButton201.UseVisualStyleBackColor = false;
            this.radioButton201.CheckedChanged += new System.EventHandler(this.radioButton201_CheckedChanged);
            // 
            // radioButton202
            // 
            this.radioButton202.AutoSize = true;
            this.radioButton202.BackColor = System.Drawing.Color.Transparent;
            this.radioButton202.Enabled = false;
            this.radioButton202.Location = new System.Drawing.Point(106, 4);
            this.radioButton202.Name = "radioButton202";
            this.radioButton202.Size = new System.Drawing.Size(14, 13);
            this.radioButton202.TabIndex = 3;
            this.radioButton202.TabStop = true;
            this.radioButton202.UseVisualStyleBackColor = false;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel21.Controls.Add(this.radioButton131);
            this.panel21.Controls.Add(this.radioButton132);
            this.panel21.Controls.Add(this.radioButton133);
            this.panel21.Controls.Add(this.radioButton134);
            this.panel21.Controls.Add(this.radioButton135);
            this.panel21.Controls.Add(this.radioButton136);
            this.panel21.Controls.Add(this.radioButton137);
            this.panel21.Controls.Add(this.radioButton138);
            this.panel21.Controls.Add(this.radioButton139);
            this.panel21.Controls.Add(this.radioButton140);
            this.panel21.Controls.Add(this.radioButton141);
            this.panel21.Controls.Add(this.radioButton142);
            this.panel21.Location = new System.Drawing.Point(108, 139);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(245, 21);
            this.panel21.TabIndex = 46;
            // 
            // radioButton131
            // 
            this.radioButton131.AutoSize = true;
            this.radioButton131.BackColor = System.Drawing.Color.Transparent;
            this.radioButton131.Enabled = false;
            this.radioButton131.Location = new System.Drawing.Point(226, 4);
            this.radioButton131.Name = "radioButton131";
            this.radioButton131.Size = new System.Drawing.Size(14, 13);
            this.radioButton131.TabIndex = 47;
            this.radioButton131.TabStop = true;
            this.radioButton131.UseVisualStyleBackColor = false;
            // 
            // radioButton132
            // 
            this.radioButton132.AutoSize = true;
            this.radioButton132.BackColor = System.Drawing.Color.Transparent;
            this.radioButton132.Enabled = false;
            this.radioButton132.Location = new System.Drawing.Point(146, 4);
            this.radioButton132.Name = "radioButton132";
            this.radioButton132.Size = new System.Drawing.Size(14, 13);
            this.radioButton132.TabIndex = 5;
            this.radioButton132.TabStop = true;
            this.radioButton132.UseVisualStyleBackColor = false;
            // 
            // radioButton133
            // 
            this.radioButton133.AutoSize = true;
            this.radioButton133.BackColor = System.Drawing.Color.Transparent;
            this.radioButton133.Enabled = false;
            this.radioButton133.Location = new System.Drawing.Point(166, 4);
            this.radioButton133.Name = "radioButton133";
            this.radioButton133.Size = new System.Drawing.Size(14, 13);
            this.radioButton133.TabIndex = 44;
            this.radioButton133.TabStop = true;
            this.radioButton133.UseVisualStyleBackColor = false;
            // 
            // radioButton134
            // 
            this.radioButton134.AutoSize = true;
            this.radioButton134.BackColor = System.Drawing.Color.Transparent;
            this.radioButton134.Enabled = false;
            this.radioButton134.Location = new System.Drawing.Point(206, 4);
            this.radioButton134.Name = "radioButton134";
            this.radioButton134.Size = new System.Drawing.Size(14, 13);
            this.radioButton134.TabIndex = 46;
            this.radioButton134.TabStop = true;
            this.radioButton134.UseVisualStyleBackColor = false;
            // 
            // radioButton135
            // 
            this.radioButton135.AutoSize = true;
            this.radioButton135.BackColor = System.Drawing.Color.Transparent;
            this.radioButton135.Enabled = false;
            this.radioButton135.Location = new System.Drawing.Point(26, 4);
            this.radioButton135.Name = "radioButton135";
            this.radioButton135.Size = new System.Drawing.Size(14, 13);
            this.radioButton135.TabIndex = 7;
            this.radioButton135.TabStop = true;
            this.radioButton135.UseVisualStyleBackColor = false;
            // 
            // radioButton136
            // 
            this.radioButton136.AutoSize = true;
            this.radioButton136.BackColor = System.Drawing.Color.Transparent;
            this.radioButton136.Enabled = false;
            this.radioButton136.Location = new System.Drawing.Point(186, 4);
            this.radioButton136.Name = "radioButton136";
            this.radioButton136.Size = new System.Drawing.Size(14, 13);
            this.radioButton136.TabIndex = 45;
            this.radioButton136.TabStop = true;
            this.radioButton136.UseVisualStyleBackColor = false;
            // 
            // radioButton137
            // 
            this.radioButton137.AutoSize = true;
            this.radioButton137.BackColor = System.Drawing.Color.Transparent;
            this.radioButton137.Enabled = false;
            this.radioButton137.Location = new System.Drawing.Point(46, 4);
            this.radioButton137.Name = "radioButton137";
            this.radioButton137.Size = new System.Drawing.Size(14, 13);
            this.radioButton137.TabIndex = 0;
            this.radioButton137.TabStop = true;
            this.radioButton137.UseVisualStyleBackColor = false;
            // 
            // radioButton138
            // 
            this.radioButton138.AutoSize = true;
            this.radioButton138.BackColor = System.Drawing.Color.Transparent;
            this.radioButton138.Enabled = false;
            this.radioButton138.Location = new System.Drawing.Point(6, 4);
            this.radioButton138.Name = "radioButton138";
            this.radioButton138.Size = new System.Drawing.Size(14, 13);
            this.radioButton138.TabIndex = 6;
            this.radioButton138.TabStop = true;
            this.radioButton138.UseVisualStyleBackColor = false;
            // 
            // radioButton139
            // 
            this.radioButton139.AutoSize = true;
            this.radioButton139.BackColor = System.Drawing.Color.Transparent;
            this.radioButton139.Enabled = false;
            this.radioButton139.Location = new System.Drawing.Point(66, 4);
            this.radioButton139.Name = "radioButton139";
            this.radioButton139.Size = new System.Drawing.Size(14, 13);
            this.radioButton139.TabIndex = 1;
            this.radioButton139.TabStop = true;
            this.radioButton139.UseVisualStyleBackColor = false;
            // 
            // radioButton140
            // 
            this.radioButton140.AutoSize = true;
            this.radioButton140.BackColor = System.Drawing.Color.Transparent;
            this.radioButton140.Enabled = false;
            this.radioButton140.Location = new System.Drawing.Point(86, 4);
            this.radioButton140.Name = "radioButton140";
            this.radioButton140.Size = new System.Drawing.Size(14, 13);
            this.radioButton140.TabIndex = 2;
            this.radioButton140.TabStop = true;
            this.radioButton140.UseVisualStyleBackColor = false;
            // 
            // radioButton141
            // 
            this.radioButton141.AutoSize = true;
            this.radioButton141.BackColor = System.Drawing.Color.Transparent;
            this.radioButton141.Enabled = false;
            this.radioButton141.Location = new System.Drawing.Point(126, 4);
            this.radioButton141.Name = "radioButton141";
            this.radioButton141.Size = new System.Drawing.Size(14, 13);
            this.radioButton141.TabIndex = 4;
            this.radioButton141.TabStop = true;
            this.radioButton141.UseVisualStyleBackColor = false;
            // 
            // radioButton142
            // 
            this.radioButton142.AutoSize = true;
            this.radioButton142.BackColor = System.Drawing.Color.Transparent;
            this.radioButton142.Enabled = false;
            this.radioButton142.Location = new System.Drawing.Point(106, 4);
            this.radioButton142.Name = "radioButton142";
            this.radioButton142.Size = new System.Drawing.Size(14, 13);
            this.radioButton142.TabIndex = 3;
            this.radioButton142.TabStop = true;
            this.radioButton142.UseVisualStyleBackColor = false;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(48, 182);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(57, 17);
            this.checkBox15.TabIndex = 57;
            this.checkBox15.Text = "Row 7";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel25.Controls.Add(this.radioButton179);
            this.panel25.Controls.Add(this.radioButton180);
            this.panel25.Controls.Add(this.radioButton181);
            this.panel25.Controls.Add(this.radioButton182);
            this.panel25.Controls.Add(this.radioButton183);
            this.panel25.Controls.Add(this.radioButton184);
            this.panel25.Controls.Add(this.radioButton185);
            this.panel25.Controls.Add(this.radioButton186);
            this.panel25.Controls.Add(this.radioButton187);
            this.panel25.Controls.Add(this.radioButton188);
            this.panel25.Controls.Add(this.radioButton189);
            this.panel25.Controls.Add(this.radioButton190);
            this.panel25.Location = new System.Drawing.Point(108, 99);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(245, 21);
            this.panel25.TabIndex = 48;
            // 
            // radioButton179
            // 
            this.radioButton179.AutoSize = true;
            this.radioButton179.BackColor = System.Drawing.Color.Transparent;
            this.radioButton179.Enabled = false;
            this.radioButton179.Location = new System.Drawing.Point(226, 4);
            this.radioButton179.Name = "radioButton179";
            this.radioButton179.Size = new System.Drawing.Size(14, 13);
            this.radioButton179.TabIndex = 47;
            this.radioButton179.TabStop = true;
            this.radioButton179.UseVisualStyleBackColor = false;
            // 
            // radioButton180
            // 
            this.radioButton180.AutoSize = true;
            this.radioButton180.BackColor = System.Drawing.Color.Transparent;
            this.radioButton180.Enabled = false;
            this.radioButton180.Location = new System.Drawing.Point(146, 4);
            this.radioButton180.Name = "radioButton180";
            this.radioButton180.Size = new System.Drawing.Size(14, 13);
            this.radioButton180.TabIndex = 5;
            this.radioButton180.TabStop = true;
            this.radioButton180.UseVisualStyleBackColor = false;
            // 
            // radioButton181
            // 
            this.radioButton181.AutoSize = true;
            this.radioButton181.BackColor = System.Drawing.Color.Transparent;
            this.radioButton181.Enabled = false;
            this.radioButton181.Location = new System.Drawing.Point(166, 4);
            this.radioButton181.Name = "radioButton181";
            this.radioButton181.Size = new System.Drawing.Size(14, 13);
            this.radioButton181.TabIndex = 44;
            this.radioButton181.TabStop = true;
            this.radioButton181.UseVisualStyleBackColor = false;
            // 
            // radioButton182
            // 
            this.radioButton182.AutoSize = true;
            this.radioButton182.BackColor = System.Drawing.Color.Transparent;
            this.radioButton182.Enabled = false;
            this.radioButton182.Location = new System.Drawing.Point(206, 4);
            this.radioButton182.Name = "radioButton182";
            this.radioButton182.Size = new System.Drawing.Size(14, 13);
            this.radioButton182.TabIndex = 46;
            this.radioButton182.TabStop = true;
            this.radioButton182.UseVisualStyleBackColor = false;
            // 
            // radioButton183
            // 
            this.radioButton183.AutoSize = true;
            this.radioButton183.BackColor = System.Drawing.Color.Transparent;
            this.radioButton183.Enabled = false;
            this.radioButton183.Location = new System.Drawing.Point(26, 4);
            this.radioButton183.Name = "radioButton183";
            this.radioButton183.Size = new System.Drawing.Size(14, 13);
            this.radioButton183.TabIndex = 7;
            this.radioButton183.TabStop = true;
            this.radioButton183.UseVisualStyleBackColor = false;
            // 
            // radioButton184
            // 
            this.radioButton184.AutoSize = true;
            this.radioButton184.BackColor = System.Drawing.Color.Transparent;
            this.radioButton184.Enabled = false;
            this.radioButton184.Location = new System.Drawing.Point(186, 4);
            this.radioButton184.Name = "radioButton184";
            this.radioButton184.Size = new System.Drawing.Size(14, 13);
            this.radioButton184.TabIndex = 45;
            this.radioButton184.TabStop = true;
            this.radioButton184.UseVisualStyleBackColor = false;
            // 
            // radioButton185
            // 
            this.radioButton185.AutoSize = true;
            this.radioButton185.BackColor = System.Drawing.Color.Transparent;
            this.radioButton185.Enabled = false;
            this.radioButton185.Location = new System.Drawing.Point(46, 4);
            this.radioButton185.Name = "radioButton185";
            this.radioButton185.Size = new System.Drawing.Size(14, 13);
            this.radioButton185.TabIndex = 0;
            this.radioButton185.TabStop = true;
            this.radioButton185.UseVisualStyleBackColor = false;
            // 
            // radioButton186
            // 
            this.radioButton186.AutoSize = true;
            this.radioButton186.BackColor = System.Drawing.Color.Transparent;
            this.radioButton186.Enabled = false;
            this.radioButton186.Location = new System.Drawing.Point(6, 4);
            this.radioButton186.Name = "radioButton186";
            this.radioButton186.Size = new System.Drawing.Size(14, 13);
            this.radioButton186.TabIndex = 6;
            this.radioButton186.TabStop = true;
            this.radioButton186.UseVisualStyleBackColor = false;
            // 
            // radioButton187
            // 
            this.radioButton187.AutoSize = true;
            this.radioButton187.BackColor = System.Drawing.Color.Transparent;
            this.radioButton187.Enabled = false;
            this.radioButton187.Location = new System.Drawing.Point(66, 4);
            this.radioButton187.Name = "radioButton187";
            this.radioButton187.Size = new System.Drawing.Size(14, 13);
            this.radioButton187.TabIndex = 1;
            this.radioButton187.TabStop = true;
            this.radioButton187.UseVisualStyleBackColor = false;
            // 
            // radioButton188
            // 
            this.radioButton188.AutoSize = true;
            this.radioButton188.BackColor = System.Drawing.Color.Transparent;
            this.radioButton188.Enabled = false;
            this.radioButton188.Location = new System.Drawing.Point(86, 4);
            this.radioButton188.Name = "radioButton188";
            this.radioButton188.Size = new System.Drawing.Size(14, 13);
            this.radioButton188.TabIndex = 2;
            this.radioButton188.TabStop = true;
            this.radioButton188.UseVisualStyleBackColor = false;
            // 
            // radioButton189
            // 
            this.radioButton189.AutoSize = true;
            this.radioButton189.BackColor = System.Drawing.Color.Transparent;
            this.radioButton189.Enabled = false;
            this.radioButton189.Location = new System.Drawing.Point(126, 4);
            this.radioButton189.Name = "radioButton189";
            this.radioButton189.Size = new System.Drawing.Size(14, 13);
            this.radioButton189.TabIndex = 4;
            this.radioButton189.TabStop = true;
            this.radioButton189.UseVisualStyleBackColor = false;
            // 
            // radioButton190
            // 
            this.radioButton190.AutoSize = true;
            this.radioButton190.BackColor = System.Drawing.Color.Transparent;
            this.radioButton190.Enabled = false;
            this.radioButton190.Location = new System.Drawing.Point(106, 4);
            this.radioButton190.Name = "radioButton190";
            this.radioButton190.Size = new System.Drawing.Size(14, 13);
            this.radioButton190.TabIndex = 3;
            this.radioButton190.TabStop = true;
            this.radioButton190.UseVisualStyleBackColor = false;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel22.Controls.Add(this.radioButton143);
            this.panel22.Controls.Add(this.radioButton144);
            this.panel22.Controls.Add(this.radioButton145);
            this.panel22.Controls.Add(this.radioButton146);
            this.panel22.Controls.Add(this.radioButton147);
            this.panel22.Controls.Add(this.radioButton148);
            this.panel22.Controls.Add(this.radioButton149);
            this.panel22.Controls.Add(this.radioButton150);
            this.panel22.Controls.Add(this.radioButton151);
            this.panel22.Controls.Add(this.radioButton152);
            this.panel22.Controls.Add(this.radioButton153);
            this.panel22.Controls.Add(this.radioButton154);
            this.panel22.Location = new System.Drawing.Point(108, 159);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(245, 21);
            this.panel22.TabIndex = 45;
            // 
            // radioButton143
            // 
            this.radioButton143.AutoSize = true;
            this.radioButton143.BackColor = System.Drawing.Color.Transparent;
            this.radioButton143.Enabled = false;
            this.radioButton143.Location = new System.Drawing.Point(226, 4);
            this.radioButton143.Name = "radioButton143";
            this.radioButton143.Size = new System.Drawing.Size(14, 13);
            this.radioButton143.TabIndex = 47;
            this.radioButton143.TabStop = true;
            this.radioButton143.UseVisualStyleBackColor = false;
            // 
            // radioButton144
            // 
            this.radioButton144.AutoSize = true;
            this.radioButton144.BackColor = System.Drawing.Color.Transparent;
            this.radioButton144.Enabled = false;
            this.radioButton144.Location = new System.Drawing.Point(146, 4);
            this.radioButton144.Name = "radioButton144";
            this.radioButton144.Size = new System.Drawing.Size(14, 13);
            this.radioButton144.TabIndex = 5;
            this.radioButton144.TabStop = true;
            this.radioButton144.UseVisualStyleBackColor = false;
            // 
            // radioButton145
            // 
            this.radioButton145.AutoSize = true;
            this.radioButton145.BackColor = System.Drawing.Color.Transparent;
            this.radioButton145.Enabled = false;
            this.radioButton145.Location = new System.Drawing.Point(166, 4);
            this.radioButton145.Name = "radioButton145";
            this.radioButton145.Size = new System.Drawing.Size(14, 13);
            this.radioButton145.TabIndex = 44;
            this.radioButton145.TabStop = true;
            this.radioButton145.UseVisualStyleBackColor = false;
            // 
            // radioButton146
            // 
            this.radioButton146.AutoSize = true;
            this.radioButton146.BackColor = System.Drawing.Color.Transparent;
            this.radioButton146.Enabled = false;
            this.radioButton146.Location = new System.Drawing.Point(206, 4);
            this.radioButton146.Name = "radioButton146";
            this.radioButton146.Size = new System.Drawing.Size(14, 13);
            this.radioButton146.TabIndex = 46;
            this.radioButton146.TabStop = true;
            this.radioButton146.UseVisualStyleBackColor = false;
            // 
            // radioButton147
            // 
            this.radioButton147.AutoSize = true;
            this.radioButton147.BackColor = System.Drawing.Color.Transparent;
            this.radioButton147.Enabled = false;
            this.radioButton147.Location = new System.Drawing.Point(26, 4);
            this.radioButton147.Name = "radioButton147";
            this.radioButton147.Size = new System.Drawing.Size(14, 13);
            this.radioButton147.TabIndex = 7;
            this.radioButton147.TabStop = true;
            this.radioButton147.UseVisualStyleBackColor = false;
            // 
            // radioButton148
            // 
            this.radioButton148.AutoSize = true;
            this.radioButton148.BackColor = System.Drawing.Color.Transparent;
            this.radioButton148.Enabled = false;
            this.radioButton148.Location = new System.Drawing.Point(186, 4);
            this.radioButton148.Name = "radioButton148";
            this.radioButton148.Size = new System.Drawing.Size(14, 13);
            this.radioButton148.TabIndex = 45;
            this.radioButton148.TabStop = true;
            this.radioButton148.UseVisualStyleBackColor = false;
            // 
            // radioButton149
            // 
            this.radioButton149.AutoSize = true;
            this.radioButton149.BackColor = System.Drawing.Color.Transparent;
            this.radioButton149.Enabled = false;
            this.radioButton149.Location = new System.Drawing.Point(46, 4);
            this.radioButton149.Name = "radioButton149";
            this.radioButton149.Size = new System.Drawing.Size(14, 13);
            this.radioButton149.TabIndex = 0;
            this.radioButton149.TabStop = true;
            this.radioButton149.UseVisualStyleBackColor = false;
            // 
            // radioButton150
            // 
            this.radioButton150.AutoSize = true;
            this.radioButton150.BackColor = System.Drawing.Color.Transparent;
            this.radioButton150.Enabled = false;
            this.radioButton150.Location = new System.Drawing.Point(6, 4);
            this.radioButton150.Name = "radioButton150";
            this.radioButton150.Size = new System.Drawing.Size(14, 13);
            this.radioButton150.TabIndex = 6;
            this.radioButton150.TabStop = true;
            this.radioButton150.UseVisualStyleBackColor = false;
            // 
            // radioButton151
            // 
            this.radioButton151.AutoSize = true;
            this.radioButton151.BackColor = System.Drawing.Color.Transparent;
            this.radioButton151.Enabled = false;
            this.radioButton151.Location = new System.Drawing.Point(66, 4);
            this.radioButton151.Name = "radioButton151";
            this.radioButton151.Size = new System.Drawing.Size(14, 13);
            this.radioButton151.TabIndex = 1;
            this.radioButton151.TabStop = true;
            this.radioButton151.UseVisualStyleBackColor = false;
            // 
            // radioButton152
            // 
            this.radioButton152.AutoSize = true;
            this.radioButton152.BackColor = System.Drawing.Color.Transparent;
            this.radioButton152.Enabled = false;
            this.radioButton152.Location = new System.Drawing.Point(86, 4);
            this.radioButton152.Name = "radioButton152";
            this.radioButton152.Size = new System.Drawing.Size(14, 13);
            this.radioButton152.TabIndex = 2;
            this.radioButton152.TabStop = true;
            this.radioButton152.UseVisualStyleBackColor = false;
            // 
            // radioButton153
            // 
            this.radioButton153.AutoSize = true;
            this.radioButton153.BackColor = System.Drawing.Color.Transparent;
            this.radioButton153.Enabled = false;
            this.radioButton153.Location = new System.Drawing.Point(126, 4);
            this.radioButton153.Name = "radioButton153";
            this.radioButton153.Size = new System.Drawing.Size(14, 13);
            this.radioButton153.TabIndex = 4;
            this.radioButton153.TabStop = true;
            this.radioButton153.UseVisualStyleBackColor = false;
            // 
            // radioButton154
            // 
            this.radioButton154.AutoSize = true;
            this.radioButton154.BackColor = System.Drawing.Color.Transparent;
            this.radioButton154.Enabled = false;
            this.radioButton154.Location = new System.Drawing.Point(106, 4);
            this.radioButton154.Name = "radioButton154";
            this.radioButton154.Size = new System.Drawing.Size(14, 13);
            this.radioButton154.TabIndex = 3;
            this.radioButton154.TabStop = true;
            this.radioButton154.UseVisualStyleBackColor = false;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(48, 162);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(57, 17);
            this.checkBox16.TabIndex = 56;
            this.checkBox16.Text = "Row 6";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel24.Controls.Add(this.radioButton167);
            this.panel24.Controls.Add(this.radioButton168);
            this.panel24.Controls.Add(this.radioButton169);
            this.panel24.Controls.Add(this.radioButton170);
            this.panel24.Controls.Add(this.radioButton171);
            this.panel24.Controls.Add(this.radioButton172);
            this.panel24.Controls.Add(this.radioButton173);
            this.panel24.Controls.Add(this.radioButton174);
            this.panel24.Controls.Add(this.radioButton175);
            this.panel24.Controls.Add(this.radioButton176);
            this.panel24.Controls.Add(this.radioButton177);
            this.panel24.Controls.Add(this.radioButton178);
            this.panel24.Location = new System.Drawing.Point(108, 79);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(245, 21);
            this.panel24.TabIndex = 49;
            // 
            // radioButton167
            // 
            this.radioButton167.AutoSize = true;
            this.radioButton167.BackColor = System.Drawing.Color.Transparent;
            this.radioButton167.Enabled = false;
            this.radioButton167.Location = new System.Drawing.Point(226, 4);
            this.radioButton167.Name = "radioButton167";
            this.radioButton167.Size = new System.Drawing.Size(14, 13);
            this.radioButton167.TabIndex = 47;
            this.radioButton167.TabStop = true;
            this.radioButton167.UseVisualStyleBackColor = false;
            // 
            // radioButton168
            // 
            this.radioButton168.AutoSize = true;
            this.radioButton168.BackColor = System.Drawing.Color.Transparent;
            this.radioButton168.Enabled = false;
            this.radioButton168.Location = new System.Drawing.Point(146, 4);
            this.radioButton168.Name = "radioButton168";
            this.radioButton168.Size = new System.Drawing.Size(14, 13);
            this.radioButton168.TabIndex = 5;
            this.radioButton168.TabStop = true;
            this.radioButton168.UseVisualStyleBackColor = false;
            // 
            // radioButton169
            // 
            this.radioButton169.AutoSize = true;
            this.radioButton169.BackColor = System.Drawing.Color.Transparent;
            this.radioButton169.Enabled = false;
            this.radioButton169.Location = new System.Drawing.Point(166, 4);
            this.radioButton169.Name = "radioButton169";
            this.radioButton169.Size = new System.Drawing.Size(14, 13);
            this.radioButton169.TabIndex = 44;
            this.radioButton169.TabStop = true;
            this.radioButton169.UseVisualStyleBackColor = false;
            // 
            // radioButton170
            // 
            this.radioButton170.AutoSize = true;
            this.radioButton170.BackColor = System.Drawing.Color.Transparent;
            this.radioButton170.Enabled = false;
            this.radioButton170.Location = new System.Drawing.Point(206, 4);
            this.radioButton170.Name = "radioButton170";
            this.radioButton170.Size = new System.Drawing.Size(14, 13);
            this.radioButton170.TabIndex = 46;
            this.radioButton170.TabStop = true;
            this.radioButton170.UseVisualStyleBackColor = false;
            // 
            // radioButton171
            // 
            this.radioButton171.AutoSize = true;
            this.radioButton171.BackColor = System.Drawing.Color.Transparent;
            this.radioButton171.Enabled = false;
            this.radioButton171.Location = new System.Drawing.Point(26, 4);
            this.radioButton171.Name = "radioButton171";
            this.radioButton171.Size = new System.Drawing.Size(14, 13);
            this.radioButton171.TabIndex = 7;
            this.radioButton171.TabStop = true;
            this.radioButton171.UseVisualStyleBackColor = false;
            // 
            // radioButton172
            // 
            this.radioButton172.AutoSize = true;
            this.radioButton172.BackColor = System.Drawing.Color.Transparent;
            this.radioButton172.Enabled = false;
            this.radioButton172.Location = new System.Drawing.Point(186, 4);
            this.radioButton172.Name = "radioButton172";
            this.radioButton172.Size = new System.Drawing.Size(14, 13);
            this.radioButton172.TabIndex = 45;
            this.radioButton172.TabStop = true;
            this.radioButton172.UseVisualStyleBackColor = false;
            // 
            // radioButton173
            // 
            this.radioButton173.AutoSize = true;
            this.radioButton173.BackColor = System.Drawing.Color.Transparent;
            this.radioButton173.Enabled = false;
            this.radioButton173.Location = new System.Drawing.Point(46, 4);
            this.radioButton173.Name = "radioButton173";
            this.radioButton173.Size = new System.Drawing.Size(14, 13);
            this.radioButton173.TabIndex = 0;
            this.radioButton173.TabStop = true;
            this.radioButton173.UseVisualStyleBackColor = false;
            // 
            // radioButton174
            // 
            this.radioButton174.AutoSize = true;
            this.radioButton174.BackColor = System.Drawing.Color.Transparent;
            this.radioButton174.Enabled = false;
            this.radioButton174.Location = new System.Drawing.Point(6, 4);
            this.radioButton174.Name = "radioButton174";
            this.radioButton174.Size = new System.Drawing.Size(14, 13);
            this.radioButton174.TabIndex = 6;
            this.radioButton174.TabStop = true;
            this.radioButton174.UseVisualStyleBackColor = false;
            // 
            // radioButton175
            // 
            this.radioButton175.AutoSize = true;
            this.radioButton175.BackColor = System.Drawing.Color.Transparent;
            this.radioButton175.Enabled = false;
            this.radioButton175.Location = new System.Drawing.Point(66, 4);
            this.radioButton175.Name = "radioButton175";
            this.radioButton175.Size = new System.Drawing.Size(14, 13);
            this.radioButton175.TabIndex = 1;
            this.radioButton175.TabStop = true;
            this.radioButton175.UseVisualStyleBackColor = false;
            // 
            // radioButton176
            // 
            this.radioButton176.AutoSize = true;
            this.radioButton176.BackColor = System.Drawing.Color.Transparent;
            this.radioButton176.Enabled = false;
            this.radioButton176.Location = new System.Drawing.Point(86, 4);
            this.radioButton176.Name = "radioButton176";
            this.radioButton176.Size = new System.Drawing.Size(14, 13);
            this.radioButton176.TabIndex = 2;
            this.radioButton176.TabStop = true;
            this.radioButton176.UseVisualStyleBackColor = false;
            // 
            // radioButton177
            // 
            this.radioButton177.AutoSize = true;
            this.radioButton177.BackColor = System.Drawing.Color.Transparent;
            this.radioButton177.Enabled = false;
            this.radioButton177.Location = new System.Drawing.Point(126, 4);
            this.radioButton177.Name = "radioButton177";
            this.radioButton177.Size = new System.Drawing.Size(14, 13);
            this.radioButton177.TabIndex = 4;
            this.radioButton177.TabStop = true;
            this.radioButton177.UseVisualStyleBackColor = false;
            // 
            // radioButton178
            // 
            this.radioButton178.AutoSize = true;
            this.radioButton178.BackColor = System.Drawing.Color.Transparent;
            this.radioButton178.Enabled = false;
            this.radioButton178.Location = new System.Drawing.Point(106, 4);
            this.radioButton178.Name = "radioButton178";
            this.radioButton178.Size = new System.Drawing.Size(14, 13);
            this.radioButton178.TabIndex = 3;
            this.radioButton178.TabStop = true;
            this.radioButton178.UseVisualStyleBackColor = false;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel20.Controls.Add(this.radioButton119);
            this.panel20.Controls.Add(this.radioButton120);
            this.panel20.Controls.Add(this.radioButton121);
            this.panel20.Controls.Add(this.radioButton122);
            this.panel20.Controls.Add(this.radioButton123);
            this.panel20.Controls.Add(this.radioButton124);
            this.panel20.Controls.Add(this.radioButton125);
            this.panel20.Controls.Add(this.radioButton126);
            this.panel20.Controls.Add(this.radioButton127);
            this.panel20.Controls.Add(this.radioButton128);
            this.panel20.Controls.Add(this.radioButton129);
            this.panel20.Controls.Add(this.radioButton130);
            this.panel20.Location = new System.Drawing.Point(108, 179);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(245, 21);
            this.panel20.TabIndex = 44;
            // 
            // radioButton119
            // 
            this.radioButton119.AutoSize = true;
            this.radioButton119.BackColor = System.Drawing.Color.Transparent;
            this.radioButton119.Enabled = false;
            this.radioButton119.Location = new System.Drawing.Point(226, 4);
            this.radioButton119.Name = "radioButton119";
            this.radioButton119.Size = new System.Drawing.Size(14, 13);
            this.radioButton119.TabIndex = 47;
            this.radioButton119.TabStop = true;
            this.radioButton119.UseVisualStyleBackColor = false;
            // 
            // radioButton120
            // 
            this.radioButton120.AutoSize = true;
            this.radioButton120.BackColor = System.Drawing.Color.Transparent;
            this.radioButton120.Enabled = false;
            this.radioButton120.Location = new System.Drawing.Point(146, 4);
            this.radioButton120.Name = "radioButton120";
            this.radioButton120.Size = new System.Drawing.Size(14, 13);
            this.radioButton120.TabIndex = 5;
            this.radioButton120.TabStop = true;
            this.radioButton120.UseVisualStyleBackColor = false;
            // 
            // radioButton121
            // 
            this.radioButton121.AutoSize = true;
            this.radioButton121.BackColor = System.Drawing.Color.Transparent;
            this.radioButton121.Enabled = false;
            this.radioButton121.Location = new System.Drawing.Point(166, 4);
            this.radioButton121.Name = "radioButton121";
            this.radioButton121.Size = new System.Drawing.Size(14, 13);
            this.radioButton121.TabIndex = 44;
            this.radioButton121.TabStop = true;
            this.radioButton121.UseVisualStyleBackColor = false;
            // 
            // radioButton122
            // 
            this.radioButton122.AutoSize = true;
            this.radioButton122.BackColor = System.Drawing.Color.Transparent;
            this.radioButton122.Enabled = false;
            this.radioButton122.Location = new System.Drawing.Point(206, 4);
            this.radioButton122.Name = "radioButton122";
            this.radioButton122.Size = new System.Drawing.Size(14, 13);
            this.radioButton122.TabIndex = 46;
            this.radioButton122.TabStop = true;
            this.radioButton122.UseVisualStyleBackColor = false;
            // 
            // radioButton123
            // 
            this.radioButton123.AutoSize = true;
            this.radioButton123.BackColor = System.Drawing.Color.Transparent;
            this.radioButton123.Enabled = false;
            this.radioButton123.Location = new System.Drawing.Point(26, 4);
            this.radioButton123.Name = "radioButton123";
            this.radioButton123.Size = new System.Drawing.Size(14, 13);
            this.radioButton123.TabIndex = 7;
            this.radioButton123.TabStop = true;
            this.radioButton123.UseVisualStyleBackColor = false;
            // 
            // radioButton124
            // 
            this.radioButton124.AutoSize = true;
            this.radioButton124.BackColor = System.Drawing.Color.Transparent;
            this.radioButton124.Enabled = false;
            this.radioButton124.Location = new System.Drawing.Point(186, 4);
            this.radioButton124.Name = "radioButton124";
            this.radioButton124.Size = new System.Drawing.Size(14, 13);
            this.radioButton124.TabIndex = 45;
            this.radioButton124.TabStop = true;
            this.radioButton124.UseVisualStyleBackColor = false;
            // 
            // radioButton125
            // 
            this.radioButton125.AutoSize = true;
            this.radioButton125.BackColor = System.Drawing.Color.Transparent;
            this.radioButton125.Enabled = false;
            this.radioButton125.Location = new System.Drawing.Point(46, 4);
            this.radioButton125.Name = "radioButton125";
            this.radioButton125.Size = new System.Drawing.Size(14, 13);
            this.radioButton125.TabIndex = 0;
            this.radioButton125.TabStop = true;
            this.radioButton125.UseVisualStyleBackColor = false;
            // 
            // radioButton126
            // 
            this.radioButton126.AutoSize = true;
            this.radioButton126.BackColor = System.Drawing.Color.Transparent;
            this.radioButton126.Enabled = false;
            this.radioButton126.Location = new System.Drawing.Point(6, 4);
            this.radioButton126.Name = "radioButton126";
            this.radioButton126.Size = new System.Drawing.Size(14, 13);
            this.radioButton126.TabIndex = 6;
            this.radioButton126.TabStop = true;
            this.radioButton126.UseVisualStyleBackColor = false;
            // 
            // radioButton127
            // 
            this.radioButton127.AutoSize = true;
            this.radioButton127.BackColor = System.Drawing.Color.Transparent;
            this.radioButton127.Enabled = false;
            this.radioButton127.Location = new System.Drawing.Point(66, 4);
            this.radioButton127.Name = "radioButton127";
            this.radioButton127.Size = new System.Drawing.Size(14, 13);
            this.radioButton127.TabIndex = 1;
            this.radioButton127.TabStop = true;
            this.radioButton127.UseVisualStyleBackColor = false;
            // 
            // radioButton128
            // 
            this.radioButton128.AutoSize = true;
            this.radioButton128.BackColor = System.Drawing.Color.Transparent;
            this.radioButton128.Enabled = false;
            this.radioButton128.Location = new System.Drawing.Point(86, 4);
            this.radioButton128.Name = "radioButton128";
            this.radioButton128.Size = new System.Drawing.Size(14, 13);
            this.radioButton128.TabIndex = 2;
            this.radioButton128.TabStop = true;
            this.radioButton128.UseVisualStyleBackColor = false;
            // 
            // radioButton129
            // 
            this.radioButton129.AutoSize = true;
            this.radioButton129.BackColor = System.Drawing.Color.Transparent;
            this.radioButton129.Enabled = false;
            this.radioButton129.Location = new System.Drawing.Point(126, 4);
            this.radioButton129.Name = "radioButton129";
            this.radioButton129.Size = new System.Drawing.Size(14, 13);
            this.radioButton129.TabIndex = 4;
            this.radioButton129.TabStop = true;
            this.radioButton129.UseVisualStyleBackColor = false;
            // 
            // radioButton130
            // 
            this.radioButton130.AutoSize = true;
            this.radioButton130.BackColor = System.Drawing.Color.Transparent;
            this.radioButton130.Enabled = false;
            this.radioButton130.Location = new System.Drawing.Point(106, 4);
            this.radioButton130.Name = "radioButton130";
            this.radioButton130.Size = new System.Drawing.Size(14, 13);
            this.radioButton130.TabIndex = 3;
            this.radioButton130.TabStop = true;
            this.radioButton130.UseVisualStyleBackColor = false;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(48, 142);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(57, 17);
            this.checkBox17.TabIndex = 55;
            this.checkBox17.Text = "Row 5";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel19.Controls.Add(this.radioButton115);
            this.panel19.Controls.Add(this.radioButton107);
            this.panel19.Controls.Add(this.radioButton116);
            this.panel19.Controls.Add(this.radioButton117);
            this.panel19.Controls.Add(this.radioButton108);
            this.panel19.Controls.Add(this.radioButton118);
            this.panel19.Controls.Add(this.radioButton109);
            this.panel19.Controls.Add(this.radioButton110);
            this.panel19.Controls.Add(this.radioButton111);
            this.panel19.Controls.Add(this.radioButton112);
            this.panel19.Controls.Add(this.radioButton113);
            this.panel19.Controls.Add(this.radioButton114);
            this.panel19.Location = new System.Drawing.Point(108, 199);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(245, 21);
            this.panel19.TabIndex = 43;
            // 
            // radioButton115
            // 
            this.radioButton115.AutoSize = true;
            this.radioButton115.BackColor = System.Drawing.Color.Transparent;
            this.radioButton115.Enabled = false;
            this.radioButton115.Location = new System.Drawing.Point(226, 4);
            this.radioButton115.Name = "radioButton115";
            this.radioButton115.Size = new System.Drawing.Size(14, 13);
            this.radioButton115.TabIndex = 47;
            this.radioButton115.TabStop = true;
            this.radioButton115.UseVisualStyleBackColor = false;
            // 
            // radioButton107
            // 
            this.radioButton107.AutoSize = true;
            this.radioButton107.BackColor = System.Drawing.Color.Transparent;
            this.radioButton107.Enabled = false;
            this.radioButton107.Location = new System.Drawing.Point(146, 4);
            this.radioButton107.Name = "radioButton107";
            this.radioButton107.Size = new System.Drawing.Size(14, 13);
            this.radioButton107.TabIndex = 5;
            this.radioButton107.TabStop = true;
            this.radioButton107.UseVisualStyleBackColor = false;
            // 
            // radioButton116
            // 
            this.radioButton116.AutoSize = true;
            this.radioButton116.BackColor = System.Drawing.Color.Transparent;
            this.radioButton116.Enabled = false;
            this.radioButton116.Location = new System.Drawing.Point(166, 4);
            this.radioButton116.Name = "radioButton116";
            this.radioButton116.Size = new System.Drawing.Size(14, 13);
            this.radioButton116.TabIndex = 44;
            this.radioButton116.TabStop = true;
            this.radioButton116.UseVisualStyleBackColor = false;
            // 
            // radioButton117
            // 
            this.radioButton117.AutoSize = true;
            this.radioButton117.BackColor = System.Drawing.Color.Transparent;
            this.radioButton117.Enabled = false;
            this.radioButton117.Location = new System.Drawing.Point(206, 4);
            this.radioButton117.Name = "radioButton117";
            this.radioButton117.Size = new System.Drawing.Size(14, 13);
            this.radioButton117.TabIndex = 46;
            this.radioButton117.TabStop = true;
            this.radioButton117.UseVisualStyleBackColor = false;
            // 
            // radioButton108
            // 
            this.radioButton108.AutoSize = true;
            this.radioButton108.BackColor = System.Drawing.Color.Transparent;
            this.radioButton108.Enabled = false;
            this.radioButton108.Location = new System.Drawing.Point(26, 4);
            this.radioButton108.Name = "radioButton108";
            this.radioButton108.Size = new System.Drawing.Size(14, 13);
            this.radioButton108.TabIndex = 7;
            this.radioButton108.TabStop = true;
            this.radioButton108.UseVisualStyleBackColor = false;
            // 
            // radioButton118
            // 
            this.radioButton118.AutoSize = true;
            this.radioButton118.BackColor = System.Drawing.Color.Transparent;
            this.radioButton118.Enabled = false;
            this.radioButton118.Location = new System.Drawing.Point(186, 4);
            this.radioButton118.Name = "radioButton118";
            this.radioButton118.Size = new System.Drawing.Size(14, 13);
            this.radioButton118.TabIndex = 45;
            this.radioButton118.TabStop = true;
            this.radioButton118.UseVisualStyleBackColor = false;
            // 
            // radioButton109
            // 
            this.radioButton109.AutoSize = true;
            this.radioButton109.BackColor = System.Drawing.Color.Transparent;
            this.radioButton109.Enabled = false;
            this.radioButton109.Location = new System.Drawing.Point(46, 4);
            this.radioButton109.Name = "radioButton109";
            this.radioButton109.Size = new System.Drawing.Size(14, 13);
            this.radioButton109.TabIndex = 0;
            this.radioButton109.TabStop = true;
            this.radioButton109.UseVisualStyleBackColor = false;
            // 
            // radioButton110
            // 
            this.radioButton110.AutoSize = true;
            this.radioButton110.BackColor = System.Drawing.Color.Transparent;
            this.radioButton110.Enabled = false;
            this.radioButton110.Location = new System.Drawing.Point(6, 4);
            this.radioButton110.Name = "radioButton110";
            this.radioButton110.Size = new System.Drawing.Size(14, 13);
            this.radioButton110.TabIndex = 6;
            this.radioButton110.TabStop = true;
            this.radioButton110.UseVisualStyleBackColor = false;
            // 
            // radioButton111
            // 
            this.radioButton111.AutoSize = true;
            this.radioButton111.BackColor = System.Drawing.Color.Transparent;
            this.radioButton111.Enabled = false;
            this.radioButton111.Location = new System.Drawing.Point(66, 4);
            this.radioButton111.Name = "radioButton111";
            this.radioButton111.Size = new System.Drawing.Size(14, 13);
            this.radioButton111.TabIndex = 1;
            this.radioButton111.TabStop = true;
            this.radioButton111.UseVisualStyleBackColor = false;
            // 
            // radioButton112
            // 
            this.radioButton112.AutoSize = true;
            this.radioButton112.BackColor = System.Drawing.Color.Transparent;
            this.radioButton112.Enabled = false;
            this.radioButton112.Location = new System.Drawing.Point(86, 4);
            this.radioButton112.Name = "radioButton112";
            this.radioButton112.Size = new System.Drawing.Size(14, 13);
            this.radioButton112.TabIndex = 2;
            this.radioButton112.TabStop = true;
            this.radioButton112.UseVisualStyleBackColor = false;
            // 
            // radioButton113
            // 
            this.radioButton113.AutoSize = true;
            this.radioButton113.BackColor = System.Drawing.Color.Transparent;
            this.radioButton113.Enabled = false;
            this.radioButton113.Location = new System.Drawing.Point(126, 4);
            this.radioButton113.Name = "radioButton113";
            this.radioButton113.Size = new System.Drawing.Size(14, 13);
            this.radioButton113.TabIndex = 4;
            this.radioButton113.TabStop = true;
            this.radioButton113.UseVisualStyleBackColor = false;
            // 
            // radioButton114
            // 
            this.radioButton114.AutoSize = true;
            this.radioButton114.BackColor = System.Drawing.Color.Transparent;
            this.radioButton114.Enabled = false;
            this.radioButton114.Location = new System.Drawing.Point(106, 4);
            this.radioButton114.Name = "radioButton114";
            this.radioButton114.Size = new System.Drawing.Size(14, 13);
            this.radioButton114.TabIndex = 3;
            this.radioButton114.TabStop = true;
            this.radioButton114.UseVisualStyleBackColor = false;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(48, 62);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(57, 17);
            this.checkBox21.TabIndex = 51;
            this.checkBox21.Text = "Row 1";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(48, 122);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(57, 17);
            this.checkBox18.TabIndex = 54;
            this.checkBox18.Text = "Row 4";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(48, 82);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(57, 17);
            this.checkBox20.TabIndex = 52;
            this.checkBox20.Text = "Row 2";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(48, 102);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(57, 17);
            this.checkBox19.TabIndex = 53;
            this.checkBox19.Text = "Row 3";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AliceBlue;
            this.panel6.Controls.Add(this.checkBox8);
            this.panel6.Controls.Add(this.checkBox9);
            this.panel6.Controls.Add(this.checkBox10);
            this.panel6.Controls.Add(this.checkBox11);
            this.panel6.Controls.Add(this.checkBox12);
            this.panel6.Controls.Add(this.checkBox13);
            this.panel6.Controls.Add(this.checkBox5);
            this.panel6.Controls.Add(this.checkBox6);
            this.panel6.Controls.Add(this.checkBox7);
            this.panel6.Controls.Add(this.checkBox4);
            this.panel6.Controls.Add(this.checkBox3);
            this.panel6.Controls.Add(this.checkBox2);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Controls.Add(this.panel14);
            this.panel6.Controls.Add(this.panel16);
            this.panel6.Controls.Add(this.panel17);
            this.panel6.Controls.Add(this.panel18);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel15);
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(332, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 299);
            this.panel6.TabIndex = 11;
            this.panel6.Visible = false;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_mouse_down);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_mouse_move);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_mouse_up);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox8.Location = new System.Drawing.Point(49, 255);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(63, 17);
            this.checkBox8.TabIndex = 42;
            this.checkBox8.Text = "Row 12";
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.Color.Transparent;
            this.checkBox9.Location = new System.Drawing.Point(49, 235);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(63, 17);
            this.checkBox9.TabIndex = 41;
            this.checkBox9.Text = "Row 11";
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.Color.Transparent;
            this.checkBox10.Location = new System.Drawing.Point(49, 215);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(63, 17);
            this.checkBox10.TabIndex = 40;
            this.checkBox10.Text = "Row 10";
            this.checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(49, 195);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(57, 17);
            this.checkBox11.TabIndex = 39;
            this.checkBox11.Text = "Row 9";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(49, 175);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(57, 17);
            this.checkBox12.TabIndex = 38;
            this.checkBox12.Text = "Row 8";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(49, 155);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(57, 17);
            this.checkBox13.TabIndex = 37;
            this.checkBox13.Text = "Row 7";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(49, 135);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(57, 17);
            this.checkBox5.TabIndex = 36;
            this.checkBox5.Text = "Row 6";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(49, 115);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 17);
            this.checkBox6.TabIndex = 35;
            this.checkBox6.Text = "Row 5";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(49, 95);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(57, 17);
            this.checkBox7.TabIndex = 34;
            this.checkBox7.Text = "Row 4";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(49, 75);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(57, 17);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "Row 3";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(49, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "Row 2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(49, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(57, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "Row 1";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel12.Controls.Add(this.radioButton51);
            this.panel12.Controls.Add(this.radioButton52);
            this.panel12.Controls.Add(this.radioButton53);
            this.panel12.Controls.Add(this.radioButton54);
            this.panel12.Controls.Add(this.radioButton55);
            this.panel12.Controls.Add(this.radioButton56);
            this.panel12.Controls.Add(this.radioButton57);
            this.panel12.Controls.Add(this.radioButton58);
            this.panel12.Location = new System.Drawing.Point(114, 152);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(164, 21);
            this.panel12.TabIndex = 24;
            this.panel12.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton51
            // 
            this.radioButton51.AutoSize = true;
            this.radioButton51.BackColor = System.Drawing.Color.Transparent;
            this.radioButton51.Enabled = false;
            this.radioButton51.Location = new System.Drawing.Point(146, 4);
            this.radioButton51.Name = "radioButton51";
            this.radioButton51.Size = new System.Drawing.Size(14, 13);
            this.radioButton51.TabIndex = 5;
            this.radioButton51.TabStop = true;
            this.radioButton51.UseVisualStyleBackColor = false;
            // 
            // radioButton52
            // 
            this.radioButton52.AutoSize = true;
            this.radioButton52.BackColor = System.Drawing.Color.Transparent;
            this.radioButton52.Enabled = false;
            this.radioButton52.Location = new System.Drawing.Point(26, 4);
            this.radioButton52.Name = "radioButton52";
            this.radioButton52.Size = new System.Drawing.Size(14, 13);
            this.radioButton52.TabIndex = 7;
            this.radioButton52.TabStop = true;
            this.radioButton52.UseVisualStyleBackColor = false;
            // 
            // radioButton53
            // 
            this.radioButton53.AutoSize = true;
            this.radioButton53.BackColor = System.Drawing.Color.Transparent;
            this.radioButton53.Enabled = false;
            this.radioButton53.Location = new System.Drawing.Point(46, 4);
            this.radioButton53.Name = "radioButton53";
            this.radioButton53.Size = new System.Drawing.Size(14, 13);
            this.radioButton53.TabIndex = 0;
            this.radioButton53.TabStop = true;
            this.radioButton53.UseVisualStyleBackColor = false;
            // 
            // radioButton54
            // 
            this.radioButton54.AutoSize = true;
            this.radioButton54.BackColor = System.Drawing.Color.Transparent;
            this.radioButton54.Enabled = false;
            this.radioButton54.Location = new System.Drawing.Point(6, 4);
            this.radioButton54.Name = "radioButton54";
            this.radioButton54.Size = new System.Drawing.Size(14, 13);
            this.radioButton54.TabIndex = 6;
            this.radioButton54.TabStop = true;
            this.radioButton54.UseVisualStyleBackColor = false;
            // 
            // radioButton55
            // 
            this.radioButton55.AutoSize = true;
            this.radioButton55.BackColor = System.Drawing.Color.Transparent;
            this.radioButton55.Enabled = false;
            this.radioButton55.Location = new System.Drawing.Point(66, 4);
            this.radioButton55.Name = "radioButton55";
            this.radioButton55.Size = new System.Drawing.Size(14, 13);
            this.radioButton55.TabIndex = 1;
            this.radioButton55.TabStop = true;
            this.radioButton55.UseVisualStyleBackColor = false;
            // 
            // radioButton56
            // 
            this.radioButton56.AutoSize = true;
            this.radioButton56.BackColor = System.Drawing.Color.Transparent;
            this.radioButton56.Enabled = false;
            this.radioButton56.Location = new System.Drawing.Point(86, 4);
            this.radioButton56.Name = "radioButton56";
            this.radioButton56.Size = new System.Drawing.Size(14, 13);
            this.radioButton56.TabIndex = 2;
            this.radioButton56.TabStop = true;
            this.radioButton56.UseVisualStyleBackColor = false;
            // 
            // radioButton57
            // 
            this.radioButton57.AutoSize = true;
            this.radioButton57.BackColor = System.Drawing.Color.Transparent;
            this.radioButton57.Enabled = false;
            this.radioButton57.Location = new System.Drawing.Point(126, 4);
            this.radioButton57.Name = "radioButton57";
            this.radioButton57.Size = new System.Drawing.Size(14, 13);
            this.radioButton57.TabIndex = 4;
            this.radioButton57.TabStop = true;
            this.radioButton57.UseVisualStyleBackColor = false;
            // 
            // radioButton58
            // 
            this.radioButton58.AutoSize = true;
            this.radioButton58.BackColor = System.Drawing.Color.Transparent;
            this.radioButton58.Enabled = false;
            this.radioButton58.Location = new System.Drawing.Point(106, 4);
            this.radioButton58.Name = "radioButton58";
            this.radioButton58.Size = new System.Drawing.Size(14, 13);
            this.radioButton58.TabIndex = 3;
            this.radioButton58.TabStop = true;
            this.radioButton58.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel14.Controls.Add(this.radioButton67);
            this.panel14.Controls.Add(this.radioButton68);
            this.panel14.Controls.Add(this.radioButton69);
            this.panel14.Controls.Add(this.radioButton70);
            this.panel14.Controls.Add(this.radioButton71);
            this.panel14.Controls.Add(this.radioButton72);
            this.panel14.Controls.Add(this.radioButton74);
            this.panel14.Controls.Add(this.radioButton73);
            this.panel14.Location = new System.Drawing.Point(114, 32);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(164, 21);
            this.panel14.TabIndex = 30;
            this.panel14.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            this.panel14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel14.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton67
            // 
            this.radioButton67.AutoSize = true;
            this.radioButton67.BackColor = System.Drawing.Color.Transparent;
            this.radioButton67.Enabled = false;
            this.radioButton67.Location = new System.Drawing.Point(146, 4);
            this.radioButton67.Name = "radioButton67";
            this.radioButton67.Size = new System.Drawing.Size(14, 13);
            this.radioButton67.TabIndex = 5;
            this.radioButton67.TabStop = true;
            this.radioButton67.UseVisualStyleBackColor = false;
            this.radioButton67.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton68
            // 
            this.radioButton68.AutoSize = true;
            this.radioButton68.BackColor = System.Drawing.Color.Transparent;
            this.radioButton68.Enabled = false;
            this.radioButton68.Location = new System.Drawing.Point(26, 4);
            this.radioButton68.Name = "radioButton68";
            this.radioButton68.Size = new System.Drawing.Size(14, 13);
            this.radioButton68.TabIndex = 7;
            this.radioButton68.TabStop = true;
            this.radioButton68.UseVisualStyleBackColor = false;
            this.radioButton68.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton69
            // 
            this.radioButton69.AutoSize = true;
            this.radioButton69.BackColor = System.Drawing.Color.Transparent;
            this.radioButton69.Enabled = false;
            this.radioButton69.Location = new System.Drawing.Point(46, 4);
            this.radioButton69.Name = "radioButton69";
            this.radioButton69.Size = new System.Drawing.Size(14, 13);
            this.radioButton69.TabIndex = 0;
            this.radioButton69.TabStop = true;
            this.radioButton69.UseVisualStyleBackColor = false;
            this.radioButton69.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton70
            // 
            this.radioButton70.AutoSize = true;
            this.radioButton70.BackColor = System.Drawing.Color.Transparent;
            this.radioButton70.Enabled = false;
            this.radioButton70.Location = new System.Drawing.Point(6, 4);
            this.radioButton70.Name = "radioButton70";
            this.radioButton70.Size = new System.Drawing.Size(14, 13);
            this.radioButton70.TabIndex = 6;
            this.radioButton70.TabStop = true;
            this.radioButton70.UseVisualStyleBackColor = false;
            this.radioButton70.CheckedChanged += new System.EventHandler(this.radioButton70_CheckedChanged);
            this.radioButton70.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton71
            // 
            this.radioButton71.AutoSize = true;
            this.radioButton71.BackColor = System.Drawing.Color.Transparent;
            this.radioButton71.Enabled = false;
            this.radioButton71.Location = new System.Drawing.Point(66, 4);
            this.radioButton71.Name = "radioButton71";
            this.radioButton71.Size = new System.Drawing.Size(14, 13);
            this.radioButton71.TabIndex = 1;
            this.radioButton71.TabStop = true;
            this.radioButton71.UseVisualStyleBackColor = false;
            this.radioButton71.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton72
            // 
            this.radioButton72.AutoSize = true;
            this.radioButton72.BackColor = System.Drawing.Color.Transparent;
            this.radioButton72.Enabled = false;
            this.radioButton72.Location = new System.Drawing.Point(86, 4);
            this.radioButton72.Name = "radioButton72";
            this.radioButton72.Size = new System.Drawing.Size(14, 13);
            this.radioButton72.TabIndex = 2;
            this.radioButton72.TabStop = true;
            this.radioButton72.UseVisualStyleBackColor = false;
            this.radioButton72.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton74
            // 
            this.radioButton74.AutoSize = true;
            this.radioButton74.BackColor = System.Drawing.Color.Transparent;
            this.radioButton74.Enabled = false;
            this.radioButton74.Location = new System.Drawing.Point(106, 4);
            this.radioButton74.Name = "radioButton74";
            this.radioButton74.Size = new System.Drawing.Size(14, 13);
            this.radioButton74.TabIndex = 3;
            this.radioButton74.TabStop = true;
            this.radioButton74.UseVisualStyleBackColor = false;
            this.radioButton74.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // radioButton73
            // 
            this.radioButton73.AutoSize = true;
            this.radioButton73.BackColor = System.Drawing.Color.Transparent;
            this.radioButton73.Enabled = false;
            this.radioButton73.Location = new System.Drawing.Point(126, 4);
            this.radioButton73.Name = "radioButton73";
            this.radioButton73.Size = new System.Drawing.Size(14, 13);
            this.radioButton73.TabIndex = 4;
            this.radioButton73.TabStop = true;
            this.radioButton73.UseVisualStyleBackColor = false;
            this.radioButton73.Click += new System.EventHandler(this.Vpanel_onclick);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel16.Controls.Add(this.radioButton83);
            this.panel16.Controls.Add(this.radioButton84);
            this.panel16.Controls.Add(this.radioButton85);
            this.panel16.Controls.Add(this.radioButton86);
            this.panel16.Controls.Add(this.radioButton87);
            this.panel16.Controls.Add(this.radioButton88);
            this.panel16.Controls.Add(this.radioButton89);
            this.panel16.Controls.Add(this.radioButton90);
            this.panel16.Location = new System.Drawing.Point(114, 52);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(164, 21);
            this.panel16.TabIndex = 29;
            this.panel16.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel16.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton83
            // 
            this.radioButton83.AutoSize = true;
            this.radioButton83.BackColor = System.Drawing.Color.Transparent;
            this.radioButton83.Enabled = false;
            this.radioButton83.Location = new System.Drawing.Point(146, 4);
            this.radioButton83.Name = "radioButton83";
            this.radioButton83.Size = new System.Drawing.Size(14, 13);
            this.radioButton83.TabIndex = 5;
            this.radioButton83.TabStop = true;
            this.radioButton83.UseVisualStyleBackColor = false;
            // 
            // radioButton84
            // 
            this.radioButton84.AutoSize = true;
            this.radioButton84.BackColor = System.Drawing.Color.Transparent;
            this.radioButton84.Enabled = false;
            this.radioButton84.Location = new System.Drawing.Point(26, 4);
            this.radioButton84.Name = "radioButton84";
            this.radioButton84.Size = new System.Drawing.Size(14, 13);
            this.radioButton84.TabIndex = 7;
            this.radioButton84.TabStop = true;
            this.radioButton84.UseVisualStyleBackColor = false;
            // 
            // radioButton85
            // 
            this.radioButton85.AutoSize = true;
            this.radioButton85.BackColor = System.Drawing.Color.Transparent;
            this.radioButton85.Enabled = false;
            this.radioButton85.Location = new System.Drawing.Point(46, 4);
            this.radioButton85.Name = "radioButton85";
            this.radioButton85.Size = new System.Drawing.Size(14, 13);
            this.radioButton85.TabIndex = 0;
            this.radioButton85.TabStop = true;
            this.radioButton85.UseVisualStyleBackColor = false;
            // 
            // radioButton86
            // 
            this.radioButton86.AutoSize = true;
            this.radioButton86.BackColor = System.Drawing.Color.Transparent;
            this.radioButton86.Enabled = false;
            this.radioButton86.Location = new System.Drawing.Point(6, 4);
            this.radioButton86.Name = "radioButton86";
            this.radioButton86.Size = new System.Drawing.Size(14, 13);
            this.radioButton86.TabIndex = 6;
            this.radioButton86.TabStop = true;
            this.radioButton86.UseVisualStyleBackColor = false;
            // 
            // radioButton87
            // 
            this.radioButton87.AutoSize = true;
            this.radioButton87.BackColor = System.Drawing.Color.Transparent;
            this.radioButton87.Enabled = false;
            this.radioButton87.Location = new System.Drawing.Point(66, 4);
            this.radioButton87.Name = "radioButton87";
            this.radioButton87.Size = new System.Drawing.Size(14, 13);
            this.radioButton87.TabIndex = 1;
            this.radioButton87.TabStop = true;
            this.radioButton87.UseVisualStyleBackColor = false;
            // 
            // radioButton88
            // 
            this.radioButton88.AutoSize = true;
            this.radioButton88.BackColor = System.Drawing.Color.Transparent;
            this.radioButton88.Enabled = false;
            this.radioButton88.Location = new System.Drawing.Point(86, 4);
            this.radioButton88.Name = "radioButton88";
            this.radioButton88.Size = new System.Drawing.Size(14, 13);
            this.radioButton88.TabIndex = 2;
            this.radioButton88.TabStop = true;
            this.radioButton88.UseVisualStyleBackColor = false;
            // 
            // radioButton89
            // 
            this.radioButton89.AutoSize = true;
            this.radioButton89.BackColor = System.Drawing.Color.Transparent;
            this.radioButton89.Enabled = false;
            this.radioButton89.Location = new System.Drawing.Point(126, 4);
            this.radioButton89.Name = "radioButton89";
            this.radioButton89.Size = new System.Drawing.Size(14, 13);
            this.radioButton89.TabIndex = 4;
            this.radioButton89.TabStop = true;
            this.radioButton89.UseVisualStyleBackColor = false;
            this.radioButton89.CheckedChanged += new System.EventHandler(this.radioButton89_CheckedChanged);
            // 
            // radioButton90
            // 
            this.radioButton90.AutoSize = true;
            this.radioButton90.BackColor = System.Drawing.Color.Transparent;
            this.radioButton90.Enabled = false;
            this.radioButton90.Location = new System.Drawing.Point(106, 4);
            this.radioButton90.Name = "radioButton90";
            this.radioButton90.Size = new System.Drawing.Size(14, 13);
            this.radioButton90.TabIndex = 3;
            this.radioButton90.TabStop = true;
            this.radioButton90.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel17.Controls.Add(this.radioButton91);
            this.panel17.Controls.Add(this.radioButton92);
            this.panel17.Controls.Add(this.radioButton93);
            this.panel17.Controls.Add(this.radioButton94);
            this.panel17.Controls.Add(this.radioButton95);
            this.panel17.Controls.Add(this.radioButton96);
            this.panel17.Controls.Add(this.radioButton97);
            this.panel17.Controls.Add(this.radioButton98);
            this.panel17.Location = new System.Drawing.Point(114, 72);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(164, 21);
            this.panel17.TabIndex = 28;
            this.panel17.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel17.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton91
            // 
            this.radioButton91.AutoSize = true;
            this.radioButton91.BackColor = System.Drawing.Color.Transparent;
            this.radioButton91.Enabled = false;
            this.radioButton91.Location = new System.Drawing.Point(146, 4);
            this.radioButton91.Name = "radioButton91";
            this.radioButton91.Size = new System.Drawing.Size(14, 13);
            this.radioButton91.TabIndex = 5;
            this.radioButton91.TabStop = true;
            this.radioButton91.UseVisualStyleBackColor = false;
            // 
            // radioButton92
            // 
            this.radioButton92.AutoSize = true;
            this.radioButton92.BackColor = System.Drawing.Color.Transparent;
            this.radioButton92.Enabled = false;
            this.radioButton92.Location = new System.Drawing.Point(26, 4);
            this.radioButton92.Name = "radioButton92";
            this.radioButton92.Size = new System.Drawing.Size(14, 13);
            this.radioButton92.TabIndex = 7;
            this.radioButton92.TabStop = true;
            this.radioButton92.UseVisualStyleBackColor = false;
            // 
            // radioButton93
            // 
            this.radioButton93.AutoSize = true;
            this.radioButton93.BackColor = System.Drawing.Color.Transparent;
            this.radioButton93.Enabled = false;
            this.radioButton93.Location = new System.Drawing.Point(46, 4);
            this.radioButton93.Name = "radioButton93";
            this.radioButton93.Size = new System.Drawing.Size(14, 13);
            this.radioButton93.TabIndex = 0;
            this.radioButton93.TabStop = true;
            this.radioButton93.UseVisualStyleBackColor = false;
            // 
            // radioButton94
            // 
            this.radioButton94.AutoSize = true;
            this.radioButton94.BackColor = System.Drawing.Color.Transparent;
            this.radioButton94.Enabled = false;
            this.radioButton94.Location = new System.Drawing.Point(6, 4);
            this.radioButton94.Name = "radioButton94";
            this.radioButton94.Size = new System.Drawing.Size(14, 13);
            this.radioButton94.TabIndex = 6;
            this.radioButton94.TabStop = true;
            this.radioButton94.UseVisualStyleBackColor = false;
            // 
            // radioButton95
            // 
            this.radioButton95.AutoSize = true;
            this.radioButton95.BackColor = System.Drawing.Color.Transparent;
            this.radioButton95.Enabled = false;
            this.radioButton95.Location = new System.Drawing.Point(66, 4);
            this.radioButton95.Name = "radioButton95";
            this.radioButton95.Size = new System.Drawing.Size(14, 13);
            this.radioButton95.TabIndex = 1;
            this.radioButton95.TabStop = true;
            this.radioButton95.UseVisualStyleBackColor = false;
            // 
            // radioButton96
            // 
            this.radioButton96.AutoSize = true;
            this.radioButton96.BackColor = System.Drawing.Color.Transparent;
            this.radioButton96.Enabled = false;
            this.radioButton96.Location = new System.Drawing.Point(86, 4);
            this.radioButton96.Name = "radioButton96";
            this.radioButton96.Size = new System.Drawing.Size(14, 13);
            this.radioButton96.TabIndex = 2;
            this.radioButton96.TabStop = true;
            this.radioButton96.UseVisualStyleBackColor = false;
            // 
            // radioButton97
            // 
            this.radioButton97.AutoSize = true;
            this.radioButton97.BackColor = System.Drawing.Color.Transparent;
            this.radioButton97.Enabled = false;
            this.radioButton97.Location = new System.Drawing.Point(126, 4);
            this.radioButton97.Name = "radioButton97";
            this.radioButton97.Size = new System.Drawing.Size(14, 13);
            this.radioButton97.TabIndex = 4;
            this.radioButton97.TabStop = true;
            this.radioButton97.UseVisualStyleBackColor = false;
            // 
            // radioButton98
            // 
            this.radioButton98.AutoSize = true;
            this.radioButton98.BackColor = System.Drawing.Color.Transparent;
            this.radioButton98.Enabled = false;
            this.radioButton98.Location = new System.Drawing.Point(106, 4);
            this.radioButton98.Name = "radioButton98";
            this.radioButton98.Size = new System.Drawing.Size(14, 13);
            this.radioButton98.TabIndex = 3;
            this.radioButton98.TabStop = true;
            this.radioButton98.UseVisualStyleBackColor = false;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel18.Controls.Add(this.radioButton99);
            this.panel18.Controls.Add(this.radioButton100);
            this.panel18.Controls.Add(this.radioButton101);
            this.panel18.Controls.Add(this.radioButton102);
            this.panel18.Controls.Add(this.radioButton103);
            this.panel18.Controls.Add(this.radioButton104);
            this.panel18.Controls.Add(this.radioButton105);
            this.panel18.Controls.Add(this.radioButton106);
            this.panel18.Location = new System.Drawing.Point(114, 92);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(164, 21);
            this.panel18.TabIndex = 27;
            this.panel18.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel18.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton99
            // 
            this.radioButton99.AutoSize = true;
            this.radioButton99.BackColor = System.Drawing.Color.Transparent;
            this.radioButton99.Enabled = false;
            this.radioButton99.Location = new System.Drawing.Point(146, 4);
            this.radioButton99.Name = "radioButton99";
            this.radioButton99.Size = new System.Drawing.Size(14, 13);
            this.radioButton99.TabIndex = 5;
            this.radioButton99.TabStop = true;
            this.radioButton99.UseVisualStyleBackColor = false;
            // 
            // radioButton100
            // 
            this.radioButton100.AutoSize = true;
            this.radioButton100.BackColor = System.Drawing.Color.Transparent;
            this.radioButton100.Enabled = false;
            this.radioButton100.Location = new System.Drawing.Point(26, 4);
            this.radioButton100.Name = "radioButton100";
            this.radioButton100.Size = new System.Drawing.Size(14, 13);
            this.radioButton100.TabIndex = 7;
            this.radioButton100.TabStop = true;
            this.radioButton100.UseVisualStyleBackColor = false;
            // 
            // radioButton101
            // 
            this.radioButton101.AutoSize = true;
            this.radioButton101.BackColor = System.Drawing.Color.Transparent;
            this.radioButton101.Enabled = false;
            this.radioButton101.Location = new System.Drawing.Point(46, 4);
            this.radioButton101.Name = "radioButton101";
            this.radioButton101.Size = new System.Drawing.Size(14, 13);
            this.radioButton101.TabIndex = 0;
            this.radioButton101.TabStop = true;
            this.radioButton101.UseVisualStyleBackColor = false;
            // 
            // radioButton102
            // 
            this.radioButton102.AutoSize = true;
            this.radioButton102.BackColor = System.Drawing.Color.Transparent;
            this.radioButton102.Enabled = false;
            this.radioButton102.Location = new System.Drawing.Point(6, 4);
            this.radioButton102.Name = "radioButton102";
            this.radioButton102.Size = new System.Drawing.Size(14, 13);
            this.radioButton102.TabIndex = 6;
            this.radioButton102.TabStop = true;
            this.radioButton102.UseVisualStyleBackColor = false;
            // 
            // radioButton103
            // 
            this.radioButton103.AutoSize = true;
            this.radioButton103.BackColor = System.Drawing.Color.Transparent;
            this.radioButton103.Enabled = false;
            this.radioButton103.Location = new System.Drawing.Point(66, 4);
            this.radioButton103.Name = "radioButton103";
            this.radioButton103.Size = new System.Drawing.Size(14, 13);
            this.radioButton103.TabIndex = 1;
            this.radioButton103.TabStop = true;
            this.radioButton103.UseVisualStyleBackColor = false;
            // 
            // radioButton104
            // 
            this.radioButton104.AutoSize = true;
            this.radioButton104.BackColor = System.Drawing.Color.Transparent;
            this.radioButton104.Enabled = false;
            this.radioButton104.Location = new System.Drawing.Point(86, 4);
            this.radioButton104.Name = "radioButton104";
            this.radioButton104.Size = new System.Drawing.Size(14, 13);
            this.radioButton104.TabIndex = 2;
            this.radioButton104.TabStop = true;
            this.radioButton104.UseVisualStyleBackColor = false;
            // 
            // radioButton105
            // 
            this.radioButton105.AutoSize = true;
            this.radioButton105.BackColor = System.Drawing.Color.Transparent;
            this.radioButton105.Enabled = false;
            this.radioButton105.Location = new System.Drawing.Point(126, 4);
            this.radioButton105.Name = "radioButton105";
            this.radioButton105.Size = new System.Drawing.Size(14, 13);
            this.radioButton105.TabIndex = 4;
            this.radioButton105.TabStop = true;
            this.radioButton105.UseVisualStyleBackColor = false;
            // 
            // radioButton106
            // 
            this.radioButton106.AutoSize = true;
            this.radioButton106.BackColor = System.Drawing.Color.Transparent;
            this.radioButton106.Enabled = false;
            this.radioButton106.Location = new System.Drawing.Point(106, 4);
            this.radioButton106.Name = "radioButton106";
            this.radioButton106.Size = new System.Drawing.Size(14, 13);
            this.radioButton106.TabIndex = 3;
            this.radioButton106.TabStop = true;
            this.radioButton106.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel10.Controls.Add(this.radioButton35);
            this.panel10.Controls.Add(this.radioButton36);
            this.panel10.Controls.Add(this.radioButton37);
            this.panel10.Controls.Add(this.radioButton38);
            this.panel10.Controls.Add(this.radioButton39);
            this.panel10.Controls.Add(this.radioButton40);
            this.panel10.Controls.Add(this.radioButton41);
            this.panel10.Controls.Add(this.radioButton42);
            this.panel10.Location = new System.Drawing.Point(114, 112);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(164, 21);
            this.panel10.TabIndex = 26;
            this.panel10.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton35
            // 
            this.radioButton35.AutoSize = true;
            this.radioButton35.BackColor = System.Drawing.Color.Transparent;
            this.radioButton35.Enabled = false;
            this.radioButton35.Location = new System.Drawing.Point(146, 4);
            this.radioButton35.Name = "radioButton35";
            this.radioButton35.Size = new System.Drawing.Size(14, 13);
            this.radioButton35.TabIndex = 5;
            this.radioButton35.TabStop = true;
            this.radioButton35.UseVisualStyleBackColor = false;
            // 
            // radioButton36
            // 
            this.radioButton36.AutoSize = true;
            this.radioButton36.BackColor = System.Drawing.Color.Transparent;
            this.radioButton36.Enabled = false;
            this.radioButton36.Location = new System.Drawing.Point(26, 4);
            this.radioButton36.Name = "radioButton36";
            this.radioButton36.Size = new System.Drawing.Size(14, 13);
            this.radioButton36.TabIndex = 7;
            this.radioButton36.TabStop = true;
            this.radioButton36.UseVisualStyleBackColor = false;
            // 
            // radioButton37
            // 
            this.radioButton37.AutoSize = true;
            this.radioButton37.BackColor = System.Drawing.Color.Transparent;
            this.radioButton37.Enabled = false;
            this.radioButton37.Location = new System.Drawing.Point(46, 4);
            this.radioButton37.Name = "radioButton37";
            this.radioButton37.Size = new System.Drawing.Size(14, 13);
            this.radioButton37.TabIndex = 0;
            this.radioButton37.TabStop = true;
            this.radioButton37.UseVisualStyleBackColor = false;
            // 
            // radioButton38
            // 
            this.radioButton38.AutoSize = true;
            this.radioButton38.BackColor = System.Drawing.Color.Transparent;
            this.radioButton38.Enabled = false;
            this.radioButton38.Location = new System.Drawing.Point(6, 4);
            this.radioButton38.Name = "radioButton38";
            this.radioButton38.Size = new System.Drawing.Size(14, 13);
            this.radioButton38.TabIndex = 6;
            this.radioButton38.TabStop = true;
            this.radioButton38.UseVisualStyleBackColor = false;
            // 
            // radioButton39
            // 
            this.radioButton39.AutoSize = true;
            this.radioButton39.BackColor = System.Drawing.Color.Transparent;
            this.radioButton39.Enabled = false;
            this.radioButton39.Location = new System.Drawing.Point(66, 4);
            this.radioButton39.Name = "radioButton39";
            this.radioButton39.Size = new System.Drawing.Size(14, 13);
            this.radioButton39.TabIndex = 1;
            this.radioButton39.TabStop = true;
            this.radioButton39.UseVisualStyleBackColor = false;
            // 
            // radioButton40
            // 
            this.radioButton40.AutoSize = true;
            this.radioButton40.BackColor = System.Drawing.Color.Transparent;
            this.radioButton40.Enabled = false;
            this.radioButton40.Location = new System.Drawing.Point(86, 4);
            this.radioButton40.Name = "radioButton40";
            this.radioButton40.Size = new System.Drawing.Size(14, 13);
            this.radioButton40.TabIndex = 2;
            this.radioButton40.TabStop = true;
            this.radioButton40.UseVisualStyleBackColor = false;
            // 
            // radioButton41
            // 
            this.radioButton41.AutoSize = true;
            this.radioButton41.BackColor = System.Drawing.Color.Transparent;
            this.radioButton41.Enabled = false;
            this.radioButton41.Location = new System.Drawing.Point(126, 4);
            this.radioButton41.Name = "radioButton41";
            this.radioButton41.Size = new System.Drawing.Size(14, 13);
            this.radioButton41.TabIndex = 4;
            this.radioButton41.TabStop = true;
            this.radioButton41.UseVisualStyleBackColor = false;
            // 
            // radioButton42
            // 
            this.radioButton42.AutoSize = true;
            this.radioButton42.BackColor = System.Drawing.Color.Transparent;
            this.radioButton42.Enabled = false;
            this.radioButton42.Location = new System.Drawing.Point(106, 4);
            this.radioButton42.Name = "radioButton42";
            this.radioButton42.Size = new System.Drawing.Size(14, 13);
            this.radioButton42.TabIndex = 3;
            this.radioButton42.TabStop = true;
            this.radioButton42.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel11.Controls.Add(this.radioButton43);
            this.panel11.Controls.Add(this.radioButton44);
            this.panel11.Controls.Add(this.radioButton45);
            this.panel11.Controls.Add(this.radioButton46);
            this.panel11.Controls.Add(this.radioButton47);
            this.panel11.Controls.Add(this.radioButton48);
            this.panel11.Controls.Add(this.radioButton49);
            this.panel11.Controls.Add(this.radioButton50);
            this.panel11.Location = new System.Drawing.Point(114, 132);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(164, 21);
            this.panel11.TabIndex = 25;
            this.panel11.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton43
            // 
            this.radioButton43.AutoSize = true;
            this.radioButton43.BackColor = System.Drawing.Color.Transparent;
            this.radioButton43.Enabled = false;
            this.radioButton43.Location = new System.Drawing.Point(146, 4);
            this.radioButton43.Name = "radioButton43";
            this.radioButton43.Size = new System.Drawing.Size(14, 13);
            this.radioButton43.TabIndex = 5;
            this.radioButton43.TabStop = true;
            this.radioButton43.UseVisualStyleBackColor = false;
            // 
            // radioButton44
            // 
            this.radioButton44.AutoSize = true;
            this.radioButton44.BackColor = System.Drawing.Color.Transparent;
            this.radioButton44.Enabled = false;
            this.radioButton44.Location = new System.Drawing.Point(26, 4);
            this.radioButton44.Name = "radioButton44";
            this.radioButton44.Size = new System.Drawing.Size(14, 13);
            this.radioButton44.TabIndex = 7;
            this.radioButton44.TabStop = true;
            this.radioButton44.UseVisualStyleBackColor = false;
            // 
            // radioButton45
            // 
            this.radioButton45.AutoSize = true;
            this.radioButton45.BackColor = System.Drawing.Color.Transparent;
            this.radioButton45.Enabled = false;
            this.radioButton45.Location = new System.Drawing.Point(46, 4);
            this.radioButton45.Name = "radioButton45";
            this.radioButton45.Size = new System.Drawing.Size(14, 13);
            this.radioButton45.TabIndex = 0;
            this.radioButton45.TabStop = true;
            this.radioButton45.UseVisualStyleBackColor = false;
            // 
            // radioButton46
            // 
            this.radioButton46.AutoSize = true;
            this.radioButton46.BackColor = System.Drawing.Color.Transparent;
            this.radioButton46.Enabled = false;
            this.radioButton46.Location = new System.Drawing.Point(6, 4);
            this.radioButton46.Name = "radioButton46";
            this.radioButton46.Size = new System.Drawing.Size(14, 13);
            this.radioButton46.TabIndex = 6;
            this.radioButton46.TabStop = true;
            this.radioButton46.UseVisualStyleBackColor = false;
            // 
            // radioButton47
            // 
            this.radioButton47.AutoSize = true;
            this.radioButton47.BackColor = System.Drawing.Color.Transparent;
            this.radioButton47.Enabled = false;
            this.radioButton47.Location = new System.Drawing.Point(66, 4);
            this.radioButton47.Name = "radioButton47";
            this.radioButton47.Size = new System.Drawing.Size(14, 13);
            this.radioButton47.TabIndex = 1;
            this.radioButton47.TabStop = true;
            this.radioButton47.UseVisualStyleBackColor = false;
            // 
            // radioButton48
            // 
            this.radioButton48.AutoSize = true;
            this.radioButton48.BackColor = System.Drawing.Color.Transparent;
            this.radioButton48.Enabled = false;
            this.radioButton48.Location = new System.Drawing.Point(86, 4);
            this.radioButton48.Name = "radioButton48";
            this.radioButton48.Size = new System.Drawing.Size(14, 13);
            this.radioButton48.TabIndex = 2;
            this.radioButton48.TabStop = true;
            this.radioButton48.UseVisualStyleBackColor = false;
            // 
            // radioButton49
            // 
            this.radioButton49.AutoSize = true;
            this.radioButton49.BackColor = System.Drawing.Color.Transparent;
            this.radioButton49.Enabled = false;
            this.radioButton49.Location = new System.Drawing.Point(126, 4);
            this.radioButton49.Name = "radioButton49";
            this.radioButton49.Size = new System.Drawing.Size(14, 13);
            this.radioButton49.TabIndex = 4;
            this.radioButton49.TabStop = true;
            this.radioButton49.UseVisualStyleBackColor = false;
            // 
            // radioButton50
            // 
            this.radioButton50.AutoSize = true;
            this.radioButton50.BackColor = System.Drawing.Color.Transparent;
            this.radioButton50.Enabled = false;
            this.radioButton50.Location = new System.Drawing.Point(106, 4);
            this.radioButton50.Name = "radioButton50";
            this.radioButton50.Size = new System.Drawing.Size(14, 13);
            this.radioButton50.TabIndex = 3;
            this.radioButton50.TabStop = true;
            this.radioButton50.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel13.Controls.Add(this.radioButton59);
            this.panel13.Controls.Add(this.radioButton60);
            this.panel13.Controls.Add(this.radioButton61);
            this.panel13.Controls.Add(this.radioButton62);
            this.panel13.Controls.Add(this.radioButton63);
            this.panel13.Controls.Add(this.radioButton64);
            this.panel13.Controls.Add(this.radioButton65);
            this.panel13.Controls.Add(this.radioButton66);
            this.panel13.Location = new System.Drawing.Point(114, 172);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(164, 21);
            this.panel13.TabIndex = 23;
            this.panel13.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton59
            // 
            this.radioButton59.AutoSize = true;
            this.radioButton59.BackColor = System.Drawing.Color.Transparent;
            this.radioButton59.Enabled = false;
            this.radioButton59.Location = new System.Drawing.Point(146, 4);
            this.radioButton59.Name = "radioButton59";
            this.radioButton59.Size = new System.Drawing.Size(14, 13);
            this.radioButton59.TabIndex = 5;
            this.radioButton59.TabStop = true;
            this.radioButton59.UseVisualStyleBackColor = false;
            // 
            // radioButton60
            // 
            this.radioButton60.AutoSize = true;
            this.radioButton60.BackColor = System.Drawing.Color.Transparent;
            this.radioButton60.Enabled = false;
            this.radioButton60.Location = new System.Drawing.Point(26, 4);
            this.radioButton60.Name = "radioButton60";
            this.radioButton60.Size = new System.Drawing.Size(14, 13);
            this.radioButton60.TabIndex = 7;
            this.radioButton60.TabStop = true;
            this.radioButton60.UseVisualStyleBackColor = false;
            // 
            // radioButton61
            // 
            this.radioButton61.AutoSize = true;
            this.radioButton61.BackColor = System.Drawing.Color.Transparent;
            this.radioButton61.Enabled = false;
            this.radioButton61.Location = new System.Drawing.Point(46, 4);
            this.radioButton61.Name = "radioButton61";
            this.radioButton61.Size = new System.Drawing.Size(14, 13);
            this.radioButton61.TabIndex = 0;
            this.radioButton61.TabStop = true;
            this.radioButton61.UseVisualStyleBackColor = false;
            // 
            // radioButton62
            // 
            this.radioButton62.AutoSize = true;
            this.radioButton62.BackColor = System.Drawing.Color.Transparent;
            this.radioButton62.Enabled = false;
            this.radioButton62.Location = new System.Drawing.Point(6, 4);
            this.radioButton62.Name = "radioButton62";
            this.radioButton62.Size = new System.Drawing.Size(14, 13);
            this.radioButton62.TabIndex = 6;
            this.radioButton62.TabStop = true;
            this.radioButton62.UseVisualStyleBackColor = false;
            // 
            // radioButton63
            // 
            this.radioButton63.AutoSize = true;
            this.radioButton63.BackColor = System.Drawing.Color.Transparent;
            this.radioButton63.Enabled = false;
            this.radioButton63.Location = new System.Drawing.Point(66, 4);
            this.radioButton63.Name = "radioButton63";
            this.radioButton63.Size = new System.Drawing.Size(14, 13);
            this.radioButton63.TabIndex = 1;
            this.radioButton63.TabStop = true;
            this.radioButton63.UseVisualStyleBackColor = false;
            // 
            // radioButton64
            // 
            this.radioButton64.AutoSize = true;
            this.radioButton64.BackColor = System.Drawing.Color.Transparent;
            this.radioButton64.Enabled = false;
            this.radioButton64.Location = new System.Drawing.Point(86, 4);
            this.radioButton64.Name = "radioButton64";
            this.radioButton64.Size = new System.Drawing.Size(14, 13);
            this.radioButton64.TabIndex = 2;
            this.radioButton64.TabStop = true;
            this.radioButton64.UseVisualStyleBackColor = false;
            // 
            // radioButton65
            // 
            this.radioButton65.AutoSize = true;
            this.radioButton65.BackColor = System.Drawing.Color.Transparent;
            this.radioButton65.Enabled = false;
            this.radioButton65.Location = new System.Drawing.Point(126, 4);
            this.radioButton65.Name = "radioButton65";
            this.radioButton65.Size = new System.Drawing.Size(14, 13);
            this.radioButton65.TabIndex = 4;
            this.radioButton65.TabStop = true;
            this.radioButton65.UseVisualStyleBackColor = false;
            // 
            // radioButton66
            // 
            this.radioButton66.AutoSize = true;
            this.radioButton66.BackColor = System.Drawing.Color.Transparent;
            this.radioButton66.Enabled = false;
            this.radioButton66.Location = new System.Drawing.Point(106, 4);
            this.radioButton66.Name = "radioButton66";
            this.radioButton66.Size = new System.Drawing.Size(14, 13);
            this.radioButton66.TabIndex = 3;
            this.radioButton66.TabStop = true;
            this.radioButton66.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel8.Controls.Add(this.radioButton19);
            this.panel8.Controls.Add(this.radioButton20);
            this.panel8.Controls.Add(this.radioButton21);
            this.panel8.Controls.Add(this.radioButton22);
            this.panel8.Controls.Add(this.radioButton23);
            this.panel8.Controls.Add(this.radioButton24);
            this.panel8.Controls.Add(this.radioButton25);
            this.panel8.Controls.Add(this.radioButton26);
            this.panel8.Location = new System.Drawing.Point(114, 192);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 21);
            this.panel8.TabIndex = 22;
            this.panel8.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.BackColor = System.Drawing.Color.Transparent;
            this.radioButton19.Enabled = false;
            this.radioButton19.Location = new System.Drawing.Point(146, 4);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(14, 13);
            this.radioButton19.TabIndex = 5;
            this.radioButton19.TabStop = true;
            this.radioButton19.UseVisualStyleBackColor = false;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.BackColor = System.Drawing.Color.Transparent;
            this.radioButton20.Enabled = false;
            this.radioButton20.Location = new System.Drawing.Point(26, 4);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(14, 13);
            this.radioButton20.TabIndex = 7;
            this.radioButton20.TabStop = true;
            this.radioButton20.UseVisualStyleBackColor = false;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.BackColor = System.Drawing.Color.Transparent;
            this.radioButton21.Enabled = false;
            this.radioButton21.Location = new System.Drawing.Point(46, 4);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(14, 13);
            this.radioButton21.TabIndex = 0;
            this.radioButton21.TabStop = true;
            this.radioButton21.UseVisualStyleBackColor = false;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.BackColor = System.Drawing.Color.Transparent;
            this.radioButton22.Enabled = false;
            this.radioButton22.Location = new System.Drawing.Point(6, 4);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(14, 13);
            this.radioButton22.TabIndex = 6;
            this.radioButton22.TabStop = true;
            this.radioButton22.UseVisualStyleBackColor = false;
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.BackColor = System.Drawing.Color.Transparent;
            this.radioButton23.Enabled = false;
            this.radioButton23.Location = new System.Drawing.Point(66, 4);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(14, 13);
            this.radioButton23.TabIndex = 1;
            this.radioButton23.TabStop = true;
            this.radioButton23.UseVisualStyleBackColor = false;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.BackColor = System.Drawing.Color.Transparent;
            this.radioButton24.Enabled = false;
            this.radioButton24.Location = new System.Drawing.Point(86, 4);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(14, 13);
            this.radioButton24.TabIndex = 2;
            this.radioButton24.TabStop = true;
            this.radioButton24.UseVisualStyleBackColor = false;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.BackColor = System.Drawing.Color.Transparent;
            this.radioButton25.Enabled = false;
            this.radioButton25.Location = new System.Drawing.Point(126, 4);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(14, 13);
            this.radioButton25.TabIndex = 4;
            this.radioButton25.TabStop = true;
            this.radioButton25.UseVisualStyleBackColor = false;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.BackColor = System.Drawing.Color.Transparent;
            this.radioButton26.Enabled = false;
            this.radioButton26.Location = new System.Drawing.Point(106, 4);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(14, 13);
            this.radioButton26.TabIndex = 3;
            this.radioButton26.TabStop = true;
            this.radioButton26.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel9.Controls.Add(this.radioButton27);
            this.panel9.Controls.Add(this.radioButton28);
            this.panel9.Controls.Add(this.radioButton29);
            this.panel9.Controls.Add(this.radioButton30);
            this.panel9.Controls.Add(this.radioButton31);
            this.panel9.Controls.Add(this.radioButton32);
            this.panel9.Controls.Add(this.radioButton33);
            this.panel9.Controls.Add(this.radioButton34);
            this.panel9.Location = new System.Drawing.Point(114, 212);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(164, 21);
            this.panel9.TabIndex = 21;
            this.panel9.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.BackColor = System.Drawing.Color.Transparent;
            this.radioButton27.Enabled = false;
            this.radioButton27.Location = new System.Drawing.Point(146, 4);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(14, 13);
            this.radioButton27.TabIndex = 5;
            this.radioButton27.TabStop = true;
            this.radioButton27.UseVisualStyleBackColor = false;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.BackColor = System.Drawing.Color.Transparent;
            this.radioButton28.Enabled = false;
            this.radioButton28.Location = new System.Drawing.Point(26, 4);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(14, 13);
            this.radioButton28.TabIndex = 7;
            this.radioButton28.TabStop = true;
            this.radioButton28.UseVisualStyleBackColor = false;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.BackColor = System.Drawing.Color.Transparent;
            this.radioButton29.Enabled = false;
            this.radioButton29.Location = new System.Drawing.Point(46, 4);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(14, 13);
            this.radioButton29.TabIndex = 0;
            this.radioButton29.TabStop = true;
            this.radioButton29.UseVisualStyleBackColor = false;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.BackColor = System.Drawing.Color.Transparent;
            this.radioButton30.Enabled = false;
            this.radioButton30.Location = new System.Drawing.Point(6, 4);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(14, 13);
            this.radioButton30.TabIndex = 6;
            this.radioButton30.TabStop = true;
            this.radioButton30.UseVisualStyleBackColor = false;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.BackColor = System.Drawing.Color.Transparent;
            this.radioButton31.Enabled = false;
            this.radioButton31.Location = new System.Drawing.Point(66, 4);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(14, 13);
            this.radioButton31.TabIndex = 1;
            this.radioButton31.TabStop = true;
            this.radioButton31.UseVisualStyleBackColor = false;
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.BackColor = System.Drawing.Color.Transparent;
            this.radioButton32.Enabled = false;
            this.radioButton32.Location = new System.Drawing.Point(86, 4);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(14, 13);
            this.radioButton32.TabIndex = 2;
            this.radioButton32.TabStop = true;
            this.radioButton32.UseVisualStyleBackColor = false;
            // 
            // radioButton33
            // 
            this.radioButton33.AutoSize = true;
            this.radioButton33.BackColor = System.Drawing.Color.Transparent;
            this.radioButton33.Enabled = false;
            this.radioButton33.Location = new System.Drawing.Point(126, 4);
            this.radioButton33.Name = "radioButton33";
            this.radioButton33.Size = new System.Drawing.Size(14, 13);
            this.radioButton33.TabIndex = 4;
            this.radioButton33.TabStop = true;
            this.radioButton33.UseVisualStyleBackColor = false;
            // 
            // radioButton34
            // 
            this.radioButton34.AutoSize = true;
            this.radioButton34.BackColor = System.Drawing.Color.Transparent;
            this.radioButton34.Enabled = false;
            this.radioButton34.Location = new System.Drawing.Point(106, 4);
            this.radioButton34.Name = "radioButton34";
            this.radioButton34.Size = new System.Drawing.Size(14, 13);
            this.radioButton34.TabIndex = 3;
            this.radioButton34.TabStop = true;
            this.radioButton34.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Controls.Add(this.radioButton11);
            this.panel7.Controls.Add(this.radioButton12);
            this.panel7.Controls.Add(this.radioButton13);
            this.panel7.Controls.Add(this.radioButton14);
            this.panel7.Controls.Add(this.radioButton15);
            this.panel7.Controls.Add(this.radioButton16);
            this.panel7.Controls.Add(this.radioButton17);
            this.panel7.Controls.Add(this.radioButton18);
            this.panel7.Location = new System.Drawing.Point(114, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(164, 21);
            this.panel7.TabIndex = 20;
            this.panel7.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.BackColor = System.Drawing.Color.Transparent;
            this.radioButton11.Enabled = false;
            this.radioButton11.Location = new System.Drawing.Point(146, 4);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(14, 13);
            this.radioButton11.TabIndex = 5;
            this.radioButton11.TabStop = true;
            this.radioButton11.UseVisualStyleBackColor = false;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.BackColor = System.Drawing.Color.Transparent;
            this.radioButton12.Enabled = false;
            this.radioButton12.Location = new System.Drawing.Point(26, 4);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(14, 13);
            this.radioButton12.TabIndex = 7;
            this.radioButton12.TabStop = true;
            this.radioButton12.UseVisualStyleBackColor = false;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.BackColor = System.Drawing.Color.Transparent;
            this.radioButton13.Enabled = false;
            this.radioButton13.Location = new System.Drawing.Point(46, 4);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(14, 13);
            this.radioButton13.TabIndex = 0;
            this.radioButton13.TabStop = true;
            this.radioButton13.UseVisualStyleBackColor = false;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.BackColor = System.Drawing.Color.Transparent;
            this.radioButton14.Enabled = false;
            this.radioButton14.Location = new System.Drawing.Point(6, 4);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(14, 13);
            this.radioButton14.TabIndex = 6;
            this.radioButton14.TabStop = true;
            this.radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.BackColor = System.Drawing.Color.Transparent;
            this.radioButton15.Enabled = false;
            this.radioButton15.Location = new System.Drawing.Point(66, 4);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(14, 13);
            this.radioButton15.TabIndex = 1;
            this.radioButton15.TabStop = true;
            this.radioButton15.UseVisualStyleBackColor = false;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.BackColor = System.Drawing.Color.Transparent;
            this.radioButton16.Enabled = false;
            this.radioButton16.Location = new System.Drawing.Point(86, 4);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(14, 13);
            this.radioButton16.TabIndex = 2;
            this.radioButton16.TabStop = true;
            this.radioButton16.UseVisualStyleBackColor = false;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.BackColor = System.Drawing.Color.Transparent;
            this.radioButton17.Enabled = false;
            this.radioButton17.Location = new System.Drawing.Point(126, 4);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(14, 13);
            this.radioButton17.TabIndex = 4;
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = false;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.BackColor = System.Drawing.Color.Transparent;
            this.radioButton18.Enabled = false;
            this.radioButton18.Location = new System.Drawing.Point(106, 4);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(14, 13);
            this.radioButton18.TabIndex = 3;
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel15.Controls.Add(this.radioButton75);
            this.panel15.Controls.Add(this.radioButton76);
            this.panel15.Controls.Add(this.radioButton77);
            this.panel15.Controls.Add(this.radioButton78);
            this.panel15.Controls.Add(this.radioButton79);
            this.panel15.Controls.Add(this.radioButton80);
            this.panel15.Controls.Add(this.radioButton81);
            this.panel15.Controls.Add(this.radioButton82);
            this.panel15.Location = new System.Drawing.Point(114, 252);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(164, 21);
            this.panel15.TabIndex = 19;
            this.panel15.Click += new System.EventHandler(this.Vpanel_onclick);
            this.panel15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vpanel_clicked);
            this.panel15.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_move);
            this.panel15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vpanel_mouse_up);
            // 
            // radioButton75
            // 
            this.radioButton75.AutoSize = true;
            this.radioButton75.BackColor = System.Drawing.Color.Transparent;
            this.radioButton75.Enabled = false;
            this.radioButton75.Location = new System.Drawing.Point(146, 4);
            this.radioButton75.Name = "radioButton75";
            this.radioButton75.Size = new System.Drawing.Size(14, 13);
            this.radioButton75.TabIndex = 5;
            this.radioButton75.TabStop = true;
            this.radioButton75.UseVisualStyleBackColor = false;
            // 
            // radioButton76
            // 
            this.radioButton76.AutoSize = true;
            this.radioButton76.BackColor = System.Drawing.Color.Transparent;
            this.radioButton76.Enabled = false;
            this.radioButton76.Location = new System.Drawing.Point(26, 4);
            this.radioButton76.Name = "radioButton76";
            this.radioButton76.Size = new System.Drawing.Size(14, 13);
            this.radioButton76.TabIndex = 7;
            this.radioButton76.TabStop = true;
            this.radioButton76.UseVisualStyleBackColor = false;
            // 
            // radioButton77
            // 
            this.radioButton77.AutoSize = true;
            this.radioButton77.BackColor = System.Drawing.Color.Transparent;
            this.radioButton77.Enabled = false;
            this.radioButton77.Location = new System.Drawing.Point(46, 4);
            this.radioButton77.Name = "radioButton77";
            this.radioButton77.Size = new System.Drawing.Size(14, 13);
            this.radioButton77.TabIndex = 0;
            this.radioButton77.TabStop = true;
            this.radioButton77.UseVisualStyleBackColor = false;
            // 
            // radioButton78
            // 
            this.radioButton78.AutoSize = true;
            this.radioButton78.BackColor = System.Drawing.Color.Transparent;
            this.radioButton78.Enabled = false;
            this.radioButton78.Location = new System.Drawing.Point(6, 4);
            this.radioButton78.Name = "radioButton78";
            this.radioButton78.Size = new System.Drawing.Size(14, 13);
            this.radioButton78.TabIndex = 6;
            this.radioButton78.TabStop = true;
            this.radioButton78.UseVisualStyleBackColor = false;
            // 
            // radioButton79
            // 
            this.radioButton79.AutoSize = true;
            this.radioButton79.BackColor = System.Drawing.Color.Transparent;
            this.radioButton79.Enabled = false;
            this.radioButton79.Location = new System.Drawing.Point(66, 4);
            this.radioButton79.Name = "radioButton79";
            this.radioButton79.Size = new System.Drawing.Size(14, 13);
            this.radioButton79.TabIndex = 1;
            this.radioButton79.TabStop = true;
            this.radioButton79.UseVisualStyleBackColor = false;
            // 
            // radioButton80
            // 
            this.radioButton80.AutoSize = true;
            this.radioButton80.BackColor = System.Drawing.Color.Transparent;
            this.radioButton80.Enabled = false;
            this.radioButton80.Location = new System.Drawing.Point(86, 4);
            this.radioButton80.Name = "radioButton80";
            this.radioButton80.Size = new System.Drawing.Size(14, 13);
            this.radioButton80.TabIndex = 2;
            this.radioButton80.TabStop = true;
            this.radioButton80.UseVisualStyleBackColor = false;
            // 
            // radioButton81
            // 
            this.radioButton81.AutoSize = true;
            this.radioButton81.BackColor = System.Drawing.Color.Transparent;
            this.radioButton81.Enabled = false;
            this.radioButton81.Location = new System.Drawing.Point(126, 4);
            this.radioButton81.Name = "radioButton81";
            this.radioButton81.Size = new System.Drawing.Size(14, 13);
            this.radioButton81.TabIndex = 4;
            this.radioButton81.TabStop = true;
            this.radioButton81.UseVisualStyleBackColor = false;
            // 
            // radioButton82
            // 
            this.radioButton82.AutoSize = true;
            this.radioButton82.BackColor = System.Drawing.Color.Transparent;
            this.radioButton82.Enabled = false;
            this.radioButton82.Location = new System.Drawing.Point(106, 4);
            this.radioButton82.Name = "radioButton82";
            this.radioButton82.Size = new System.Drawing.Size(14, 13);
            this.radioButton82.TabIndex = 3;
            this.radioButton82.TabStop = true;
            this.radioButton82.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 26);
            this.label15.TabIndex = 10;
            this.label15.Text = "*You can use commas and\r\n hyphens to chain rows.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Test";
            this.label9.Visible = false;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(65, 438);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 7;
            this.button18.Text = "Magic";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Visible = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(242, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "*";
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
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(200, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Horizontal";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(134, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Vertical";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
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
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ms";
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
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(140, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vertical";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(206, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Horizontal";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
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
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.button24);
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button23);
            this.tabPage3.Controls.Add(this.button26);
            this.tabPage3.Controls.Add(this.button27);
            this.tabPage3.Controls.Add(this.button25);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.button28);
            this.tabPage3.Controls.Add(this.fifty_cycles);
            this.tabPage3.Controls.Add(this.tencycles);
            this.tabPage3.Controls.Add(this.Five_Cycles);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.One_Cycle);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(738, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "    Demo     ";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(50, 91);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(267, 20);
            this.label26.TabIndex = 24;
            this.label26.Text = "Open Tray for 3 Seconds, Close Tray";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(376, 589);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(242, 20);
            this.label25.TabIndex = 23;
            this.label25.Text = "Fill Full Rack of Decapped Tubes";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(376, 489);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(208, 20);
            this.label24.TabIndex = 22;
            this.label24.Text = "Decap, Fill, Recap Full Rack";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(53, 489);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(208, 20);
            this.label23.TabIndex = 21;
            this.label23.Text = "Decap and Recap Full Rack";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(376, 387);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(317, 20);
            this.label22.TabIndex = 20;
            this.label22.Text = "Decap, Place on Tray, Fill, Recap Back Row";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(53, 387);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(290, 20);
            this.label21.TabIndex = 19;
            this.label21.Text = "Decap, Place on Tray, Recap Back Row";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(376, 282);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(319, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "Decap, Place on Tray, Fill, Recap Front Row";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(53, 282);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(292, 20);
            this.label19.TabIndex = 17;
            this.label19.Text = "Decap, Place on Tray, Recap Front Row";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(376, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(247, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Decap, Fill, and Recap Front Row";
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(378, 230);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(319, 49);
            this.button24.TabIndex = 5;
            this.button24.Text = "Fill Demo 2";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(378, 128);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(317, 49);
            this.button13.TabIndex = 3;
            this.button13.Text = "Fill Demo 1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(54, 230);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(317, 49);
            this.button10.TabIndex = 4;
            this.button10.Text = "Cap Demo 2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(54, 128);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(318, 49);
            this.button23.TabIndex = 2;
            this.button23.Text = "Cap Demo 1";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(378, 335);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(319, 49);
            this.button26.TabIndex = 7;
            this.button26.Text = "Fill Demo 3";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(378, 437);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(319, 49);
            this.button27.TabIndex = 9;
            this.button27.Text = "Fill Demo 4";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(54, 335);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(318, 49);
            this.button25.TabIndex = 6;
            this.button25.Text = "Cap Demo 3";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(54, 437);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(316, 49);
            this.button12.TabIndex = 8;
            this.button12.Text = "Cap Demo 4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(53, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(216, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Decap and Recap Front Row";
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(380, 537);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(317, 49);
            this.button28.TabIndex = 10;
            this.button28.Text = "Fill Demo 5";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // fifty_cycles
            // 
            this.fifty_cycles.AutoSize = true;
            this.fifty_cycles.Location = new System.Drawing.Point(614, 15);
            this.fifty_cycles.Name = "fifty_cycles";
            this.fifty_cycles.Size = new System.Drawing.Size(71, 17);
            this.fifty_cycles.TabIndex = 14;
            this.fifty_cycles.TabStop = true;
            this.fifty_cycles.Text = "50 Cycles";
            this.fifty_cycles.UseVisualStyleBackColor = true;
            this.fifty_cycles.CheckedChanged += new System.EventHandler(this.fifty_cycles_CheckedChanged);
            // 
            // tencycles
            // 
            this.tencycles.AutoSize = true;
            this.tencycles.Location = new System.Drawing.Point(537, 15);
            this.tencycles.Name = "tencycles";
            this.tencycles.Size = new System.Drawing.Size(71, 17);
            this.tencycles.TabIndex = 13;
            this.tencycles.TabStop = true;
            this.tencycles.Text = "10 Cycles";
            this.tencycles.UseVisualStyleBackColor = true;
            this.tencycles.CheckedChanged += new System.EventHandler(this.tencycles_CheckedChanged);
            // 
            // Five_Cycles
            // 
            this.Five_Cycles.AutoSize = true;
            this.Five_Cycles.Location = new System.Drawing.Point(466, 15);
            this.Five_Cycles.Name = "Five_Cycles";
            this.Five_Cycles.Size = new System.Drawing.Size(65, 17);
            this.Five_Cycles.TabIndex = 12;
            this.Five_Cycles.TabStop = true;
            this.Five_Cycles.Text = "5 Cycles";
            this.Five_Cycles.UseVisualStyleBackColor = true;
            this.Five_Cycles.CheckedChanged += new System.EventHandler(this.Five_Cycles_CheckedChanged);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(54, 46);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(641, 42);
            this.button11.TabIndex = 1;
            this.button11.Text = "Tray Demo";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // One_Cycle
            // 
            this.One_Cycle.AutoSize = true;
            this.One_Cycle.Location = new System.Drawing.Point(400, 15);
            this.One_Cycle.Name = "One_Cycle";
            this.One_Cycle.Size = new System.Drawing.Size(60, 17);
            this.One_Cycle.TabIndex = 11;
            this.One_Cycle.TabStop = true;
            this.One_Cycle.Text = "1 Cycle";
            this.One_Cycle.UseVisualStyleBackColor = true;
            this.One_Cycle.CheckedChanged += new System.EventHandler(this.One_Cycle_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.Warning);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(738, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Capping Commands";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 587);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 26);
            this.label13.TabIndex = 11;
            this.label13.Text = "*You can use commas and\r\n hyphens to chain rows.";
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.Location = new System.Drawing.Point(467, 160);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(50, 13);
            this.Warning.TabIndex = 9;
            this.Warning.Text = "Warning:";
            this.Warning.Visible = false;
            this.Warning.Click += new System.EventHandler(this.Warning_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Location = new System.Drawing.Point(6, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 132);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Row Cap/Decap";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(243, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "*";
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
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(200, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(72, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Horizontal";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Location = new System.Drawing.Point(134, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(60, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Vertical";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Visible = false;
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
            this.radioButton7.Enabled = false;
            this.radioButton7.Location = new System.Drawing.Point(140, 47);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(60, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Vertical";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Visible = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Enabled = false;
            this.radioButton8.Location = new System.Drawing.Point(206, 47);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(72, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Horizontal";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Visible = false;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.hiddenPanel);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(738, 614);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tool Info Page";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // hiddenPanel
            // 
            this.hiddenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenPanel.BackColor = System.Drawing.Color.Transparent;
            this.hiddenPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hiddenPanel.Enabled = false;
            this.hiddenPanel.Location = new System.Drawing.Point(453, 81);
            this.hiddenPanel.Name = "hiddenPanel";
            this.hiddenPanel.Size = new System.Drawing.Size(19, 14);
            this.hiddenPanel.TabIndex = 26;
            this.hiddenPanel.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 224);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tool List";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(27, 41);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 26);
            this.label28.TabIndex = 1;
            this.label28.Text = "Tool";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(208, 135);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(93, 26);
            this.label31.TabIndex = 7;
            this.label31.Text = "Micronic";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(27, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(51, 26);
            this.label27.TabIndex = 0;
            this.label27.Text = "Hex";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(208, 185);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(70, 26);
            this.label32.TabIndex = 6;
            this.label32.Text = "Fluidx";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(27, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 26);
            this.label29.TabIndex = 2;
            this.label29.Text = "Star";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(208, 41);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 26);
            this.label33.TabIndex = 5;
            this.label33.Text = "Labware";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(27, 135);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 26);
            this.label30.TabIndex = 3;
            this.label30.Text = "SQ";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(208, 83);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(71, 26);
            this.label34.TabIndex = 4;
            this.label34.Text = "Matrix";
            // 
            // Com_Select
            // 
            this.Com_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Com_Select.Location = new System.Drawing.Point(442, 660);
            this.Com_Select.Name = "Com_Select";
            this.Com_Select.Size = new System.Drawing.Size(56, 20);
            this.Com_Select.TabIndex = 10;
            this.Com_Select.TextChanged += new System.EventHandler(this.Com_Select_TextChanged);
            this.Com_Select.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Com_Select_KeyPress);
            // 
            // Com_selection
            // 
            this.Com_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Com_selection.AutoSize = true;
            this.Com_selection.Location = new System.Drawing.Point(402, 663);
            this.Com_selection.Name = "Com_selection";
            this.Com_selection.Size = new System.Drawing.Size(34, 13);
            this.Com_selection.TabIndex = 9;
            this.Com_selection.Text = "COM:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(401, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect to XL AutoCap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Connect_to_Machine_Click_1);
            // 
            // status_report
            // 
            this.status_report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_report.AutoSize = true;
            this.status_report.Location = new System.Drawing.Point(1, 1);
            this.status_report.Name = "status_report";
            this.status_report.Size = new System.Drawing.Size(16, 13);
            this.status_report.TabIndex = 1;
            this.status_report.Text = "   ";
            this.status_report.Click += new System.EventHandler(this.status_report_Click);
            // 
            // progress_report
            // 
            this.progress_report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress_report.AutoSize = true;
            this.progress_report.Location = new System.Drawing.Point(1, 1);
            this.progress_report.Name = "progress_report";
            this.progress_report.Size = new System.Drawing.Size(16, 13);
            this.progress_report.TabIndex = 2;
            this.progress_report.Text = "   ";
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stop_Button.Enabled = false;
            this.Stop_Button.Location = new System.Drawing.Point(28, 661);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 44);
            this.Stop_Button.TabIndex = 1;
            this.Stop_Button.Text = "Stop Current Process";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Visible = false;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.status_report);
            this.panel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel3.Location = new System.Drawing.Point(469, 660);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 20);
            this.panel3.TabIndex = 25;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.progress_report);
            this.panel4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel4.Location = new System.Drawing.Point(469, 687);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 20);
            this.panel4.TabIndex = 26;
            this.panel4.Visible = false;
            // 
            // button30
            // 
            this.button30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button30.Enabled = false;
            this.button30.Location = new System.Drawing.Point(109, 661);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 44);
            this.button30.TabIndex = 2;
            this.button30.Text = "Stop Demo After Cycle";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Visible = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(78, 3);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 5;
            this.button29.Text = "Strip";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button32
            // 
            this.button32.Enabled = false;
            this.button32.Location = new System.Drawing.Point(78, 27);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(75, 23);
            this.button32.TabIndex = 6;
            this.button32.Text = "Tray In";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Visible = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button31
            // 
            this.button31.Enabled = false;
            this.button31.Location = new System.Drawing.Point(2, 27);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(75, 23);
            this.button31.TabIndex = 4;
            this.button31.Text = "Tray Out";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Visible = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(2, 3);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 23);
            this.button33.TabIndex = 3;
            this.button33.Text = "CM";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.button33);
            this.panel5.Controls.Add(this.button31);
            this.panel5.Controls.Add(this.button32);
            this.panel5.Controls.Add(this.button29);
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(190, 655);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 54);
            this.panel5.TabIndex = 15;
            this.panel5.Visible = false;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(25, 713);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 13);
            this.label35.TabIndex = 28;
            this.label35.Text = "           ";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(6, 42);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(60, 17);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.Text = "Vertical";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(72, 17);
            this.radioButton10.TabIndex = 7;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Horizontal";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.radioButton9);
            this.groupBox6.Controls.Add(this.radioButton10);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(353, 653);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(110, 66);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rack Orientation";
            this.groupBox6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 732);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Com_Select);
            this.Controls.Add(this.Com_selection);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "XL AutoCap Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private Button button11;
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
        private Label label11;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label13;
        private Label label17;
        private Button button26;
        private Button button27;
        private Button button25;
        private Button button12;
        private Button button28;
        private Button button24;
        private Button button13;
        private Button button10;
        private Button button23;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label25;
        private Label label26;
        private Panel panel3;
        private Panel panel4;
        private TabPage tabPage5;
        private Label label27;
        private Label label28;
        private Label label30;
        private Label label29;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private GroupBox groupBox5;
        private Button button30;
        private Button button29;
        private Button button32;
        private Button button31;
        private Button button33;
        private Panel panel5;
        private Label label35;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private GroupBox groupBox6;
        private Panel panel6;
        private Panel panel15;
        private RadioButton radioButton75;
        private RadioButton radioButton76;
        private RadioButton radioButton77;
        private RadioButton radioButton78;
        private RadioButton radioButton79;
        private RadioButton radioButton80;
        private RadioButton radioButton81;
        private RadioButton radioButton82;
        private Panel panel8;
        private RadioButton radioButton19;
        private RadioButton radioButton20;
        private RadioButton radioButton21;
        private RadioButton radioButton22;
        private RadioButton radioButton23;
        private RadioButton radioButton24;
        private RadioButton radioButton25;
        private RadioButton radioButton26;
        private Panel panel9;
        private RadioButton radioButton27;
        private RadioButton radioButton28;
        private RadioButton radioButton29;
        private RadioButton radioButton30;
        private RadioButton radioButton31;
        private RadioButton radioButton32;
        private RadioButton radioButton33;
        private RadioButton radioButton34;
        private Panel panel7;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private RadioButton radioButton13;
        private RadioButton radioButton14;
        private RadioButton radioButton15;
        private RadioButton radioButton16;
        private RadioButton radioButton17;
        private RadioButton radioButton18;
        private Panel panel10;
        private RadioButton radioButton35;
        private RadioButton radioButton36;
        private RadioButton radioButton37;
        private RadioButton radioButton38;
        private RadioButton radioButton39;
        private RadioButton radioButton40;
        private RadioButton radioButton41;
        private RadioButton radioButton42;
        private Panel panel11;
        private RadioButton radioButton43;
        private RadioButton radioButton44;
        private RadioButton radioButton45;
        private RadioButton radioButton46;
        private RadioButton radioButton47;
        private RadioButton radioButton48;
        private RadioButton radioButton49;
        private RadioButton radioButton50;
        private Panel panel12;
        private RadioButton radioButton51;
        private RadioButton radioButton52;
        private RadioButton radioButton53;
        private RadioButton radioButton54;
        private RadioButton radioButton55;
        private RadioButton radioButton56;
        private RadioButton radioButton57;
        private RadioButton radioButton58;
        private Panel panel13;
        private RadioButton radioButton59;
        private RadioButton radioButton60;
        private RadioButton radioButton61;
        private RadioButton radioButton62;
        private RadioButton radioButton63;
        private RadioButton radioButton64;
        private RadioButton radioButton65;
        private RadioButton radioButton66;
        private Panel panel14;
        private RadioButton radioButton67;
        private RadioButton radioButton68;
        private RadioButton radioButton69;
        private RadioButton radioButton70;
        private RadioButton radioButton71;
        private RadioButton radioButton72;
        private RadioButton radioButton73;
        private RadioButton radioButton74;
        private Panel panel16;
        private RadioButton radioButton83;
        private RadioButton radioButton84;
        private RadioButton radioButton85;
        private RadioButton radioButton86;
        private RadioButton radioButton87;
        private RadioButton radioButton88;
        private RadioButton radioButton89;
        private RadioButton radioButton90;
        private Panel panel17;
        private RadioButton radioButton91;
        private RadioButton radioButton92;
        private RadioButton radioButton93;
        private RadioButton radioButton94;
        private RadioButton radioButton95;
        private RadioButton radioButton96;
        private RadioButton radioButton97;
        private RadioButton radioButton98;
        private Panel panel18;
        private RadioButton radioButton99;
        private RadioButton radioButton100;
        private RadioButton radioButton101;
        private RadioButton radioButton102;
        private RadioButton radioButton103;
        private RadioButton radioButton104;
        private RadioButton radioButton105;
        private RadioButton radioButton106;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox4;
        private Panel panel19;
        private RadioButton radioButton115;
        private RadioButton radioButton107;
        private RadioButton radioButton116;
        private RadioButton radioButton117;
        private RadioButton radioButton108;
        private RadioButton radioButton118;
        private RadioButton radioButton109;
        private RadioButton radioButton110;
        private RadioButton radioButton111;
        private RadioButton radioButton112;
        private RadioButton radioButton113;
        private RadioButton radioButton114;
        private Panel panel23;
        private RadioButton radioButton155;
        private RadioButton radioButton156;
        private RadioButton radioButton157;
        private RadioButton radioButton158;
        private RadioButton radioButton159;
        private RadioButton radioButton160;
        private RadioButton radioButton161;
        private RadioButton radioButton162;
        private RadioButton radioButton163;
        private RadioButton radioButton164;
        private RadioButton radioButton165;
        private RadioButton radioButton166;
        private Panel panel24;
        private RadioButton radioButton167;
        private RadioButton radioButton168;
        private RadioButton radioButton169;
        private RadioButton radioButton170;
        private RadioButton radioButton171;
        private RadioButton radioButton172;
        private RadioButton radioButton173;
        private RadioButton radioButton174;
        private RadioButton radioButton175;
        private RadioButton radioButton176;
        private RadioButton radioButton177;
        private RadioButton radioButton178;
        private Panel panel25;
        private RadioButton radioButton179;
        private RadioButton radioButton180;
        private RadioButton radioButton181;
        private RadioButton radioButton182;
        private RadioButton radioButton183;
        private RadioButton radioButton184;
        private RadioButton radioButton185;
        private RadioButton radioButton186;
        private RadioButton radioButton187;
        private RadioButton radioButton188;
        private RadioButton radioButton189;
        private RadioButton radioButton190;
        private Panel panel26;
        private RadioButton radioButton191;
        private RadioButton radioButton192;
        private RadioButton radioButton193;
        private RadioButton radioButton194;
        private RadioButton radioButton195;
        private RadioButton radioButton196;
        private RadioButton radioButton197;
        private RadioButton radioButton198;
        private RadioButton radioButton199;
        private RadioButton radioButton200;
        private RadioButton radioButton201;
        private RadioButton radioButton202;
        private Panel panel21;
        private RadioButton radioButton131;
        private RadioButton radioButton132;
        private RadioButton radioButton133;
        private RadioButton radioButton134;
        private RadioButton radioButton135;
        private RadioButton radioButton136;
        private RadioButton radioButton137;
        private RadioButton radioButton138;
        private RadioButton radioButton139;
        private RadioButton radioButton140;
        private RadioButton radioButton141;
        private RadioButton radioButton142;
        private Panel panel22;
        private RadioButton radioButton143;
        private RadioButton radioButton144;
        private RadioButton radioButton145;
        private RadioButton radioButton146;
        private RadioButton radioButton147;
        private RadioButton radioButton148;
        private RadioButton radioButton149;
        private RadioButton radioButton150;
        private RadioButton radioButton151;
        private RadioButton radioButton152;
        private RadioButton radioButton153;
        private RadioButton radioButton154;
        private Panel panel20;
        private RadioButton radioButton119;
        private RadioButton radioButton120;
        private RadioButton radioButton121;
        private RadioButton radioButton122;
        private RadioButton radioButton123;
        private RadioButton radioButton124;
        private RadioButton radioButton125;
        private RadioButton radioButton126;
        private RadioButton radioButton127;
        private RadioButton radioButton128;
        private RadioButton radioButton129;
        private RadioButton radioButton130;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox19;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private Panel panel27;
        private CheckBox checkBox14;
        private Label label36;
        private Panel hiddenPanel;
        private Label label37;
        private Label label38;

    }


}

