using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GuitarSampler.NoteFinder;


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

        private void button1_Click(object sender, EventArgs e)
        {

            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            string fileURL;


            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                fileURL = this.openFileDialog1.FileName;
            }

            var OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            string settingsFile = OpenFile.ReadToEnd();
        }
    }
}
