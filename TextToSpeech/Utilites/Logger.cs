using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeech.Utilites
{
    public static class Logger
    {
        public static void LogSpeechText(string text)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string logFilePath = Path.Combine(currentDirectory, "Log.txt");

            // Overwrite the log file every time this method is called
            using (StreamWriter sw = new StreamWriter(logFilePath, false))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
            }
        }
    }
}
