using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using System.IO;
using System.Speech.Recognition;
using System.Threading;

namespace TextToSpeechTests
{
    [TestClass]
    public class UITests
    {
        static WindowsDriver<WindowsElement> session;
        readonly string baseDirectory = ConfigurationManager.AppSettings["AppPath"];

        [TestInitialize]
        public void TestInitialize()
        {
           string appPath = Path.Combine(baseDirectory, "bin\\Debug\\TextToSpeech.exe");

            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", appPath);
            session = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
        }

        [TestCleanup]
        public void TestCleanup()
        {
           session?.Quit();
        }

        [DataTestMethod]
        [DataRow("This is an automated test.")]
        [DataRow("Automated, this test is.")]
        public void Should_SpeakSentence_WhenButtonIsClicked(string param)
        {
            //Arrange
            session.FindElementByAccessibilityId("cmbVoice").Click();

            session.FindElementByName("Microsoft Zira Desktop").Click();

            var textBox = session.FindElementByAccessibilityId("txtSpechText");
            textBox.SendKeys(param);

            //Act
            session.FindElementByAccessibilityId("BtnSpeech").Click();

            //Assert
            string logFile = Path.Combine(baseDirectory, "bin\\Debug\\Log.txt");
            string logContent = File.ReadAllText(logFile);
            Assert.IsTrue(logContent.Contains(param));
        }
    }
}
