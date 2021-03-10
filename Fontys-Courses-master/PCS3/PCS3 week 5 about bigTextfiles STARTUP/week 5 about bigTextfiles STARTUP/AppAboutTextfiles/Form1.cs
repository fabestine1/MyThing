using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;  //because we are using files

namespace AppAboutTextfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            File.Read
        }

        private void btnDoTheJob_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tbFilename.Text = openFileDialog1.FileName;
                ProcessFileAndShowInListbox(openFileDialog1.FileName, this.listBox1);
            }
            else
            {
                MessageBox.Show("you pushed the CANCEL-button");
            }
        }

        /// <summary>
        /// This methods calculates some statistics about the information in the file with filename fn.
        /// The results are displayed in the listbox lb.
        /// Statistics could be: how many messages are logged in the file? How many are for a certain device? How many different devices? etc.
        /// </summary>
        /// <param name="fn"></param>
        /// <param name="lb"></param>
        private void ProcessFileAndShowInListbox(String fn, ListBox lb)
        {

            DateTime startingtime = DateTime.Now;  // to calculate how long it takes to do the job

            //As a test the line below lets the app sleep for 2 seconds.
            //Of course, replace the sleep-statement below with your code.
            System.Threading.Thread.Sleep(2000);

            DateTime endingtime = DateTime.Now;
            TimeSpan ts = endingtime - startingtime; //now you know how long it takes to do the job
            lb.Items.Clear();
            lb.Items.Add("started " + startingtime.ToString());
            lb.Items.Add("ended " + endingtime.ToString());
            lb.Items.Add("calc. time " + ts.ToString());
            lb.Items.Add("*****************************************");

            lb.Items.Add("Number of lines is blablabla"); //of course, blablabla should be replaced by your answer
            lb.Items.Add("Number of not-empty-lines is blablabla");
            lb.Items.Add("Number of lines with exactly GUID=230:abff:fe2a:b5f6 is blablabla");
            lb.Items.Add("Number of lines containing GUID=230:abff:fe2a:b5f6 is blablabla");
            lb.Items.Add("Number of lines with GUID=0017880C02AE is blablabla");

            lb.Items.Add("*****************************************");
            lb.Items.Add("The number of different GUID's is blablabla");
            lb.Items.Add("The GUID's are: ");//and now show all GUID's in the listbox

            lb.Items.Add("");
            lb.Items.Add("**** that's all folks ! ! ! ****");
        }

        private void btnCopySomeLines_Click(object sender, EventArgs e)
        {  // copy's the first n lines from the big file eventsLast24h.txt to another file smallFile.txt, where n should be given in the textbox tbNumber
            FileStream fin = null, fout = null;
            StreamReader sr = null; StreamWriter sw = null;
            try
            {
                fin = new FileStream("../../../eventsLast24h.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fin);
                fout = new FileStream("../../../smallFile.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fout);

                String s;
                int numberOfLinesToCopy = Convert.ToInt32(this.tbNumber.Text);
                for (int i = 0; i < numberOfLinesToCopy; i++)
                {
                    s = sr.ReadLine();
                    sw.WriteLine(s);
                }

            }
            catch (IOException)
            {
                MessageBox.Show("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (sw != null) sw.Close();
            }
            MessageBox.Show("**** done ****");
        }


    }
}
