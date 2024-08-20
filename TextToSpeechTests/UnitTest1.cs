using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Configuration;
using System.IO;

namespace TextToSpeechTests
{
    [TestClass]
    public class UnitTest1
    {
        static WindowsDriver<WindowsElement> session;

        [TestInitialize]
        public void TestInitialize()
        {
            string appPath = Path.Combine(ConfigurationManager.AppSettings["AppPath"], "bin\\Debug\\TextToSpeech.exe");

            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", appPath);
            session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
        }


        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Test Method 1");
        }
    }
}
