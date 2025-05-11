using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeech.Common
{
    public static class ErrorMessages
    {
        public const string NoVoiceSelected = "Please select a voice.";
        public const string NoTextProvided = "Please provide text to speak.";
        public const string NoTextHighlighted = "Please Highlight Some Text.";
        public const string TextStillSpeaking = "Please Wait for the current speech to finish or Stop.";
        public const string ErrorOpeningFile = "There was an error opening the current file.";
        public const string InvalidRate = "Invalid rate value. Please enter a value between -10 and 10.";
        public const string InvalidVolume = "Invalid volume value. Please enter a value between 0 and 100.";
        public const string FileNotFound = "The specified file was not found.";
        public const string FileAlreadyExists = "The specified file already exists. Please choose a different name.";
        public const string SaveAudioError = "Error saving audio file. Please check the file path and permissions.";
    }
}
