using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using Un4seen.Bass.AddOn.Wma;

namespace Player
{
public static class BassL
    {
        public static int SampleRate = 44100;

        public static bool InitDefaultDevice;

        public static int Stream;

        public static int EffectHandle;

        public static int Volume = 100;

        public static string Filename = "";

        public static string URL = "";

        private static readonly List<int> BassPluginsHandler = new List<int>();

        // инициализация Bass.dll
        public static bool InitBass(int sampleRate)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, sampleRate, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                

                if (InitDefaultDevice)
                {
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bass_aac.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bass_ac3.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bass_mpc.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bass_tta.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bassalac.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bassape.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bassenc_flac.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\bassopus.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\basswma.dll"));
                    BassPluginsHandler.Add(Bass.BASS_PluginLoad(@"C:\Users\LK10725\Desktop\АиЯП\Player\Player\plugins\basswv.dll"));
                }

                bool isOk = BassFx.LoadMe();
            }
            return InitDefaultDevice;
        }

        // воспроизведение
        public static void Play(string fileName, string url, int vol)
        {
            Bass.BASS_ChannelStop(Stream);
            if (InitBass(SampleRate))
            {
                if (Stream == 0 || (Filename != fileName && fileName != null) || (URL != url && url != null))
                {
                    if (url != null)
                    {
                        Stream = Bass.BASS_StreamCreateURL(url, 0, BASSFlag.BASS_DEFAULT, null, IntPtr.Zero);
                        URL = url;
                    }
                    else
                    {
                        Stream = Bass.BASS_StreamCreateFile(fileName, 0, 0, BASSFlag.BASS_DEFAULT);
                        Filename = fileName;
                    }
                }
                if (Stream != 0)
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
        }

        // стоп
        public static void Stop()
        {
            Bass.BASS_ChannelPause(Stream);
        }

        // получение длительности (в секундах)
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)time;
        }

        // получение текущей позиции (в секундах)
        public static int GetPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            double posSec = Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return (int)posSec;
        }

        public static void SetPosOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        // установка громкости
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
        }

        public static void SetSampleRate(int stream, int sampleRate)
        {
            int version = BassFx.BASS_FX_GetVersion();
            SampleRate = sampleRate;
            bool isOk = Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_FREQ, SampleRate);
            BASSError error = Bass.BASS_ErrorGetCode();
        }

        public static void SetDefaultSampleRate()
        {
            SampleRate = 44100;
        }

        public static int GetSampleRate(int stream)
        {
            return SampleRate;
        }

        public static void AddEcho()
        {
            Bass.BASS_ChannelRemoveFX(Stream, EffectHandle);

            EffectHandle = Bass.BASS_ChannelSetFX(Stream, BASSFXType.BASS_FX_DX8_ECHO, 0);
        }

        public static void AddReverb()
        {
            Bass.BASS_ChannelRemoveFX(Stream, EffectHandle);
            EffectHandle = Bass.BASS_ChannelSetFX(Stream, BASSFXType.BASS_FX_BFX_FREEVERB, 0);
        }

        public static void RemoveEffects()
        {
            Bass.BASS_ChannelRemoveFX(Stream, EffectHandle);
        }
    }
}