using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deliveries
{
    public partial class test : Form
    {
        List<int> list;
        public test()
        {
            InitializeComponent();
            list = new List<int>();
        }
        private void Insert(int weight)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= weight)
                {
                    if (list[i] < max || max == 0)
                    {
                        max = list[i];
                        index = i;
                    }
                }
            }
            if (weight > max) list.Add(weight);
            else list.Insert(index, weight);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert(Convert.ToInt32(textBox1.Text));
            foreach(int i in list)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
