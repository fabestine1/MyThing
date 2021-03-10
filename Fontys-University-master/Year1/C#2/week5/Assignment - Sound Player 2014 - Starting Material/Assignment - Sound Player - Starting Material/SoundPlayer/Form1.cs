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
        Playlist motivation;
        int totaltime;
        
        public Form1()
        {
            InitializeComponent();

            motivation = new Playlist("Motivation");
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {  //the user pushed the OK-button of openFileDialog1
                tbFilename.Text = openFileDialog1.FileName;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(this.tbTitle.Text != null)
            {
                motivation.GetSound(this.tbTitle.Text);
            }
            if(this.tbNumber.Text != null)
            {
                motivation.GetSound(int.Parse(this.tbNumber.Text));
            }
        }

        private void btAddFragment_Click(object sender, EventArgs e)
        {
            bool checker = false;

            checker = motivation.AddSound(int.Parse(this.tbNumber.Text), this.tbFilename.Text, this.tbTitle.Text,
                int.Parse(this.tbMinutes.Text), int.Parse(this.tbSeconds.Text));

            if (checker)
            {
                this.lbPlaylist.Items.Add(int.Parse(this.tbNumber.Text) + " - " + this.tbTitle.Text);
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            motivation.GetSound(int.Parse(this.tbFragmentNr.Text)).Play();

            totaltime = motivation.GetSound(int.Parse(this.tbFragmentNr.Text)).Duration;

            this.pbSong.Maximum = totaltime;

            this.tmPlay.Enabled = true;
        }

        private void lbPlaylist_DoubleClick(object sender, EventArgs e)
        {
            if (this.lbPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a sound first!");
            }
            else
            {
                string sound;

                sound = lbPlaylist.GetItemText(lbPlaylist.SelectedItem);

                String[] id = sound.Split('-');

                motivation.GetSound(int.Parse(id[0])).Play();

                totaltime = motivation.GetSound(int.Parse(id[0])).Duration;

                this.pbSong.Maximum = totaltime;

                this.tmPlay.Enabled = true;
            }
        }

        private void tmPlay_Tick(object sender, EventArgs e)
        {
            if (this.pbSong.Value < this.pbSong.Maximum)
            {
                this.pbSong.Value++;
            }
            else
            {
                this.pbSong.Value = 0;
                this.tmPlay.Enabled = false;
            }
        }
    }
}
