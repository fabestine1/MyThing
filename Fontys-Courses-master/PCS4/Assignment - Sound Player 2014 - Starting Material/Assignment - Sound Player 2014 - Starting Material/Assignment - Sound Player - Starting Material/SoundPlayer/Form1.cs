using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundPlayer
{
    public partial class Form1 : Form
    {
        Playlist playlist;
        
        public Form1()
        {
            InitializeComponent();
            playlist = new Playlist("Pop");
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {  //the user pushed the OK-button of openFileDialog1
                tbFilename.Text = openFileDialog1.FileName;
            }
            else
            {  //the user pushed the CANCEL-button of openFileDialog1
                MessageBox.Show("You pushed the CANCEL-button.");
            }
        }

        private void btAddFragment_Click(object sender, EventArgs e)
        {
            int minutes;
            int seconds;
            if (tbNumber.Text != "" && tbFilename.Text != "")
            {
                if(tbMinutes.Text == "" || tbSeconds.Text == "")
                {
                    minutes = 0;
                    seconds = 0;
                }
                else
                {
                    minutes = Convert.ToInt32(tbMinutes.Text);
                    seconds = Convert.ToInt32(tbSeconds.Text);
                }
                playlist.AddFragment(Convert.ToInt32(tbNumber.Text), tbFilename.Text, tbTitle.Text, minutes, seconds);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            lbPlaylist.Items.Clear();
            List<SoundFragment> foundFragments;
            foundFragments = playlist.GetFragment(tbTitle.Text);
            if (foundFragments != null)
            {
                foreach (SoundFragment fragment in foundFragments)
                {
                    lbPlaylist.Items.Add(fragment.AsString());
                }
            }
        }

        private void btShowPlaylist_Click(object sender, EventArgs e)
        {
            lbPlaylist.Items.Clear();
            List<SoundFragment> allFragments;
            allFragments = playlist.GetAllFragments();
            foreach (SoundFragment fragment in allFragments)
            {
                lbPlaylist.Items.Add(fragment.AsString());
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            SoundFragment fragment;
            if (tbFragmentNr.Text != "")
            {
                fragment = playlist.GetFragment(Convert.ToInt32(tbFragmentNr.Text));
                if (fragment != null)
                {
                    if (!fragment.Play()) // (!)
                    {
                        MessageBox.Show("The fragment could not be played!");
                    }
                    else
                    {
                        lblInfo.Text = fragment.AsString();
                        pbDuration.Maximum = fragment.Duration;
                        timerDuration.Start();
                    }
                }
                else
                {
                    MessageBox.Show("The fragment could not be found!");
                }
            }
        }

        private void lbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
        String s = Convert.ToString(lbPlaylist.SelectedItem);
            SoundFragment fragment;
            string[] id = s.Split(' ');
            fragment = playlist.GetFragment(Convert.ToInt32(id[1]));
            if (!fragment.Play()) // (!)
            {
                MessageBox.Show("The fragment could not be played!");
            }
            else
            {
                timerDuration.Stop();
                pbDuration.Value = 0;
                lblInfo.Text = fragment.AsString();
                pbDuration.Maximum = fragment.Duration;
                timerDuration.Start();
            }
        }

        private void timerDuration_Tick(object sender, EventArgs e)
        {
            if (pbDuration.Value == pbDuration.Maximum)
            {
                timerDuration.Stop();
                pbDuration.Value = 0;
            }
            else
            {
                pbDuration.Value++;
            }
        }



        // Fire a method (!)
    }
}
