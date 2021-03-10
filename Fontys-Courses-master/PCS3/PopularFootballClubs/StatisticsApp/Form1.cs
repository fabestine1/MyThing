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

namespace StatisticsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = null;
                    try
                    {
                        FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        try
                        {
                            sr = new StreamReader(fs);
                            int[] votes = new int[2];
                            string line = sr.ReadLine();
                            //fs.Seek(0, SeekOrigin.Begin);
                            while (line != null)
                            {
                                    if (line.Contains(tbxFirstClub.Text))
                                    {
                                        votes[0]++;
                                    }
                                    if (line.Contains(tbxSecondClub.Text))
                                    {
                                        votes[1]++;
                                    }
                                line = sr.ReadLine();

                            }
                            lblFirstClubVotes.Text = votes[0].ToString();
                            lblSecondClubVotes.Text = votes[1].ToString();
                        }
                        catch(IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            if (sr != null)
                            {
                                sr.Close();
                            }
                        }
                        catch(IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
