using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool a = isAscending(new int[5] { 1001, 1002, 1004, 1007, 500 }, 4);
            MessageBox.Show(a.ToString());
        }
        public int sumSquares(int n)
        {
            if(n == 0) return 0;
            return n * n + sumSquares(n-1);
        }
        public int sum(int[] X, int n)
        {
            if (n == 0) return 0;
            return X[n-1] + sum(X, n - 1);
        }
        public int max(int[] X, int n)
        {
            int maximum = X[n - 1];
            if (n == 1) return maximum;
            if(max(X, n-1) > maximum) maximum = max(X, n - 1);
            return maximum;
        }
        public int sumOfDigits(int n)
        {
            if (n == 0) return 0;
            return n%10 + sumOfDigits(n / 10);
        }
        public bool allBig(int[] X, int n)
        {
            if (n == 0) return true;
            return X[n - 1] > 1000 && allBig(X, n-1);
        }
        public bool isAscending(int[] X, int n)
        {
            if (n == 1) return true;
            return X[n - 2] <= X[n - 1] && isAscending(X, n - 1);
        }
    }
}
