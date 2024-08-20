using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechTests
{
    public static class TestHelper
    {
        public static string RecognizeText()
        {
            string text = "";
            var recognizer = new SpeechRecognitionEngine();
            recognizer.SetInputToDefaultAudioDevice();

            recognizer.LoadGrammar(new DictationGrammar());

            recognizer.RecognizeAsync(RecognizeMode.Multiple);

            recognizer.SpeechRecognized += (sender, e) =>
            {
                Console.WriteLine($"Recognized text: {e.Result.Text}");
                text = e.Result.Text;
            };

            return text;
        }
    }
}
