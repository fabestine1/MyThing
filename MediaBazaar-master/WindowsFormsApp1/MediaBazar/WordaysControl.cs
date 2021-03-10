using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class WordaysControl : UserControl
    {
        static Color greenColor = Color.LightGreen;
        static Color redColor = Color.Crimson;

        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public WordaysControl(int[] numbers, int neededPeople, String daytime)
        {
            InitializeComponent();
            int total = numbers[7];

            timeOfTheDayData.Text = UppercaseFirst(daytime);
            mondayData.Text = numbers[0].ToString();
            tuesData.Text = numbers[1].ToString();
            wedData.Text = numbers[2].ToString();
            thurData.Text = numbers[3].ToString();
            fridayData.Text = numbers[4].ToString();
            satData.Text = numbers[5].ToString();
            sunData.Text = numbers[6].ToString();
            totalData.Text = total.ToString();

            if (neededPeople <= total) colorPanel.BackColor = greenColor;
            else  colorPanel.BackColor = redColor;
        }
    }
}
