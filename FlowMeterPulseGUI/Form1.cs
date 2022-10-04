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
using EasyModbus;


namespace FlowMeterPulseGUI
{
    public partial class Form1 : Form
    {
        ModbusClient Modclient;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxcomport.Text = Properties.Settings.Default.com_port;
            comboBoxbaudrate.Text = Convert.ToString(Properties.Settings.Default.baud_rate);
            comboBoxParity.Text = Properties.Settings.Default.parity_bit;
            textBoxinterval.Text = Convert.ToString(Properties.Settings.Default.time_interval);
            textBoxslaveID.Text = Convert.ToString(Properties.Settings.Default.slave_id_1);
            String[] ports = SerialPort.GetPortNames();
            comboBoxcomport.Items.AddRange(ports);
            connect_modbus();
            groupBox3.Enabled = false;
        }
        private void connect_modbus()
        {
            Modclient = new ModbusClient(Properties.Settings.Default.com_port);
            Modclient.Baudrate = Convert.ToInt32(comboBoxbaudrate.Text);
            if(Properties.Settings.Default.parity_bit == "none")
            {
                Modclient.Parity = System.IO.Ports.Parity.None;
            }
            else if(Properties.Settings.Default.parity_bit == "even")
            {
                Modclient.Parity = System.IO.Ports.Parity.Even;
            }
            else if(Properties.Settings.Default.parity_bit == "odd")
            {
                Modclient.Parity = System.IO.Ports.Parity.Odd;
            }
            try
            {
                Modclient.Connect();
                timer1.Interval = Convert.ToInt32(Properties.Settings.Default.time_interval);
                toolStripStatusLabel1.Text = "Connected modbus COM:"+ Properties.Settings.Default.com_port + ", interval:" + Convert.ToString(timer1.Interval);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error! Disconnected Comport";
            }
        }
        private void button_save_comport_Click(object sender, EventArgs e)
        {
            Modclient.Disconnect();
            Properties.Settings.Default.com_port = comboBoxcomport.Text;
            Properties.Settings.Default.baud_rate = Convert.ToInt32(comboBoxbaudrate.Text);
            Properties.Settings.Default.parity_bit = comboBoxParity.Text;
            Properties.Settings.Default.slave_id_1 = Convert.ToInt32(textBoxslaveID.Text);
            Properties.Settings.Default.time_interval = Convert.ToInt32(textBoxinterval.Text);
            toolStripStatusLabel1.Text = "Serial Port:" + Properties.Settings.Default.com_port + ", Baudrate:" + Convert.ToInt32(comboBoxbaudrate.Text)+ ", Parity:" + Properties.Settings.Default.parity_bit + ", ID:" + Convert.ToInt32(textBoxslaveID.Text) + ", Time Interval:" + Convert.ToInt32(textBoxinterval.Text) + " save sukses";
        }

        private void button_cancel_comport_Click(object sender, EventArgs e)
        {
            Modclient.Disconnect();
            comboBoxcomport.Text = Properties.Settings.Default.com_port;
            comboBoxbaudrate.Text = Convert.ToString(Properties.Settings.Default.baud_rate);
            comboBoxParity.Text = Properties.Settings.Default.parity_bit;
            textBoxinterval.Text = Convert.ToString(Properties.Settings.Default.time_interval);
            textBoxslaveID.Text = Convert.ToString(Properties.Settings.Default.slave_id_1);
            toolStripStatusLabel1.Text = "Com Port Setting Cancled";
        }
        int count_poll = 0;
        int[] vals;
        private void timer1_Tick(object sender, EventArgs e)
        {
            bool connected_modbus = Modclient.Connected;
            if (connected_modbus)
            {
                Modclient.UnitIdentifier = Convert.ToByte(Properties.Settings.Default.slave_id_1);
                try
                {
                    vals = Modclient.ReadHoldingRegisters(0, 11);
                    double total_of_liter1 = ConvertDW2FloatSwap(Convert.ToInt16(vals[0]), Convert.ToInt16(vals[1]));
                    double total_of_cubic1 = ConvertDW2FloatSwap(Convert.ToInt16(vals[2]), Convert.ToInt16(vals[3]));
                    double liter_per_menit1 = ConvertDW2FloatSwap(Convert.ToInt16(vals[4]), Convert.ToInt16(vals[5]));
                    double setpoint_data1 = ConvertDW2FloatSwap(Convert.ToInt16(vals[6]), Convert.ToInt16(vals[7]));
                    double current_liter1 = ConvertDW2FloatSwap(Convert.ToInt16(vals[8]), Convert.ToInt16(vals[9]));
                    textBoxLiter1.Text = total_of_liter1.ToString();
                    textBoxvolumem3_1.Text = total_of_cubic1.ToString();
                    textBoxflowrate1.Text = liter_per_menit1.ToString();
                    if(textBoxSetpoint1.Modified == true)
                    {
                        toolStripStatusLabel1.Text = "edit setpoint 1";
                    }
                    else if(textBoxSetpoint1.Modified == false)
                    {
                        textBoxSetpoint1.Text = setpoint_data1.ToString();
                        toolStripStatusLabel1.Text = "no edit setpoint 1";
                    }
                    textBoxvolumeair1.Text = current_liter1.ToString();

                    /*                    double total_of_liter2 = ConvertDW2Float(Convert.ToInt16(vals[8]), Convert.ToInt16(vals[9]));
                                        double total_of_cubic2 = ConvertDW2Float(Convert.ToInt16(vals[10]), Convert.ToInt16(vals[11]));
                                        double liter_per_menit2 = ConvertDW2Float(Convert.ToInt16(vals[12]), Convert.ToInt16(vals[13]));
                                        double setpoint_data2 = ConvertDW2Float(Convert.ToInt16(vals[14]), Convert.ToInt16(vals[15]));
                                        double current_liter2 = ConvertDW2Float(Convert.ToInt16(vals[18]), Convert.ToInt16(vals[19]));

                                        textBoxLiter2.Text = total_of_liter2.ToString();
                                        textBox4volumem3_2.Text = total_of_cubic2.ToString();
                                        textBoxflowrate2.Text = liter_per_menit2.ToString();
                                        if(textBoxSetpoint2.Modified == true)
                                        {
                                            toolStripStatusLabel1.Text = "edit setpoint2";
                                        }
                                        else if(textBoxSetpoint2.Modified == false)
                                        {
                                            textBoxSetpoint2.Text = setpoint_data2.ToString();
                                            toolStripStatusLabel1.Text = "no edit setpoint2";
                                        }
                                        textBoxvolumeair1.Text = current_liter1.ToString();
                                        textBox2volumeair2.Text = current_liter2.ToString();*/


                    if (vals[10] == 1)
                    {
                        radioButtonmotor1.Checked = true;
                    }
                    else if(vals[10] == 0)
                    {
                        radioButtonmotor1.Checked = false;
                    }
/*                    if (vals[21] == 1)
                    {
                        radioButtonmotor2.Checked = true;
                    }
                    else if (vals[21] == 0)
                    {
                        radioButtonmotor2.Checked = false;
                    }*/

                    count_poll += 1;
                    textBoxcountpoll.Text = Convert.ToString(count_poll);
                    if(count_poll >= 1000)
                    {
                        count_poll = 0;
                    }
                }
                catch(Exception ex)
                {
                    toolStripStatusLabel1.Text = "Error! " + ex.Message.ToString();
                }
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
            }
            else
            {
                connect_modbus();
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }
        }
        private double ConvertDW2FloatSwap(short int1, short int2)
        {
            byte[] intBytes1 = BitConverter.GetBytes(int1);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes1);
            byte[] result1 = intBytes1;
            byte[] intBytes2 = BitConverter.GetBytes(int2);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes2);
            byte[] result2 = intBytes2;
            byte[] _bytes = new byte[4];
            _bytes[0] = intBytes2[1];
            _bytes[1] = intBytes2[0];
            _bytes[2] = intBytes1[1];
            _bytes[3] = intBytes1[0];
            double _val = BitConverter.ToSingle(_bytes, 0);
            _val = Math.Round(_val, 3);

            return _val;
        }
        private short[] ConvertFloat2DWSwap(float fVal)
        {
            byte[] byVals = BitConverter.GetBytes(fVal);
            if (BitConverter.IsLittleEndian) { Array.Reverse(byVals); }

            byte[] bytes1 = { byVals[1], byVals[0] };
            short int1 = BitConverter.ToInt16(bytes1, 0);
            byte[] bytes2 = { byVals[3], byVals[2] };
            short int2 = BitConverter.ToInt16(bytes2, 0);

            short[] values = new short[2];
            values[0] = int1; values[1] = int2;

            return values;
        }

        private void button1_senddata1_Click(object sender, EventArgs e)
        {
            try
            {
                float sendsetpoint1 = float.Parse(textBoxSetpoint1.Text);
                short[] svals = ConvertFloat2DWSwap(sendsetpoint1);
                int[] vals = new int[2];
                vals[0] = svals[0];
                vals[1] = svals[1];
                Modclient.WriteMultipleRegisters(6, vals);
                toolStripStatusLabel1.Text = "setpoint data 1 Sudah dikirim" + vals[0].ToString() + "." + vals[1].ToString();
                textBoxSetpoint1.Modified = false;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "isi dulu setpoint data 1 yang akan di kirim";
            }
        }

        private void button1_senddata2_Click(object sender, EventArgs e)
        {
            try
            {
                float sendsetpoint2 = float.Parse(textBoxSetpoint2.Text);
                short[] svals = ConvertFloat2DWSwap(sendsetpoint2);
                int[] vals = new int[2];
                vals[0] = svals[0];
                vals[1] = svals[1];
                Modclient.WriteMultipleRegisters(6, vals);
                toolStripStatusLabel1.Text = "setpoint data 2 Sudah dikirim";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "isi dulu setpoint data 2 yang akan di kirim";
            }
        }
    }
}
