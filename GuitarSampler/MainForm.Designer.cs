using NAudio.Wave;
using System;
using System.IO;


namespace GuitarSampler
{
    partial class mainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberOfVelocitiesNumeric = new System.Windows.Forms.NumericUpDown();
            this.numberOfRoundRobinsNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfGuitarFretsNumeric = new System.Windows.Forms.NumericUpDown();
            this.numberOfGuitarStringsNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadGroup = new System.Windows.Forms.Button();
            this.createGroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.peakVolumeDB = new System.Windows.Forms.Label();
            this.currentGuitarStringLabel = new System.Windows.Forms.Label();
            this.currentFretLabel = new System.Windows.Forms.Label();
            this.currentVelocityGroupLabel = new System.Windows.Forms.Label();
            this.currentRoundRobinLabel = new System.Windows.Forms.Label();
            this.currentGuitarStringValue = new System.Windows.Forms.Label();
            this.currentFretValue = new System.Windows.Forms.Label();
            this.currentVelocityGroupValue = new System.Windows.Forms.Label();
            this.currentRoundRobinValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.volumeDB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfVelocitiesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRoundRobinsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuitarFretsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuitarStringsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numberOfVelocitiesNumeric);
            this.groupBox1.Controls.Add(this.numberOfRoundRobinsNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberOfGuitarFretsNumeric);
            this.groupBox1.Controls.Add(this.numberOfGuitarStringsNumeric);
            this.groupBox1.Controls.Add(this.groupNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loadGroup);
            this.groupBox1.Controls.Add(this.createGroup);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(309, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Group Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Velocities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Round Robins";
            // 
            // numberOfVelocitiesNumeric
            // 
            this.numberOfVelocitiesNumeric.Location = new System.Drawing.Point(163, 193);
            this.numberOfVelocitiesNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfVelocitiesNumeric.Name = "numberOfVelocitiesNumeric";
            this.numberOfVelocitiesNumeric.Size = new System.Drawing.Size(132, 22);
            this.numberOfVelocitiesNumeric.TabIndex = 10;
            // 
            // numberOfRoundRobinsNumeric
            // 
            this.numberOfRoundRobinsNumeric.Location = new System.Drawing.Point(9, 193);
            this.numberOfRoundRobinsNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfRoundRobinsNumeric.Name = "numberOfRoundRobinsNumeric";
            this.numberOfRoundRobinsNumeric.Size = new System.Drawing.Size(144, 22);
            this.numberOfRoundRobinsNumeric.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Frets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Strings";
            // 
            // numberOfGuitarFretsNumeric
            // 
            this.numberOfGuitarFretsNumeric.Location = new System.Drawing.Point(163, 123);
            this.numberOfGuitarFretsNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfGuitarFretsNumeric.Name = "numberOfGuitarFretsNumeric";
            this.numberOfGuitarFretsNumeric.Size = new System.Drawing.Size(132, 22);
            this.numberOfGuitarFretsNumeric.TabIndex = 6;
            // 
            // numberOfGuitarStringsNumeric
            // 
            this.numberOfGuitarStringsNumeric.Location = new System.Drawing.Point(8, 123);
            this.numberOfGuitarStringsNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfGuitarStringsNumeric.Name = "numberOfGuitarStringsNumeric";
            this.numberOfGuitarStringsNumeric.Size = new System.Drawing.Size(147, 22);
            this.numberOfGuitarStringsNumeric.TabIndex = 5;
            // 
            // groupNameTextBox
            // 
            this.groupNameTextBox.Location = new System.Drawing.Point(9, 54);
            this.groupNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupNameTextBox.Name = "groupNameTextBox";
            this.groupNameTextBox.Size = new System.Drawing.Size(284, 22);
            this.groupNameTextBox.TabIndex = 3;
            this.groupNameTextBox.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group Name";
            // 
            // loadGroup
            // 
            this.loadGroup.Location = new System.Drawing.Point(163, 244);
            this.loadGroup.Margin = new System.Windows.Forms.Padding(4);
            this.loadGroup.Name = "loadGroup";
            this.loadGroup.Size = new System.Drawing.Size(132, 36);
            this.loadGroup.TabIndex = 1;
            this.loadGroup.Text = "Load Group";
            this.loadGroup.UseVisualStyleBackColor = true;
            this.loadGroup.Click += new System.EventHandler(this.LoadGroup_Click);
            // 
            // createGroup
            // 
            this.createGroup.Location = new System.Drawing.Point(12, 244);
            this.createGroup.Margin = new System.Windows.Forms.Padding(4);
            this.createGroup.Name = "createGroup";
            this.createGroup.Size = new System.Drawing.Size(141, 36);
            this.createGroup.TabIndex = 0;
            this.createGroup.Text = "Create Group";
            this.createGroup.UseVisualStyleBackColor = true;
            this.createGroup.Click += new System.EventHandler(this.createGroupButton);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sample Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "NAME_S#_F#_RR#_VS#";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(458, 259);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 36);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(539, 259);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 36);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(377, 259);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(75, 36);
            this.recordButton.TabIndex = 9;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // peakVolumeDB
            // 
            this.peakVolumeDB.AutoSize = true;
            this.peakVolumeDB.Location = new System.Drawing.Point(423, 330);
            this.peakVolumeDB.Name = "peakVolumeDB";
            this.peakVolumeDB.Size = new System.Drawing.Size(28, 17);
            this.peakVolumeDB.TabIndex = 11;
            this.peakVolumeDB.Text = "0.0";
            // 
            // currentGuitarStringLabel
            // 
            this.currentGuitarStringLabel.AutoSize = true;
            this.currentGuitarStringLabel.Location = new System.Drawing.Point(357, 78);
            this.currentGuitarStringLabel.Name = "currentGuitarStringLabel";
            this.currentGuitarStringLabel.Size = new System.Drawing.Size(92, 17);
            this.currentGuitarStringLabel.TabIndex = 12;
            this.currentGuitarStringLabel.Text = "Guitar String:";
            this.currentGuitarStringLabel.Click += new System.EventHandler(this.Label8_Click);
            // 
            // currentFretLabel
            // 
            this.currentFretLabel.AutoSize = true;
            this.currentFretLabel.Location = new System.Drawing.Point(412, 105);
            this.currentFretLabel.Name = "currentFretLabel";
            this.currentFretLabel.Size = new System.Drawing.Size(37, 17);
            this.currentFretLabel.TabIndex = 13;
            this.currentFretLabel.Text = "Fret:";
            // 
            // currentVelocityGroupLabel
            // 
            this.currentVelocityGroupLabel.AutoSize = true;
            this.currentVelocityGroupLabel.Location = new System.Drawing.Point(388, 131);
            this.currentVelocityGroupLabel.Name = "currentVelocityGroupLabel";
            this.currentVelocityGroupLabel.Size = new System.Drawing.Size(61, 17);
            this.currentVelocityGroupLabel.TabIndex = 14;
            this.currentVelocityGroupLabel.Text = "Velocity:";
            // 
            // currentRoundRobinLabel
            // 
            this.currentRoundRobinLabel.AutoSize = true;
            this.currentRoundRobinLabel.Location = new System.Drawing.Point(354, 159);
            this.currentRoundRobinLabel.Name = "currentRoundRobinLabel";
            this.currentRoundRobinLabel.Size = new System.Drawing.Size(95, 17);
            this.currentRoundRobinLabel.TabIndex = 15;
            this.currentRoundRobinLabel.Text = "Round Robin:";
            // 
            // currentGuitarStringValue
            // 
            this.currentGuitarStringValue.AutoSize = true;
            this.currentGuitarStringValue.Location = new System.Drawing.Point(456, 78);
            this.currentGuitarStringValue.Name = "currentGuitarStringValue";
            this.currentGuitarStringValue.Size = new System.Drawing.Size(0, 17);
            this.currentGuitarStringValue.TabIndex = 16;
            // 
            // currentFretValue
            // 
            this.currentFretValue.AutoSize = true;
            this.currentFretValue.Location = new System.Drawing.Point(456, 104);
            this.currentFretValue.Name = "currentFretValue";
            this.currentFretValue.Size = new System.Drawing.Size(0, 17);
            this.currentFretValue.TabIndex = 17;
            // 
            // currentVelocityGroupValue
            // 
            this.currentVelocityGroupValue.AutoSize = true;
            this.currentVelocityGroupValue.Location = new System.Drawing.Point(456, 131);
            this.currentVelocityGroupValue.Name = "currentVelocityGroupValue";
            this.currentVelocityGroupValue.Size = new System.Drawing.Size(0, 17);
            this.currentVelocityGroupValue.TabIndex = 18;
            this.currentVelocityGroupValue.Click += new System.EventHandler(this.CurrentVelocityValue_Click);
            // 
            // currentRoundRobinValue
            // 
            this.currentRoundRobinValue.AutoSize = true;
            this.currentRoundRobinValue.Location = new System.Drawing.Point(456, 158);
            this.currentRoundRobinValue.Name = "currentRoundRobinValue";
            this.currentRoundRobinValue.Size = new System.Drawing.Size(0, 17);
            this.currentRoundRobinValue.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Peak dB:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "dB:";
            // 
            // volumeDB
            // 
            this.volumeDB.AutoSize = true;
            this.volumeDB.Location = new System.Drawing.Point(423, 313);
            this.volumeDB.Name = "volumeDB";
            this.volumeDB.Size = new System.Drawing.Size(28, 17);
            this.volumeDB.TabIndex = 22;
            this.volumeDB.Text = "0.0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 366);
            this.Controls.Add(this.volumeDB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.currentRoundRobinValue);
            this.Controls.Add(this.currentVelocityGroupValue);
            this.Controls.Add(this.currentFretValue);
            this.Controls.Add(this.currentGuitarStringValue);
            this.Controls.Add(this.currentRoundRobinLabel);
            this.Controls.Add(this.currentVelocityGroupLabel);
            this.Controls.Add(this.currentFretLabel);
            this.Controls.Add(this.currentGuitarStringLabel);
            this.Controls.Add(this.peakVolumeDB);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = " Guitar Sampler";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfVelocitiesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRoundRobinsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuitarFretsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuitarStringsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createGroup;
        private System.Windows.Forms.Button loadGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberOfVelocitiesNumeric;
        private System.Windows.Forms.NumericUpDown numberOfRoundRobinsNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberOfGuitarFretsNumeric;
        private System.Windows.Forms.NumericUpDown numberOfGuitarStringsNumeric;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Label peakVolumeDB;
        private System.Windows.Forms.Label currentGuitarStringLabel;
        private System.Windows.Forms.Label currentFretLabel;
        private System.Windows.Forms.Label currentVelocityGroupLabel;
        private System.Windows.Forms.Label currentRoundRobinLabel;
        private System.Windows.Forms.Label currentGuitarStringValue;
        private System.Windows.Forms.Label currentFretValue;
        private System.Windows.Forms.Label currentVelocityGroupValue;
        private System.Windows.Forms.Label currentRoundRobinValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label volumeDB;
        // private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

