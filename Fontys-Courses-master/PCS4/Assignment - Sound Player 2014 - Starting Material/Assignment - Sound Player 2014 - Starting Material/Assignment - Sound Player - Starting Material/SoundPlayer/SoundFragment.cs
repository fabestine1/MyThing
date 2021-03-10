using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundPlayer
{
    class SoundFragment
    {
        private int duration;
        public int IdNr { get; }
        public string Title { get; set; }
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value >= 0)
                {
                    duration = value;
                }
                else
                {
                    duration = 0;
                }
            }
        }
        public string Filename { get; set; }
        public string DurationString {
            get
            {
                if (duration != 0)
                {
                    int min = duration / 60;
                    string secondsFormat;
                    int seconds = duration % 60;
                    if (seconds < 10)
                    {
                        secondsFormat = "0" + seconds;
                    }
                    else
                    {
                        secondsFormat = seconds.ToString();
                    }
                    return min + ":" + secondsFormat;
                }
                else
                {
                    return "unknown";
                }
            }
        }
        public SoundFragment(int idNr, string filename, string title, int minutes, int seconds)
        {
            IdNr = idNr;
            Filename = filename;
            if (title == "")
            {
                Title = "unknown";
            }
            else
            {
                Title = title;
            }
            Duration = minutes * 60 + seconds;
        }
        public SoundFragment(int idNr, string filename)
        {
            IdNr = idNr;
            Filename = filename;
            Title = "unknown";
        }
        public bool Play()
        {
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = Filename;
                myPlayer.Play();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string AsString()
        {
            return "idNr " + IdNr + " - " + Title + " - " + DurationString;
        }
    }
}
