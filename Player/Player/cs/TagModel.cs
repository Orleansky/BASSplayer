using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;
using Un4seen.Bass.AddOn.Wma;
using Un4seen.Bass;

namespace Player
{
    public class TagModel
    {
        public int BitRate;
        public int Freq;
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;
        public string Genre;
        public TagPicture TagPicture;
        public System.Drawing.Image Image;

        Dictionary<int, string> ChannelsDict = new Dictionary<int, string>()
        {
            {0, "Null" },
            {1, "Mono" },
            {2, "Stereo" }
        };

        string tagErr = "Радио";

        public TagModel(string file, string url)
        { 
            TAG_INFO tagInfo = new TAG_INFO();
            
            if (file != null)
            {
                tagInfo = BassTags.BASS_TAG_GetFromFile(file);
                BitRate = tagInfo.bitrate;
                Freq = tagInfo.channelinfo.freq;
                Channels = ChannelsDict[tagInfo.channelinfo.chans];
                Artist = tagInfo.artist;
                Album = tagInfo.album;
                if (tagInfo.title == "")
                {
                    Title = Vars.GetFileName(file);
                }
                else
                {
                    Title = tagInfo.title;
                }
                Year = tagInfo.year;
                TagPicture = tagInfo.PictureGet(0);
                if (TagPicture != null)
                {
                    Image = tagInfo.PictureGetImage(0);
                }
            } else if (url != null)
            {
                bool isSuccessful = BassTags.BASS_TAG_GetFromURL(BassL.Stream, tagInfo);
                if (isSuccessful)
                {
                    BitRate = tagInfo.bitrate;
                    Freq = tagInfo.channelinfo.freq;
                    Channels = ChannelsDict[tagInfo.channelinfo.chans];
                    Artist = tagInfo.artist;
                    Album = tagInfo.album;
                    Title = tagInfo.title;
                    Year = tagInfo.year;
                    TagPicture = tagInfo.PictureGet(0);
                    if (TagPicture != null)
                    {
                        Image = tagInfo.PictureGetImage(0);
                    }
                } else
                {
                    Artist = tagErr;
                    Title = tagErr;
                }
            }
        }
    }
}
