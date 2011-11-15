using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Microsoft.Speech.AudioFormat;
using Microsoft.Speech.Synthesis;

namespace MvcWebRole1.Controllers
{
    public class TTS
    {
        public static void Main(string[] args)
        {
            string text = args[0];
            string filename = args[1];
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.SelectVoice("Microsoft Server Speech Text to Speech Voice (ja-JP, Haruka)");
            s.SetOutputToWaveFile(filename, new SpeechAudioFormatInfo(16000, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));
            s.Speak(text);
            s.Dispose();
        }
    }
}
