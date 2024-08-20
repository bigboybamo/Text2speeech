using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using GemBox.Pdf;
using TextToSpeech.Interfaces;
using TextToSpeech.Implementations;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ISpeechSynthesizer synthVoice;
        private bool isStopped;

        private void button1_Click(object sender, EventArgs e)
        {
            string voice = cmbVoice.Text;
            int selected = cmbVoice.SelectedIndex;
            string theText = txtSpechText.Text;
            if (voice == "Select Voice" || selected == 0)
            {
                MessageBox.Show("Please Select a Voice");
                return;
            }

            InitializeSpeechSynthesizer(new SpeechSynthesizerWrapper());
            synthVoice.SetOutputToDefaultAudioDevice();
            synthVoice.SelectVoice(voice);
            synthVoice.Rate = trackBar1.Value;
            synthVoice.Volume = trackBar2.Value;
            synthVoice.SpeakAsync(theText);
            isStopped = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSpeechSynthesizer(new SpeechSynthesizerWrapper());
            cmbVoice.Items.Add("Select Voice");
            cmbVoice.SelectedIndex = 0;
            foreach (var voice in synthVoice.GetInstalledVoices())
            {
                cmbVoice.Items.Add(voice.VoiceInfo.Name);
            }
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
            synthVoice?.Dispose();
            isStopped = true;
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
            string voice = cmbVoice.Text;

            if (voice == "Select Voice")
            {
                MessageBox.Show("Select a Voice");
                return;
            }

            if (txtSpechText.Text.Trim() == "")
            {
                MessageBox.Show("Type some text");
                return;
            }

            if (txtSpechText.SelectionLength > 0)
            {
                string sel = txtSpechText.SelectedText;
                InitializeSpeechSynthesizer(new SpeechSynthesizerWrapper());
                synthVoice.SetOutputToDefaultAudioDevice();
                synthVoice.SelectVoice(voice);
                synthVoice.SpeakAsync(sel.Trim());
                synthVoice.Dispose();
            }
        }

        public void InitializeSpeechSynthesizer(ISpeechSynthesizer synthesizer)
        {
            synthVoice = synthesizer;
        }
    }
}