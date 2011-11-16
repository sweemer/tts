using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.Speech.AudioFormat;
using Microsoft.Speech.Synthesis;

namespace Dynaptico
{
    public class TTS
    {
        public static void Main(string[] args)
        {
            string lang = args[0].ToLower();
            string text = args[1];
            string filename = args[2];
            SpeechSynthesizer s = new SpeechSynthesizer();
            if (lang.Equals("ja"))
                s.SelectVoice("Microsoft Server Speech Text to Speech Voice (ja-JP, Haruka)");
            else if (lang.Equals("en"))
                s.SelectVoice("Microsoft Server Speech Text to Speech Voice (en-US, ZiraPro)");
            else
                Environment.Exit(1);
            s.SetOutputToWaveFile(filename, new SpeechAudioFormatInfo(48000, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));
            s.Speak(text);
            s.Dispose();
        }
    }
}
    