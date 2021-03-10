using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCS2ExamApp
{
    public partial class Form1 : Form
    {
        MusiciansAgency ma;
        
        public Form1()
        {
            InitializeComponent();
            ma = new MusiciansAgency("THE Dutch musicians agency");
            ma.AddRelevantInstrument("guitar");
            ma.AddRelevantInstrument("drums");
            ma.AddRelevantInstrument("piano");
            UpdateAll();
        }

        private void UpdateAll()
        {
            this.cmbAORelevantInstruments.Items.Clear();
            List<string> holderAO = ma.GetAllRelevantInstruments();
            foreach (string str in holderAO)
            {
                this.cmbAORelevantInstruments.Items.Add(str);
            }
            this.cmbAORelevantInstruments.SelectedIndex = 1;
            
            this.cmbMRelevantInstruments.Items.Clear();
            List<string> holderM = ma.GetAllRelevantInstruments();
            foreach (string str in holderM)
            {
                this.cmbMRelevantInstruments.Items.Add(str);
            }
            this.cmbMRelevantInstruments.SelectedIndex = 1;
        
            this.lbMAllMusicians.Items.Clear();
            List<Musician> holderMu = ma.GetAllMusicians();
            if (holderMu.Count == 0)
            {
                this.lbMAllMusicians.Items.Add("no musicians yet");
            }
            else
            {
                foreach (Musician mus in holderMu)
                {
                    this.lbMAllMusicians.Items.Add(mus.AsString());
                }
                
            }
        }

        private void btAOAddRelevantInstrument_Click(object sender, EventArgs e)
        {
            ma.AddRelevantInstrument(tbAORelevantInstrument.Text);
            UpdateAll();
        }

        ////private void btMAddMe_Click(object sender, EventArgs e)
        ////{
        ////    // !!!TODO!!!
        ////}

        /// <summary>
        /// Adds a musician to the list of registered musicians in ma
        /// Updates all relevant visable parts of this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMAddMe_Click(object sender, EventArgs e)
        {
            // !!!TODO!!! assignment 3a
            ma.AddMusician(tbMName.Text,Convert.ToInt32(tbMAge),cmbMRelevantInstruments.ToString());
            UpdateAll();
        }

        /// <summary>
        /// Adds an instrument (the one selected in cmbMRelevantInstruments) to the musician with
        /// a certain idNr (the one typed in tbMIdNr) to that musicians list of possible instruments
        /// Updates all relevant visable parts of this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btMAddAnInstrumentToMyList_Click(object sender, EventArgs e)
        {
            // !!!TODO!!! assignment 3b
            Musician mu = ma.getMusicianWithIdnr(Convert.ToInt32(tbMIdNr.Text));
            if (mu != null)
            {
                mu.AddInstrument(cmbMRelevantInstruments.SelectedIndex.ToString());
            }

            //ma.AddMusician(tbMName.Text);
        }

        private void panelMusician_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.FillRectangle(Brushes.Red,  0, 0, 8, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 16, 0, 7, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 30, 0, 6, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 42, 0, 5, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 51, 0, 4, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 60, 0, 3, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 66, 0, 2, this.panelMusician.ClientRectangle.Height);
            gr.FillRectangle(Brushes.Red, 71, 0, 1, this.panelMusician.ClientRectangle.Height);
            
            
            
            // !!!TODO!!! assignment 3c
            
            // Complete this code in such a way that it produces a fancy left side in the panel panelMusician
            // which really looks like the one in MusicAgencyDemo
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbAORelevantInstrument_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
