using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// using classes

namespace SoundPlayer
{
    class Playlist
    {
        private List<SoundFragment> fragments = new List<SoundFragment>();
        public string Theme { get; }
        public Playlist(string theme)
        {
            Theme = theme;
            //Playlist playlist = new Playlist(theme);
        }
        public SoundFragment GetFragment(int idNr)
        {
            foreach (SoundFragment fragment in fragments)
            {
                if (fragment.IdNr == idNr)
                {
                    return fragment;
                }
            }
            return null; // (!)
        }
        public List<SoundFragment> GetFragment(string p)
        {
            List<SoundFragment> listFound = new List<SoundFragment>();
            foreach (SoundFragment fragment in fragments)
            {
                if (fragment.Title.Contains(p))
                {
                    listFound.Add(fragment);
                }
            }
                return listFound; // (!)
        }
        public List<SoundFragment> GetAllFragments()
        {
            return fragments;
        }
        public bool AddFragment(int idNr, string filename, string title, int min, int sec)
        {
            if (GetFragment(idNr) == null)
            {
                if(title != "" || min != 0 || sec != 0)
                {
                    fragments.Add(new SoundFragment(idNr, filename, title, min, sec));
                }
                else
                {
                    fragments.Add(new SoundFragment(idNr, filename));
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
