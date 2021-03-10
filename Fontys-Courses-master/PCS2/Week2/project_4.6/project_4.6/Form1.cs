using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4._6
{
    public partial class Form1 : Form
    {
        int[] array1;
        int[] array2;
        int[] array3;
        public Form1()
        {
            InitializeComponent();
            array1 = new int[5] { 1, 2, 3, 4, 5 };
            array2 = new int[5] { 1, 5, 3, 7, 5 };
            array3 = new int[5] { 5, 2, 6, 2, 7 };
        }

        public void ChangeValues(int[] arr1, int[] arr2, int[] arr3)
        {
            for(int i = 0; i < 5; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    arr3[i] = 1;
                }
                else
                {
                    arr3[i] = 0;
                }
                array1 = arr1;
                array2 = arr2;
                array3 = arr3;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            ChangeValues(array1, array2, array3);
            lblResult.Text = string.Join(",", array3);
        }
    }
}
