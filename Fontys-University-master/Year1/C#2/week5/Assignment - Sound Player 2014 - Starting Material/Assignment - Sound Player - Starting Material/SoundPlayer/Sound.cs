using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundPlayer
{
    class Sound
    {
        private int _duration;

        public Sound(int idNum, String fileName)
        {
            this.IdNum = idNum;
            this.FileName = fileName;
            this.Title = "Unknown";
            this.Duration = 0;
            this.DurationToString = "Unknown time";
        }

        public Sound(int idNum, String fileName, String title, int minutes, int seconds)
        {
            this.IdNum = idNum;
            this.FileName = fileName;
            this.Title = title;
            this.Duration = 60 * minutes + seconds;
            this.DurationToString = minutes.ToString() + ":" + seconds.ToString();
        }

        public int IdNum { get; private set; }
        public String Title { get; set; }
        public String FileName { get; set; }
        public String DurationToString { get; private set; }

        public int Duration
        {
            get
            {
                return this._duration;
            }
            set
            {
                if(value < 0)
                {
                    value = 0;
                }

                this._duration = value;
            }
        }

        public bool Play()
        {
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = this.FileName;
                myPlayer.Play();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override String ToString()
        {
            return "Song number: " + this.IdNum + " - " + this.Title + " - " + this.DurationToString;
        }
    }
}
