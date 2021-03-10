using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataCollectingApp
{
    public partial class Form1 : Form
    {
        private string cityName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetCityName_Click(object sender, EventArgs e)
        {
            cityName = tbxNameOfCity.Text;
            Text = cityName;
            pnlGold.Visible = false;
            pnlRed.Dock = DockStyle.Fill;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("votesFrom" + cityName + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
                try
                {
                    sw = new StreamWriter(fs);
                    fs.Seek(0, SeekOrigin.End);
                    sw.WriteLine(tbxFootballClubsAnswer.Text);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                try
                {
                    if (sw != null)
                    {
                        sw.Close();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
