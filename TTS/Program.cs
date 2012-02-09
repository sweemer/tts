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
            SpeechSynthesizer s = new SpeechSynthesizer();
            string lang = args[0].ToLower();
            if (lang.Equals("ja"))
                s.SelectVoice("Microsoft Server Speech Text to Speech Voice (ja-JP, Haruka)");
            else if (lang.Equals("en"))
                s.SelectVoice("Microsoft Server Speech Text to Speech Voice (en-US, ZiraPro)");
            else if (lang.Equals("ko"))
                s.SelectVoice("Microsoft Server Speech Text to Speech Voice (ko-KR, Heami)");
            else if (lang.Equals("zh"))
                s.SelectVoice("Microsoft Server Speech Text to Speech Voice (zh-CN, HuiHui)");
            else
                Environment.Exit(1);
            string textfile = args[1];
            string text = System.IO.File.ReadAllText(textfile, System.Text.Encoding.UTF8);
            string wavefile = args[2];
            s.Volume = 100;
            s.SetOutputToWaveFile(wavefile, new SpeechAudioFormatInfo(48000, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));
            s.Speak(text);
            s.Dispose();
        }
    }
}
    