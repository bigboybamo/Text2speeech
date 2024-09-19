using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeechLogger
{
    public static class Logger
    {
        public static void LogSpeechText(string text, string logFilePath = null)
        {

            if (logFilePath == null)
            {
                string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TextToSpeech");

                if (!Directory.Exists(appDataFolder))
                {
                    Directory.CreateDirectory(appDataFolder);
                }

                logFilePath = Path.Combine(appDataFolder, "Log.txt");
            }

            using (StreamWriter sw = new StreamWriter(logFilePath, false))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
                sw.Flush();
            }
        }
    }
}
