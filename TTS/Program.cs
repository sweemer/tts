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
            string text = args[0];
            string filename = args[1];
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.SelectVoice("Microsoft Server Speech Text to Speech Voice (ja-JP, Haruka)");
            s.SetOutputToWaveFile(filename, new SpeechAudioFormatInfo(8000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
            s.Speak(text);
            s.Dispose();
        }
    }
}
    