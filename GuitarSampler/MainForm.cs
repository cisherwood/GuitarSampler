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

        // group settings
        string groupName;
        int numberOfGuitarStrings;
        int numberOfFrets;
        int numberOfVelocities;
        int numberOfRoundRobins;

        string previousNote;
        int previousGuitarString;
        int previousFret;
        int previousVelocityGroup;
        int previousRoundRobbin;

        int currentGuitarString;
        int currentFret;
        int currentVelocityGroup;
        int currentRoundRobbin;

        int recordingThreshold = -55;

        // flag to see if recording has started or not 
        // used for automatic recording and testin DB to threshold
        bool recordingHasStarted = false;


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




            if(previousVelocityGroup == 0)
            {
              //   current
            }


            for (int currentGuitarString = 666; currentGuitarString >= 1; currentGuitarString--)
            {
                // for(int current)
            }

            





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
                   
                    SetCurrentNote();
                    outputFilePath = Path.Combine(outputFolder, GetCurrentFileName());
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
                    // Calculate current db
                    var currentDb = (20 * Math.Log10(max));



                    // Check when to start capturing data
                    if(currentDb > recordingThreshold)
                    {
                        // Capture audio data
                        writer.Write(a.Buffer, 0, a.BytesRecorded);
                        if (writer.Position > waveIn.WaveFormat.AverageBytesPerSecond * 30)
                        {
                            waveIn.StopRecording();
                        }

                        // If flag hasnt been set to true, set it now
                        if (recordingHasStarted == false)
                        {
                            recordingHasStarted = true;
                        }

                    }
                    else
                    {
                        // If recording has started yet and dB level is low
                        if (recordingHasStarted)
                        {
                            // Write current recording to disk
                            writer?.Dispose();
                            writer = null;

                            UpdatePreviousNote();
                            SetCurrentNote();
                            outputFilePath = Path.Combine(outputFolder, GetCurrentFileName());
                            writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);

                            recordingHasStarted = false;

                        }
                        else 
                        {
                            // Do nothing (wait for input to be loud enough)
                        }
                    }


                    // Update volume meter
                    // volumeMeter1.Value = currentValue;
                    // Update peak text value

                    // Get current dB value in string
                    string currentDbString = currentDb.ToString("F");





                    // Update GUI
                    volumeDB.Text = currentDbString;
                    if (currentValue > maxValue)
                    {
                        // volumeDB.Text = ("-" + ((100 - (100 * max)).ToString("F")));
                        peakVolumeDB.Text = currentDbString;
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

        // Calls when user clicks create group button
        // Pulls values from form
        // Creates project settings file (.txt CSV) in Bin directory
        private void createGroupButton(object sender, EventArgs e)
        {
            // Get group settings from files
            groupName = groupNameTextBox.Text;
            numberOfGuitarStrings = Convert.ToInt32(numberOfGuitarStringsNumeric.Value);
            numberOfFrets = Convert.ToInt32(numberOfGuitarFretsNumeric.Value);
            numberOfVelocities = Convert.ToInt32(numberOfVelocitiesNumeric.Value);
            numberOfRoundRobins = Convert.ToInt32(numberOfRoundRobinsNumeric.Value);

            // Sets default settings for previous note
            previousGuitarString = numberOfGuitarStrings; // Start with max guitar string # 
            previousFret = 0; // Start with open fret
            previousVelocityGroup = numberOfVelocities; // start with loudest group
            previousRoundRobbin = 0; // must start with 0 (see SetCurrentNote method)

            using (var tw = new StreamWriter(Environment.CurrentDirectory + "\\" + groupName + "Settings.txt", true))
            {
                tw.Write(groupName);
                tw.Write(",");
                tw.Write(numberOfGuitarStrings);
                tw.Write(",");
                tw.Write(numberOfFrets);
                tw.Write(",");
                tw.Write(numberOfVelocities);
                tw.Write(",");
                tw.Write(numberOfRoundRobins);
                tw.Write(",");
                tw.Write(previousGuitarString);
                tw.Write(",");
                tw.Write(previousFret);
                tw.Write(",");
                tw.Write(previousVelocityGroup);
                tw.Write(",");
                tw.Write(previousRoundRobbin);
            }

            DisableGroupSettingsChanges();


        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Show the dialog that allows user to select a file, the 
            // call will result a value from the DialogResult enum
            // when the dialog is dismissed.
            // DialogResult result = this.openFileDialog1.ShowDialog();
            // if a file is selected
            /*
            string fileURL;


            if (result == DialogResult.OK)
            {
                // Set the selected file URL to the textbox
                fileURL = this.openFileDialog1.FileName;
            }

            var OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            string settingsFile = OpenFile.ReadToEnd();
            */
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

        private void GroupName_TextChanged(object sender, EventArgs e)
        {

        }

        // Calls when user clicks "Load Group Button"
        // Loads group settings from a .txt file (CSV)
        private void LoadGroup_Click(object sender, EventArgs e)
        {
            // Create File Selecter Dialog
            Stream loadGroupStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = Environment.CurrentDirectory;

            // Validate file selection
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((loadGroupStream = theDialog.OpenFile()) != null) // check if file is null
                    {
                        using (loadGroupStream)
                        {
                            using (var reader = new StreamReader(loadGroupStream)) // Read file stream
                            {
                                List<string> listOfSettings = new List<string>(); // List of settings from file
                                while (!reader.EndOfStream)
                                {
                                    // Split settings values from csv
                                    var line = reader.ReadLine();
                                    var values = line.Split(',');
                                    foreach(var value in values)
                                    {
                                        listOfSettings.Add(value);
                                    }

                                    // Import group settings from file
                                    groupName = listOfSettings[0];
                                    numberOfGuitarStrings = Convert.ToInt32(listOfSettings[1]);
                                    numberOfFrets = Convert.ToInt32(listOfSettings[2]);
                                    numberOfVelocities = Convert.ToInt32(listOfSettings[3]);
                                    numberOfRoundRobins = Convert.ToInt32(listOfSettings[4]);
                                    previousGuitarString = Convert.ToInt32(listOfSettings[5]);
                                    previousFret = Convert.ToInt32(listOfSettings[6]);
                                    previousVelocityGroup = Convert.ToInt32(listOfSettings[7]);
                                    previousRoundRobbin = Convert.ToInt32(listOfSettings[8]);


                                    // Update group settings values
                                    groupNameTextBox.Text = groupName;
                                    numberOfGuitarStringsNumeric.Value = numberOfGuitarStrings;
                                    numberOfGuitarFretsNumeric.Value = numberOfFrets;
                                    numberOfVelocitiesNumeric.Value = numberOfVelocities;
                                    numberOfRoundRobinsNumeric.Value = numberOfRoundRobins;

                                }


                            }

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            DisableGroupSettingsChanges();


        }


        public void DisableGroupSettingsChanges()
        {
            createGroup.Enabled = false;
            groupNameTextBox.Enabled = false;
            numberOfGuitarStringsNumeric.Enabled = false;
            numberOfGuitarFretsNumeric.Enabled = false;
            numberOfVelocitiesNumeric.Enabled = false;
            numberOfRoundRobinsNumeric.Enabled = false;
            loadGroup.Enabled = false;
        }

        public void SetCurrentNote()
        {
            // Checks if the current group has started recording (will = 0 if this is a new group)
            if(currentRoundRobbin != 0)
            {
                // Do this for groups in recording already

                // Checks if all round robbins have been recorded
                if(previousRoundRobbin >= numberOfRoundRobins) // All robins have been recorded
                {
                    currentRoundRobbin = 1; // Set current round robbin to first round robin

                    // Checks if all velocities  have been recorded
                    if (previousVelocityGroup <= 1) // All velocities have been recorded (quitest has been reached)
                    {
                        currentVelocityGroup = numberOfVelocities; // set current velocity to highest veloccity

                        // Check if all frets have been used for this guitar string
                        if(previousFret >= numberOfFrets) // Last fret has been recoded
                        {
                            currentFret = 0; // set current fret to first on new string
                            currentGuitarString = previousGuitarString - 1; // move to next string (6 to 5 to 4 to 3 )

                        }
                        else // More frets to record on this string
                        {
                            currentFret = previousFret + 1;
                            currentGuitarString = previousGuitarString;

                        }

                    }
                    else // Not all velocities have been recorded
                    {
                        currentVelocityGroup = previousVelocityGroup - 1;
                        currentFret = previousFret;
                        currentGuitarString = previousGuitarString;
                    }


                }
                else // Not all round robins have been recorded
                {
                    currentRoundRobbin = previousRoundRobbin + 1;
                    currentVelocityGroup = previousVelocityGroup;
                    currentFret = previousFret;
                    currentGuitarString = previousGuitarString;

                }
            }
            else // Do this for new groups
            {
                currentGuitarString = previousGuitarString; // start with default of highest string (6)
                currentFret = previousFret; // start with default of open fret (0)
                currentVelocityGroup = previousVelocityGroup; // start with default of loudest group 
                currentRoundRobbin = 1; // initiate first round robbin recording


            }

 

            UpdateCurrentNoteGUI();

        }

        // Set previous not to current note
        public void UpdatePreviousNote()
        {
            previousGuitarString = currentGuitarString;
            previousFret = currentFret;
            previousVelocityGroup = currentVelocityGroup;
            previousRoundRobbin = currentRoundRobbin;
        }

        private void UpdateCurrentNoteGUI()
        {
            currentGuitarStringValue.Text = currentGuitarString.ToString();
            currentFretValue.Text = currentFret.ToString();
            currentVelocityGroupValue.Text = currentVelocityGroup.ToString();
            currentRoundRobinValue.Text = currentRoundRobbin.ToString();


        }

        private string GetCurrentFileName()
        {
            // File name structure
            // ex: StudioGuitarOpen_6_13_4_1_
            // GroupName_GuitarString_Fret_VelocityGroup_RoundRobinNumber_Note_velocityMin_VelocityMax

            string fileName;

            fileName = groupName + "_" + currentGuitarString + "_" + currentFret + "_" + currentVelocityGroup + "_" + currentRoundRobbin + "_" + GuitarToKeyboardNote(currentGuitarString, currentFret) + ".wav";

            return fileName;
        }


        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void CurrentVelocityValue_Click(object sender, EventArgs e)
        {

        }
    }
}
