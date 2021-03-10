using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoundPlayer
{
    class Playlist
    {
        public Playlist(String theme)
        {
            this.Theme = theme;
            this.Sounds = new List<Sound>();
        }

        public String Theme { get; private set; }
        public List<Sound> Sounds { get; set; }

        public Sound GetSound(int idNum)
        {
            foreach(Sound sound in this.Sounds)
            {
                if(idNum == sound.IdNum)
                {
                    return sound;
                }
            }

            return null;
        }
        public List<Sound> GetSound(String title)
        {
            int i = 0;

            List<Sound> rtr = new List<Sound>();

            foreach (Sound sound in Sounds)
            {
                if (this.Sounds[i].Title.Contains(title))
                {
                    rtr.Add(this.Sounds[i]);
                }
            }

            return rtr;
        }

        public List<Sound> GetAllSounds()
        {
           return this.Sounds;
        }

        public bool AddSound(int idNum, String fileName, String title, int minutes, int seconds)
        {
            if (Sounds.Count == 0)
            {
                Sounds.Add(new Sound(idNum, fileName, title, minutes, seconds));

                return true;
            }
            else
            {
                foreach (Sound sound in Sounds)
                {
                    if (idNum != sound.IdNum)
                    {
                        Sounds.Add(new Sound(idNum, fileName, title, minutes, seconds));

                        return true;
                    }
                }
            }

            return false;
        }
    }
}
