using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarSampler
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");
            }

            for (int n = -1; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");
            }

            foreach (var asio in AsioOut.GetDriverNames())
            {
                Console.WriteLine(asio);
            }



            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
