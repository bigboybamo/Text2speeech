using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeech.Interfaces
{
    public interface ISpeechSynthesizer: IDisposable
    {
        void SetOutputToDefaultAudioDevice();
        void SelectVoice(string voice);
        void Speak(string text);
        void Pause();
        void Resume();

        void Stop();
        void OnSpeakProgress(object sender, SpeakProgressEventArgs e);
        void OnSpeakCompleted(object sender, SpeakCompletedEventArgs e);

        void SaveAudioFile(string fileName);

        void RestartFromCurrentPosition(string fullText);
        SynthesizerState State { get; }

        IEnumerable<InstalledVoice> GetInstalledVoices();

        int Rate { get; set; }
        int Volume { get; set; }

        int CurrentPosition { get; set; }
    }
}
