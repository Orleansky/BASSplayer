using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Player
{
    public static class Vars
    { 
        //список полных имен файлов
        public static List<string> Files = new List<string>();

        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }

        public static string GetUrlName(string url)
        {
            string[] tmp = url.Split('\\');
            return tmp[tmp.Length - 1];
        }

        public static List<string> URLs = new List<string>
        {
            "http://emgregion.hostingradio.ru:8064/moscow.europaplus.mp3",
            "http://radiorecord.hostingradio.ru/phonk96.aacp",
            "http://ice.actve.net/dance-radio128.mp3",
            "http://rautemusik-de-hz-fal-stream12.radiohost.de/rock",
            "http://rautemusik-de-hz-fal-stream12.radiohost.de/90s",
            "http://maximum.hostingradio.ru/grunge96.aacp"
        };
    }
}
