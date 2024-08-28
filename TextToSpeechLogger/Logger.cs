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
                logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt");
            }

            using (StreamWriter sw = new StreamWriter(logFilePath, false))
            {
                sw.WriteLine($"{DateTime.Now}: {text}");
                sw.Flush();
            }
        }
    }
}
