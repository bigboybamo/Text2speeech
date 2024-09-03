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
        void SpeakAsync(string text);
        void Pause();
        void Resume();

        void Stop();
        SynthesizerState State { get; }

        IEnumerable<InstalledVoice> GetInstalledVoices();

        int Rate { get; set; }
        int Volume { get; set; }
    }
}
