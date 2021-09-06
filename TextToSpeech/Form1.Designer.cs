
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSpeech
            // 
            this.BtnSpeech.Location = new System.Drawing.Point(29, 2);
            this.BtnSpeech.Name = "BtnSpeech";
            this.BtnSpeech.Size = new System.Drawing.Size(115, 37);
            this.BtnSpeech.TabIndex = 0;
            this.BtnSpeech.Text = "Speak";
            this.BtnSpeech.UseVisualStyleBackColor = true;
            this.BtnSpeech.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(51, 63);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(93, 37);
            this.BtnOpenFile.TabIndex = 2;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(328, 63);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(85, 37);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.Location = new System.Drawing.Point(467, 63);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(89, 37);
            this.BtnResume.TabIndex = 4;
            this.BtnResume.Text = "Resume";
            this.BtnResume.UseVisualStyleBackColor = true;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(599, 63);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 37);
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
            this.groupBox1.Location = new System.Drawing.Point(51, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voice Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slow";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 19);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(615, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.trackBar2);
            this.groupBox2.Location = new System.Drawing.Point(51, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 91);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Normal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Low";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(17, 19);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(615, 45);
            this.trackBar2.TabIndex = 0;
            this.trackBar2.Value = 50;
            // 
            // txtSpechText
            // 
            this.txtSpechText.Location = new System.Drawing.Point(51, 352);
            this.txtSpechText.Multiline = true;
            this.txtSpechText.Name = "txtSpechText";
            this.txtSpechText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpechText.Size = new System.Drawing.Size(652, 199);
            this.txtSpechText.TabIndex = 8;
            this.txtSpechText.Text = "Hello, I\'m Ricoooooo";
            this.txtSpechText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BtnPronounce
            // 
            this.BtnPronounce.Location = new System.Drawing.Point(742, 456);
            this.BtnPronounce.Name = "BtnPronounce";
            this.BtnPronounce.Size = new System.Drawing.Size(156, 68);
            this.BtnPronounce.TabIndex = 9;
            this.BtnPronounce.Text = "Pronounce Highlighted Word";
            this.BtnPronounce.UseVisualStyleBackColor = true;
            this.BtnPronounce.Click += new System.EventHandler(this.BtnPronounce_Click);
            // 
            // cmbVoice
            // 
            this.cmbVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.cmbVoice.FormattingEnabled = true;
            this.cmbVoice.Location = new System.Drawing.Point(307, 12);
            this.cmbVoice.Name = "cmbVoice";
            this.cmbVoice.Size = new System.Drawing.Size(406, 38);
            this.cmbVoice.TabIndex = 10;
            this.cmbVoice.Text = "Select Voice";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 553);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

