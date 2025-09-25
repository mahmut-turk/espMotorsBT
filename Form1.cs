using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace espMotorsBT
{
    public partial class Form1 : Form
    {
        SerialPort serial;

        public Form1()
        {
            InitializeComponent();

            // Seri portu başlat (Bluetooth cihazın COM portu ile değiştir)
            serial = new SerialPort("COM11", 115200);
            serial.Open();
        }

        private void btnLed_Click(object sender, EventArgs e)
        {
            serial.WriteLine("L1"); // LED toggle
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serial.IsOpen) serial.Close();
        }

        private void btnStepForward_Click(object sender, EventArgs e)
        {
            serial.WriteLine("S+");
        }

        private void btnStepBackward_Click(object sender, EventArgs e)
        {
            serial.WriteLine("S-");
        }

        private void btnServo0_Click(object sender, EventArgs e)
        {
            serial.WriteLine("SV0");
        }

        private void btnServo90_Click(object sender, EventArgs e)
        {
            serial.WriteLine("SV90");
        }
    }
}
