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

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer synthVoice;
        bool isStopped;

        private void button1_Click(object sender, EventArgs e)
        {
            string voice = cmbVoice.Text;
            string theText = txtSpechText.Text;
            if (voice == "Select Voice")
            {

                MessageBox.Show("Select a Voice");
                return;

            }
            if (theText == "")
            {

                MessageBox.Show("Type some text");
                return;

            }
            synthVoice = new SpeechSynthesizer();
            synthVoice.SetOutputToDefaultAudioDevice();
            synthVoice.SelectVoice(voice);
            synthVoice.Rate = trackBar1.Value;
            synthVoice.Volume = trackBar2.Value;
            synthVoice.SpeakAsync(theText);
            isStopped = false;
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            synthVoice = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synthVoice.GetInstalledVoices())
            {
                VoiceInfo infoVoice = voice.VoiceInfo;
                cmbVoice.Items.Add(infoVoice.Name);
            }
            synthVoice.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            synthVoice.Dispose();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (isStopped == false)
            {

                if (synthVoice.State == SynthesizerState.Speaking)
                {

                    synthVoice.Pause();

                }

            }
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            if (isStopped == false)
            {

                if (synthVoice.State == SynthesizerState.Paused)
                {

                    synthVoice.Resume();

                }

            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (synthVoice != null)
            {

                synthVoice.Dispose();
                isStopped = true;


            }
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
            ///hellloo changes

            if (txtSpechText.SelectionLength > 0)
            {

                string sel = txtSpechText.SelectedText;
                SpeechSynthesizer syn = new SpeechSynthesizer();
                syn.SetOutputToDefaultAudioDevice();
                syn.SelectVoice(voice);
                syn.Speak(sel.Trim());
                syn.Dispose();

            }
        }
    }
}
