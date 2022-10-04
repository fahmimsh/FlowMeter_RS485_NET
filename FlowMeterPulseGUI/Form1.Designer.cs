
namespace FlowMeterPulseGUI
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxcomport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxbaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelparity = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.button_cancel_comport = new System.Windows.Forms.Button();
            this.button_save_comport = new System.Windows.Forms.Button();
            this.textBoxinterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxslaveID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1_senddata1 = new System.Windows.Forms.Button();
            this.textBoxSetpoint1 = new System.Windows.Forms.TextBox();
            this.radioButtonmotor1 = new System.Windows.Forms.RadioButton();
            this.labelliter_setpoint = new System.Windows.Forms.Label();
            this.labelsetpoint1 = new System.Windows.Forms.Label();
            this.labelliter = new System.Windows.Forms.Label();
            this.textBoxvolumeair1 = new System.Windows.Forms.TextBox();
            this.label6volumeair1 = new System.Windows.Forms.Label();
            this.labellpm1 = new System.Windows.Forms.Label();
            this.textBoxflowrate1 = new System.Windows.Forms.TextBox();
            this.labelflowrate1 = new System.Windows.Forms.Label();
            this.labelm3_1 = new System.Windows.Forms.Label();
            this.textBoxvolumem3_1 = new System.Windows.Forms.TextBox();
            this.textBoxLiter1 = new System.Windows.Forms.TextBox();
            this.labeltotalvolume1 = new System.Windows.Forms.Label();
            this.labeltotal_liter1 = new System.Windows.Forms.Label();
            this.labelcountpoll = new System.Windows.Forms.Label();
            this.textBoxcountpoll = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1_senddata2 = new System.Windows.Forms.Button();
            this.textBoxSetpoint2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonmotor2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2volumeair2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxflowrate2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4volumem3_2 = new System.Windows.Forms.TextBox();
            this.textBoxLiter2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxcomport
            // 
            this.comboBoxcomport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxcomport.FormattingEnabled = true;
            this.comboBoxcomport.Location = new System.Drawing.Point(78, 20);
            this.comboBoxcomport.Name = "comboBoxcomport";
            this.comboBoxcomport.Size = new System.Drawing.Size(104, 24);
            this.comboBoxcomport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port";
            // 
            // comboBoxbaudrate
            // 
            this.comboBoxbaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxbaudrate.FormattingEnabled = true;
            this.comboBoxbaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.comboBoxbaudrate.Location = new System.Drawing.Point(78, 50);
            this.comboBoxbaudrate.Name = "comboBoxbaudrate";
            this.comboBoxbaudrate.Size = new System.Drawing.Size(104, 24);
            this.comboBoxbaudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baudrate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelparity);
            this.groupBox1.Controls.Add(this.comboBoxParity);
            this.groupBox1.Controls.Add(this.button_cancel_comport);
            this.groupBox1.Controls.Add(this.button_save_comport);
            this.groupBox1.Controls.Add(this.textBoxinterval);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxslaveID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxcomport);
            this.groupBox1.Controls.Add(this.comboBoxbaudrate);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 228);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Info";
            // 
            // labelparity
            // 
            this.labelparity.AutoSize = true;
            this.labelparity.Location = new System.Drawing.Point(8, 84);
            this.labelparity.Name = "labelparity";
            this.labelparity.Size = new System.Drawing.Size(44, 17);
            this.labelparity.TabIndex = 11;
            this.labelparity.Text = "Parity";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "none",
            "even",
            "odd"});
            this.comboBoxParity.Location = new System.Drawing.Point(78, 80);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(104, 24);
            this.comboBoxParity.TabIndex = 10;
            // 
            // button_cancel_comport
            // 
            this.button_cancel_comport.Location = new System.Drawing.Point(105, 179);
            this.button_cancel_comport.Name = "button_cancel_comport";
            this.button_cancel_comport.Size = new System.Drawing.Size(77, 30);
            this.button_cancel_comport.TabIndex = 6;
            this.button_cancel_comport.Text = "Cancel";
            this.button_cancel_comport.UseVisualStyleBackColor = true;
            this.button_cancel_comport.Click += new System.EventHandler(this.button_cancel_comport_Click);
            // 
            // button_save_comport
            // 
            this.button_save_comport.Location = new System.Drawing.Point(6, 179);
            this.button_save_comport.Name = "button_save_comport";
            this.button_save_comport.Size = new System.Drawing.Size(93, 30);
            this.button_save_comport.TabIndex = 9;
            this.button_save_comport.Text = "Ok (Save)";
            this.button_save_comport.UseVisualStyleBackColor = true;
            this.button_save_comport.Click += new System.EventHandler(this.button_save_comport_Click);
            // 
            // textBoxinterval
            // 
            this.textBoxinterval.Location = new System.Drawing.Point(78, 138);
            this.textBoxinterval.Name = "textBoxinterval";
            this.textBoxinterval.Size = new System.Drawing.Size(104, 22);
            this.textBoxinterval.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Interval";
            // 
            // textBoxslaveID
            // 
            this.textBoxslaveID.Location = new System.Drawing.Point(78, 110);
            this.textBoxslaveID.Name = "textBoxslaveID";
            this.textBoxslaveID.Size = new System.Drawing.Size(104, 22);
            this.textBoxslaveID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Slave ID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 567);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1_senddata1);
            this.groupBox2.Controls.Add(this.textBoxSetpoint1);
            this.groupBox2.Controls.Add(this.radioButtonmotor1);
            this.groupBox2.Controls.Add(this.labelliter_setpoint);
            this.groupBox2.Controls.Add(this.labeltotal_liter1);
            this.groupBox2.Controls.Add(this.labelsetpoint1);
            this.groupBox2.Controls.Add(this.labelliter);
            this.groupBox2.Controls.Add(this.textBoxvolumeair1);
            this.groupBox2.Controls.Add(this.label6volumeair1);
            this.groupBox2.Controls.Add(this.labellpm1);
            this.groupBox2.Controls.Add(this.textBoxflowrate1);
            this.groupBox2.Controls.Add(this.labelflowrate1);
            this.groupBox2.Controls.Add(this.labelm3_1);
            this.groupBox2.Controls.Add(this.textBoxvolumem3_1);
            this.groupBox2.Controls.Add(this.textBoxLiter1);
            this.groupBox2.Controls.Add(this.labeltotalvolume1);
            this.groupBox2.Location = new System.Drawing.Point(215, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 325);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FLOW METER1";
            // 
            // button1_senddata1
            // 
            this.button1_senddata1.Location = new System.Drawing.Point(118, 243);
            this.button1_senddata1.Name = "button1_senddata1";
            this.button1_senddata1.Size = new System.Drawing.Size(104, 32);
            this.button1_senddata1.TabIndex = 27;
            this.button1_senddata1.Text = "Send Data";
            this.button1_senddata1.UseVisualStyleBackColor = true;
            this.button1_senddata1.Click += new System.EventHandler(this.button1_senddata1_Click);
            // 
            // textBoxSetpoint1
            // 
            this.textBoxSetpoint1.Location = new System.Drawing.Point(118, 207);
            this.textBoxSetpoint1.Name = "textBoxSetpoint1";
            this.textBoxSetpoint1.Size = new System.Drawing.Size(104, 22);
            this.textBoxSetpoint1.TabIndex = 26;
            // 
            // radioButtonmotor1
            // 
            this.radioButtonmotor1.AutoSize = true;
            this.radioButtonmotor1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonmotor1.Location = new System.Drawing.Point(20, 294);
            this.radioButtonmotor1.Name = "radioButtonmotor1";
            this.radioButtonmotor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonmotor1.Size = new System.Drawing.Size(144, 21);
            this.radioButtonmotor1.TabIndex = 24;
            this.radioButtonmotor1.Text = "     MOTOR PUMP";
            this.radioButtonmotor1.UseVisualStyleBackColor = true;
            // 
            // labelliter_setpoint
            // 
            this.labelliter_setpoint.AutoSize = true;
            this.labelliter_setpoint.Location = new System.Drawing.Point(231, 211);
            this.labelliter_setpoint.Name = "labelliter_setpoint";
            this.labelliter_setpoint.Size = new System.Drawing.Size(36, 17);
            this.labelliter_setpoint.TabIndex = 22;
            this.labelliter_setpoint.Text = "Liter";
            // 
            // labelsetpoint1
            // 
            this.labelsetpoint1.AutoSize = true;
            this.labelsetpoint1.Location = new System.Drawing.Point(6, 208);
            this.labelsetpoint1.Name = "labelsetpoint1";
            this.labelsetpoint1.Size = new System.Drawing.Size(102, 17);
            this.labelsetpoint1.TabIndex = 20;
            this.labelsetpoint1.Text = "Data Setpoint :";
            // 
            // labelliter
            // 
            this.labelliter.AutoSize = true;
            this.labelliter.Location = new System.Drawing.Point(227, 154);
            this.labelliter.Name = "labelliter";
            this.labelliter.Size = new System.Drawing.Size(36, 17);
            this.labelliter.TabIndex = 19;
            this.labelliter.Text = "Liter";
            // 
            // textBoxvolumeair1
            // 
            this.textBoxvolumeair1.Location = new System.Drawing.Point(118, 151);
            this.textBoxvolumeair1.Name = "textBoxvolumeair1";
            this.textBoxvolumeair1.Size = new System.Drawing.Size(104, 22);
            this.textBoxvolumeair1.TabIndex = 19;
            // 
            // label6volumeair1
            // 
            this.label6volumeair1.AutoSize = true;
            this.label6volumeair1.Location = new System.Drawing.Point(17, 154);
            this.label6volumeair1.Name = "label6volumeair1";
            this.label6volumeair1.Size = new System.Drawing.Size(96, 17);
            this.label6volumeair1.TabIndex = 18;
            this.label6volumeair1.Text = "Volume Air    :";
            // 
            // labellpm1
            // 
            this.labellpm1.AutoSize = true;
            this.labellpm1.Location = new System.Drawing.Point(228, 110);
            this.labellpm1.Name = "labellpm1";
            this.labellpm1.Size = new System.Drawing.Size(35, 17);
            this.labellpm1.TabIndex = 17;
            this.labellpm1.Text = "Lpm";
            // 
            // textBoxflowrate1
            // 
            this.textBoxflowrate1.Location = new System.Drawing.Point(118, 107);
            this.textBoxflowrate1.Name = "textBoxflowrate1";
            this.textBoxflowrate1.Size = new System.Drawing.Size(104, 22);
            this.textBoxflowrate1.TabIndex = 16;
            // 
            // labelflowrate1
            // 
            this.labelflowrate1.AutoSize = true;
            this.labelflowrate1.Location = new System.Drawing.Point(17, 110);
            this.labelflowrate1.Name = "labelflowrate1";
            this.labelflowrate1.Size = new System.Drawing.Size(98, 17);
            this.labelflowrate1.TabIndex = 15;
            this.labelflowrate1.Text = "Flow Rate      :";
            // 
            // labelm3_1
            // 
            this.labelm3_1.AutoSize = true;
            this.labelm3_1.Location = new System.Drawing.Point(228, 67);
            this.labelm3_1.Name = "labelm3_1";
            this.labelm3_1.Size = new System.Drawing.Size(27, 17);
            this.labelm3_1.TabIndex = 14;
            this.labelm3_1.Text = "m3";
            // 
            // textBoxvolumem3_1
            // 
            this.textBoxvolumem3_1.Location = new System.Drawing.Point(118, 65);
            this.textBoxvolumem3_1.Name = "textBoxvolumem3_1";
            this.textBoxvolumem3_1.Size = new System.Drawing.Size(104, 22);
            this.textBoxvolumem3_1.TabIndex = 13;
            // 
            // textBoxLiter1
            // 
            this.textBoxLiter1.Location = new System.Drawing.Point(118, 26);
            this.textBoxLiter1.Name = "textBoxLiter1";
            this.textBoxLiter1.Size = new System.Drawing.Size(104, 22);
            this.textBoxLiter1.TabIndex = 12;
            // 
            // labeltotalvolume1
            // 
            this.labeltotalvolume1.AutoSize = true;
            this.labeltotalvolume1.Location = new System.Drawing.Point(17, 27);
            this.labeltotalvolume1.Name = "labeltotalvolume1";
            this.labeltotalvolume1.Size = new System.Drawing.Size(99, 17);
            this.labeltotalvolume1.TabIndex = 12;
            this.labeltotalvolume1.Text = "Total Volume :";
            // 
            // labeltotal_liter1
            // 
            this.labeltotal_liter1.AutoSize = true;
            this.labeltotal_liter1.Location = new System.Drawing.Point(227, 29);
            this.labeltotal_liter1.Name = "labeltotal_liter1";
            this.labeltotal_liter1.Size = new System.Drawing.Size(36, 17);
            this.labeltotal_liter1.TabIndex = 13;
            this.labeltotal_liter1.Text = "Liter";
            // 
            // labelcountpoll
            // 
            this.labelcountpoll.AutoSize = true;
            this.labelcountpoll.Location = new System.Drawing.Point(12, 254);
            this.labelcountpoll.Name = "labelcountpoll";
            this.labelcountpoll.Size = new System.Drawing.Size(79, 17);
            this.labelcountpoll.TabIndex = 18;
            this.labelcountpoll.Text = "Count poll :";
            // 
            // textBoxcountpoll
            // 
            this.textBoxcountpoll.Location = new System.Drawing.Point(97, 251);
            this.textBoxcountpoll.Name = "textBoxcountpoll";
            this.textBoxcountpoll.Size = new System.Drawing.Size(104, 22);
            this.textBoxcountpoll.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1_senddata2);
            this.groupBox3.Controls.Add(this.textBoxSetpoint2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.radioButtonmotor2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox2volumeair2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxflowrate2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBox4volumem3_2);
            this.groupBox3.Controls.Add(this.textBoxLiter2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(496, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 323);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FLOW METER2";
            // 
            // button1_senddata2
            // 
            this.button1_senddata2.Location = new System.Drawing.Point(118, 241);
            this.button1_senddata2.Name = "button1_senddata2";
            this.button1_senddata2.Size = new System.Drawing.Size(104, 32);
            this.button1_senddata2.TabIndex = 28;
            this.button1_senddata2.Text = "Send Data";
            this.button1_senddata2.UseVisualStyleBackColor = true;
            this.button1_senddata2.Click += new System.EventHandler(this.button1_senddata2_Click);
            // 
            // textBoxSetpoint2
            // 
            this.textBoxSetpoint2.Location = new System.Drawing.Point(118, 208);
            this.textBoxSetpoint2.Name = "textBoxSetpoint2";
            this.textBoxSetpoint2.Size = new System.Drawing.Size(104, 22);
            this.textBoxSetpoint2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Liter";
            // 
            // radioButtonmotor2
            // 
            this.radioButtonmotor2.AutoSize = true;
            this.radioButtonmotor2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonmotor2.Location = new System.Drawing.Point(6, 292);
            this.radioButtonmotor2.Name = "radioButtonmotor2";
            this.radioButtonmotor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonmotor2.Size = new System.Drawing.Size(144, 21);
            this.radioButtonmotor2.TabIndex = 24;
            this.radioButtonmotor2.Text = "     MOTOR PUMP";
            this.radioButtonmotor2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Liter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data Setpoint :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Liter";
            // 
            // textBox2volumeair2
            // 
            this.textBox2volumeair2.Location = new System.Drawing.Point(118, 151);
            this.textBox2volumeair2.Name = "textBox2volumeair2";
            this.textBox2volumeair2.Size = new System.Drawing.Size(104, 22);
            this.textBox2volumeair2.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Volume Air    :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lpm";
            // 
            // textBoxflowrate2
            // 
            this.textBoxflowrate2.Location = new System.Drawing.Point(118, 107);
            this.textBoxflowrate2.Name = "textBoxflowrate2";
            this.textBoxflowrate2.Size = new System.Drawing.Size(104, 22);
            this.textBoxflowrate2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Flow Rate      :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "m3";
            // 
            // textBox4volumem3_2
            // 
            this.textBox4volumem3_2.Location = new System.Drawing.Point(118, 65);
            this.textBox4volumem3_2.Name = "textBox4volumem3_2";
            this.textBox4volumem3_2.Size = new System.Drawing.Size(104, 22);
            this.textBox4volumem3_2.TabIndex = 13;
            // 
            // textBoxLiter2
            // 
            this.textBoxLiter2.Location = new System.Drawing.Point(118, 26);
            this.textBoxLiter2.Name = "textBoxLiter2";
            this.textBoxLiter2.Size = new System.Drawing.Size(104, 22);
            this.textBoxLiter2.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total Volume :";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 207);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.labelcountpoll);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.textBoxcountpoll);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 360);
            this.panel2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1166, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "FlowMeterGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxcomport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxbaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxslaveID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxinterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_cancel_comport;
        private System.Windows.Forms.Button button_save_comport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelparity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLiter1;
        private System.Windows.Forms.Label labeltotalvolume1;
        private System.Windows.Forms.Label labeltotal_liter1;
        private System.Windows.Forms.Label labelm3_1;
        private System.Windows.Forms.TextBox textBoxvolumem3_1;
        private System.Windows.Forms.Label labelflowrate1;
        private System.Windows.Forms.TextBox textBoxflowrate1;
        private System.Windows.Forms.Label labellpm1;
        private System.Windows.Forms.Label labelcountpoll;
        private System.Windows.Forms.TextBox textBoxcountpoll;
        private System.Windows.Forms.Label label6volumeair1;
        private System.Windows.Forms.TextBox textBoxvolumeair1;
        private System.Windows.Forms.Label labelliter;
        private System.Windows.Forms.Label labelsetpoint1;
        private System.Windows.Forms.Label labelliter_setpoint;
        private System.Windows.Forms.RadioButton radioButtonmotor1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonmotor2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2volumeair2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxflowrate2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4volumem3_2;
        private System.Windows.Forms.TextBox textBoxLiter2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSetpoint1;
        private System.Windows.Forms.TextBox textBoxSetpoint2;
        private System.Windows.Forms.Button button1_senddata1;
        private System.Windows.Forms.Button button1_senddata2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

