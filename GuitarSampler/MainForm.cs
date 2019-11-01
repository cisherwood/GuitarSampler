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

            /*
            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");
            }
            
             
            // Display All ASIO Drivers
            foreach (var asio in AsioOut.GetDriverNames())
            {
                Console.WriteLine(asio);
            }

            
            for (int n = -1; n < WaveIn.DeviceCount; n++)
            {
                var caps = WaveIn.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");
            }
             
             */

            try
            {
                // Audio capture settings
                var recordChannelCount = 1; // record one channel
                var sampleRate = 96000; // 96kh


                var waveIn = new WaveIn() { DeviceNumber = 0 };
                waveIn.WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, 1);

                // Set asio driver (for home computer Focusrite interface)
                // string asioDriverName = "Focusrite USB ASIO";

                // Construct asio out driver
                // var asioOut = new AsioOut(asioDriverName);


                // Get input channels
                // var inputChannels = asioOut.DriverInputChannelCount;




                // Get output folder
                var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NAudio");
                Directory.CreateDirectory(outputFolder);
                // Set file name
                var outputFilePath = Path.Combine(outputFolder, "recorded.wav");

                // Flag used to stop recording when app is closed
                bool closing = false;
                var f = new Form();

                // asioOut.InputChannelOffset = 0; // audio from first input(zero based, input 1 = 0, input 2 = 1)

                // asioOut.InitRecordAndPlayback(null, recordChannelCount, sampleRate);

                // File writer
                // WaveFileWriter writer = null;
                WaveFileWriter writer = null;
                WaveFileWriter outputWriter = null;
                WaveFormat outputFileFormat = new WaveFormat(sampleRate, 32, recordChannelCount);

                short maxValue = 0;



                InitializeComponent();

                recordButton.Click += (s, a) =>
                {
                    writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
                    // Begin capturing (recording) 
                    waveIn.StartRecording(); // start recording
                    recordButton.Enabled = false;
                    stopButton.Enabled = true;
                    maxValue = 0;
                    
                };

                stopButton.Click += (s, a) => waveIn.StopRecording();


                waveIn.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                    if (writer.Position > waveIn.WaveFormat.AverageBytesPerSecond * 30)
                    {
                        waveIn.StopRecording();
                    }


                    // Volume meter logic
                    float max = 0;
                    var buffer = new WaveBuffer(a.Buffer);
                    // interpret as 32 bit floating point audio
                    for (int index = 0; index < a.BytesRecorded / 4; index++)
                    {
                        var sample = buffer.FloatBuffer[index];

                        // absolute value 
                        if (sample < 0) sample = -sample;
                        // is this the max value?
                        if (sample > max) max = sample;
                    }

                    // stores peak value 
                    short currentValue = Convert.ToInt16(100 * max);
                    // Update volume meter
                    // volumeMeter1.Value = currentValue;
                    // Update peak text value
                    if (currentValue > maxValue)
                    {

                        // volumeDB.Text = ("-" + ((100 - (100 * max)).ToString("F")));
                        volumeDB.Text = (20 * Math.Log10(max)).ToString("F");
                        maxValue = currentValue;
                    }
                };

                waveIn.RecordingStopped += (s, a) =>
                {
                    writer?.Dispose();
                    writer = null;
                    recordButton.Enabled = true;
                    stopButton.Enabled = false;
                    if (closing)
                    {
                        waveIn.Dispose();
                    }
                };

                f.FormClosing += (s, a) => { closing = true; waveIn.StopRecording(); };

            }
            catch
            {

            }





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

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void RecordButton_Click(object sender, EventArgs e)
        {

        }

        private void VolumeMeter_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
