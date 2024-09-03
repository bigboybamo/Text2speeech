using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
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
        }

        public void SetOutputToDefaultAudioDevice()
        {
            _speechSynthesizer.SetOutputToDefaultAudioDevice();
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

        ~SpeechSynthesizerWrapper()
        {
            Dispose(false);
        }
    }
}
