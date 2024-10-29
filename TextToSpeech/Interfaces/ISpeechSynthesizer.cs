using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

namespace TextToSpeech.Interfaces
{
    public interface ISpeechSynthesizer: IDisposable
    {
        string text { get; set; }
        void SetOutputToDefaultAudioDevice();

        void SetOutputToWaveFile(string filePath);

        void SelectVoice(string voice);
        void Speak(string text);
        void Pause();
        void Resume();

        void Stop();
        void OnSpeakProgress(object sender, SpeakProgressEventArgs e);
        void OnSpeakCompleted(object sender, SpeakCompletedEventArgs e);

        void SaveAudioFile();

        void RestartFromCurrentPosition(string fullText);
        SynthesizerState State { get; }

        IEnumerable<InstalledVoice> GetInstalledVoices();

        int Rate { get; set; }
        int Volume { get; set; }

        int CurrentPosition { get; set; }

        bool ShouldSaveAudio { get; set; }

        bool IsSpeakingFinished { get; set; }
    }
}
