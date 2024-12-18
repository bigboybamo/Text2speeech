
namespace TextToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSpeech = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.txtSpechText = new System.Windows.Forms.TextBox();
            this.BtnPronounce = new System.Windows.Forms.Button();
            this.cmbVoice = new System.Windows.Forms.ComboBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveAudio = new System.Windows.Forms.CheckBox();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSpeech
            // 
            this.BtnSpeech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSpeech.Location = new System.Drawing.Point(76, 13);
            this.BtnSpeech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSpeech.Name = "BtnSpeech";
            this.BtnSpeech.Size = new System.Drawing.Size(172, 57);
            this.BtnSpeech.TabIndex = 0;
            this.BtnSpeech.Text = "Speak";
            this.BtnSpeech.UseVisualStyleBackColor = true;
            this.BtnSpeech.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenFile.Location = new System.Drawing.Point(76, 138);
            this.BtnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(140, 57);
            this.BtnOpenFile.TabIndex = 2;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPause.Location = new System.Drawing.Point(464, 138);
            this.BtnPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(128, 57);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResume.Location = new System.Drawing.Point(651, 138);
            this.BtnResume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(134, 57);
            this.BtnResume.TabIndex = 4;
            this.BtnResume.Text = "Resume";
            this.BtnResume.UseVisualStyleBackColor = true;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStop.Location = new System.Drawing.Point(832, 138);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(112, 57);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(76, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(978, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voice Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slow";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(26, 29);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(922, 69);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(76, 378);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(978, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Normal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Low";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(26, 29);
            this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(922, 69);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 50;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // txtSpechText
            // 
            this.txtSpechText.Location = new System.Drawing.Point(76, 542);
            this.txtSpechText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpechText.Multiline = true;
            this.txtSpechText.Name = "txtSpechText";
            this.txtSpechText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpechText.Size = new System.Drawing.Size(976, 304);
            this.txtSpechText.TabIndex = 8;
            this.txtSpechText.Text = "Hello, I\'m Ricoooooo";
            // 
            // BtnPronounce
            // 
            this.BtnPronounce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPronounce.Location = new System.Drawing.Point(1113, 702);
            this.BtnPronounce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPronounce.Name = "BtnPronounce";
            this.BtnPronounce.Size = new System.Drawing.Size(234, 105);
            this.BtnPronounce.TabIndex = 9;
            this.BtnPronounce.Text = "Pronounce Highlighted Word";
            this.BtnPronounce.UseVisualStyleBackColor = true;
            this.BtnPronounce.Click += new System.EventHandler(this.BtnPronounce_Click);
            // 
            // cmbVoice
            // 
            this.cmbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(464, 18);
            this.cmbVoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(607, 52);
            this.cmbVoice.TabIndex = 10;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // SaveAudio
            // 
            this.SaveAudio.AutoSize = true;
            this.SaveAudio.Checked = true;
            this.SaveAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveAudio.Location = new System.Drawing.Point(76, 91);
            this.SaveAudio.Name = "SaveAudio";
            this.SaveAudio.Size = new System.Drawing.Size(145, 24);
            this.SaveAudio.TabIndex = 11;
            this.SaveAudio.Text = "Save Audio File";
            this.SaveAudio.UseVisualStyleBackColor = true;
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(1122, 138);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 12;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // ClockLabel
            // 
            this.ClockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLabel.Location = new System.Drawing.Point(1118, 44);
            this.ClockLabel.Name = "ClockLabel";
            this.ClockLabel.Size = new System.Drawing.Size(316, 50);
            this.ClockLabel.TabIndex = 13;
            this.ClockLabel.Text = "Clock time";
            this.ClockLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1536, 851);
            this.Controls.Add(this.ClockLabel);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.SaveAudio);
            this.Controls.Add(this.cmbVoice);
            this.Controls.Add(this.BtnPronounce);
            this.Controls.Add(this.txtSpechText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnResume);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.BtnSpeech);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Text2Speech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSpeech;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TextBox txtSpechText;
        private System.Windows.Forms.Button BtnPronounce;
        private System.Windows.Forms.ComboBox cmbVoice;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.CheckBox SaveAudio;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Label ClockLabel;
    }
}

