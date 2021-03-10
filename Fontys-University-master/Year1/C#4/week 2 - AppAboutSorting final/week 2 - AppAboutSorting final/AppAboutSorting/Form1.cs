using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutSorting
{
    public partial class Form1 : Form
    {
        private int[] numbers = { 22, 55, 5, 77, 45, 39, 39, 45, 17, 29 };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach (int number in numbers)
            {
                this.listBox1.Items.Add(number.ToString());
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
            for(int firstIndexOfTheRest = 0; firstIndexOfTheRest<numbers.Length; firstIndexOfTheRest++)
            {
                //find the place of the smallest number on index firstIndexOfTheRest or bigger.
                int indexSmallest = getIndexOfSmallest(firstIndexOfTheRest);
                //swap that smallest number with the one on index firstIndexOfTheRest.
                swap(firstIndexOfTheRest, indexSmallest);

            }

        }

        /// <summary>
        /// elemets on index i and index j will be swapped
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void swap(int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }


        /// <summary>
        /// from position startIndex it finds the index of a smallest element
        /// </summary>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        private int getIndexOfSmallest(int startIndex)
        {
            int indexSmallest = startIndex;
            for(int i = startIndex+1; i<numbers.Length; i++)
            {
                if(numbers[i] < numbers[indexSmallest])
                {
                    indexSmallest = i;
                }
            }

                return indexSmallest;

        }


    }
}
