using System;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using GemBox.Pdf;
using TextToSpeech.Interfaces;
using TextToSpeech.Implementations;
using TextToSpeechLogger;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the form size
            this.Height = 600;
            this.Width = 1000;
            StartTimer();
        }

        private ISpeechSynthesizer synthVoice;
        private bool isStopped;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckVoiceandText();
                var voice = cmbVoice.Text;
                var text = txtSpechText.Text;
                MakeSpeech(text, voice);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MakeSpeech(string text, string voice)
        {
            InitializeSpeechSynthesizer(new SpeechSynthesizerWrapper());
            synthVoice.text = text;
            synthVoice.SelectVoice(voice);
            synthVoice.Rate = trackBar1.Value;
            synthVoice.Volume = trackBar2.Value;
            synthVoice.SetOutputToDefaultAudioDevice();
            synthVoice.Speak(synthVoice.text);

            if (SaveAudio.Checked)
            {
                synthVoice.ShouldSaveAudio = true;
            }
            isStopped = false;
            Logger.LogSpeechText(synthVoice.text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSpeechSynthesizer(new SpeechSynthesizerWrapper());
            cmbVoice.Items.Add("Select Voice");
            cmbVoice.SelectedIndex = 0;
            LoadVoices();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            synthVoice?.Dispose();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (!isStopped && (synthVoice.State == SynthesizerState.Speaking))
            {
                synthVoice.Pause();
            }
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (!isStopped && (synthVoice.State == SynthesizerState.Paused))
            {
                synthVoice.Resume();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            synthVoice.Stop();
            isStopped = true;
            synthVoice.IsSpeakingFinished = false;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            ofd1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd1.Title = "Open File";
            ofd1.Filter = "Text Files|*.txt|Word Files|*.docx|PDF Files|*.pdf";
            if (ofd1.ShowDialog() != DialogResult.Cancel)
            {
                string fileName = ofd1.FileName;
                string ending = Path.GetExtension(fileName);
                if (ending == ".txt")
                {
                    GetTextFile(fileName);
                }
                else if (ending == ".pdf")
                {
                    GetPdfFile(fileName);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void GetTextFile(string filePath)
        {
            StreamReader objReader = new StreamReader(filePath);
            txtSpechText.Text = objReader.ReadToEnd();
            objReader.Close();
        }

        private void GetPdfFile(string filePath)
        {
            txtSpechText.Text = "";
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            PdfDocument doc = PdfDocument.Load(filePath);
            int numOfPages = doc.Pages.Count;

            if (numOfPages <= 2)
            {
                foreach (var page in doc.Pages)
                {
                    txtSpechText.Text += page.Content.ToString();
                }
            }
            else
            {
                MessageBox.Show("Too many pages");
            }
        }

        private void BtnPronounce_Click(object sender, EventArgs e)
        {
            try
            {
                CheckVoiceandText(true);
                string voice = cmbVoice.Text;
                if (txtSpechText.SelectionLength > 0)
                {
                    var text = txtSpechText.SelectedText;
                    int selectionStart = txtSpechText.SelectionStart;
                    int selectionLength = txtSpechText.SelectionLength;
                    txtSpechText.Focus();
                    txtSpechText.Select(selectionStart, selectionLength);
                    MakeSpeech(text, voice);
                    Logger.LogSpeechText(synthVoice.text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeSpeechSynthesizer(ISpeechSynthesizer synthesizer)
        {
            synthVoice = synthesizer;
        }

        public void LoadVoices()
        {
            foreach (var voice in synthVoice.GetInstalledVoices())
            {
                cmbVoice.Items.Add(voice.VoiceInfo.Name);
            }
        }

        private void CheckVoiceandText(bool ishighLighted = false)
        {
            if (cmbVoice.Text == "Select Voice" || cmbVoice.SelectedIndex == 0)
            {
                throw new InvalidOperationException("Please Select a Voice");
            }

            if (txtSpechText.Text.Trim().Length == 0)
            {
                throw new InvalidOperationException("Please Enter Some Text");
            }

            if (ishighLighted && txtSpechText.SelectionLength == 0)
            {
                throw new InvalidOperationException("Please Highlight Some Text");
            }

            if (synthVoice.State == SynthesizerState.Speaking)
            {
                throw new InvalidOperationException("Please Wait for the current speech to finish or Stop");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (synthVoice != null && synthVoice.State == SynthesizerState.Speaking)
            {
                synthVoice.Rate = trackBar1.Value;
                synthVoice.RestartFromCurrentPosition(txtSpechText.Text);
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (synthVoice != null && synthVoice.State == SynthesizerState.Speaking)
            {
                synthVoice.Volume = trackBar2.Value;
                synthVoice.RestartFromCurrentPosition(txtSpechText.Text);
            }
        }

        private void StartTimer()
        {
            clockTimer = new Timer
            {
                Interval = 500
            };
            clockTimer.Tick += clockTimer_Tick;
            clockTimer.Enabled = true;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            clockLabel.Visible = true;
        }
    }
}