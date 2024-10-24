using System;
using System.Collections.Generic;
using System.IO;
using System.Speech.Synthesis;
using TextToSpeech.Interfaces;

namespace TextToSpeech.Implementations
{
    public class SpeechSynthesizerWrapper : ISpeechSynthesizer
    {
        private readonly SpeechSynthesizer _speechSynthesizer;
        private bool _disposed = false;

        public SpeechSynthesizerWrapper()
        {
            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.SpeakProgress += OnSpeakProgress;
            _speechSynthesizer.SpeakCompleted += OnSpeakCompleted;
        }

        public void SetOutputToDefaultAudioDevice()
        {
            _speechSynthesizer.SetOutputToDefaultAudioDevice();
        }

        public void SetOutputToWaveFile(string filePath)
        {
            _speechSynthesizer.SetOutputToWaveFile(filePath);
        }

        public void SelectVoice(string voice)
        {
            _speechSynthesizer.SelectVoice(voice);
        }

        public void Speak(string text)
        {
            _speechSynthesizer.SpeakAsync(text);
        }

        public void Pause()
        {
            _speechSynthesizer.Pause();
        }

        public void Resume()
        {
            _speechSynthesizer.Resume();
        }
        public void Stop()
        {
            _speechSynthesizer.SpeakAsyncCancelAll();
        }

        public SynthesizerState State => _speechSynthesizer.State;

        public IEnumerable<InstalledVoice> GetInstalledVoices()
        {
            return _speechSynthesizer.GetInstalledVoices();
        }

        public int Rate
        {
            get => _speechSynthesizer.Rate;
            set => _speechSynthesizer.Rate = value;
        }

        public int Volume
        {
            get => _speechSynthesizer.Volume;
            set => _speechSynthesizer.Volume = value;
        }

        public int CurrentPosition { get; set; }
        public string text { get; set; }

        public bool ShouldSaveAudio { get; set; } = false;

        public bool IsSpeakingFinished { get; set; } = true;

        public void OnSpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            CurrentPosition = e.CharacterPosition;
        }

        public void OnSpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            Console.WriteLine("Speech completed.");
            if (ShouldSaveAudio && IsSpeakingFinished)
            {
                SaveAudioFile();
            }
        }

        public void RestartFromCurrentPosition(string fullText)
        {
            IsSpeakingFinished = false;
            // Stop any ongoing speech
            _speechSynthesizer.SpeakAsyncCancelAll();

            // Get the remaining text from the current position onwards
            string remainingText = GetRemainingTextFromCurrentPosition(fullText);

            if (!string.IsNullOrEmpty(remainingText))
            {
                Console.WriteLine($"Restarting from position: {CurrentPosition}");
                _speechSynthesizer.SpeakAsync(remainingText);
            }
        }

        private string GetRemainingTextFromCurrentPosition(string fullText)
        {
            if (CurrentPosition >= 0 && CurrentPosition < fullText.Length)
            {
                // Return the substring from the current position onwards
                return fullText.Substring(CurrentPosition);
            }

            return string.Empty;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _speechSynthesizer.Dispose();
            }

            _disposed = true;
        }

        public void SaveAudioFile()
        {
            var fileName = String.Format("audio_{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var textToSpeechPath = Path.Combine(documentsPath, "TextToSpeechAudio");
            var outputPath = Path.Combine(textToSpeechPath, $"{fileName}.wav");

            if (!Directory.Exists(textToSpeechPath))
            {
                Directory.CreateDirectory(textToSpeechPath);
            }

            _speechSynthesizer.SetOutputToWaveFile(outputPath);
            _speechSynthesizer.Speak(text);
            _speechSynthesizer.SetOutputToNull();
        }

        ~SpeechSynthesizerWrapper()
        {
            Dispose(false);
        }
    }
}
