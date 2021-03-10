using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace project_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private delegate String StringManipulationHandler(string oldString);
        private StringManipulationHandler stringManipulator;

        private String changeToNextCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))
                {
                    chars[i]++;
                }
                else
                {
                    if (ch == 'z') { chars[i] = 'a'; }
                    if (ch == 'Z') { chars[i] = 'A'; }
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        private String changeToCapitals(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch.ToString().ToUpper(); }
            return answer;
        }

        private String changeToFormerCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if ((ch >= 'b' && ch <= 'z') || (ch >= 'B' && ch <= 'Z'))
                {
                    chars[i]--;
                }
                else
                {
                    if (ch == 'a') { chars[i] = 'z'; }
                    if (ch == 'A') { chars[i] = 'Z'; }
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        private String changeToUnderscoreCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if(ch == ' ')
                {
                    chars[i] = '_';
                }
            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }
            return answer;
        }

        private String changeToCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            String answer = "";
            for (int i = 0; i < chars.Length; i++)
            {
                int number = (int)Char.GetNumericValue(chars[i]);
                if (number >= 1 && number <= 26)
                {
                    answer += alphabet[number - 1];
                }
                else
                {
                    if (chars[i] == ' ')
                    {
                        answer += ' ';
                    }
                }
            }
            return answer;
        }

        private String changeToLettersOnly(String s)
        {
            return Regex.Replace(s, "[^a-zA-Z]", "");
        }

        private String changeToLetter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            String answer = "";
            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];
                if (alphabet.Contains(Convert.ToChar(ch.ToString().ToLower())))
                {
                    answer += (Array.IndexOf(alphabet, ch) + 1);
                }
                else
                {
                    if(ch == ' ')
                    {
                        answer += ' ';
                    }
                }
            }
            return answer;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if(stringManipulator != null)
            {
                tbxOutput.Text = stringManipulator(tbxInput.Text);
            }
        }

        private void rbtnToCapitals_CheckedChanged(object sender, EventArgs e)
        {
            stringManipulator = new StringManipulationHandler(changeToCapitals);
        }

        private void rbtnToNextCharacter_CheckedChanged(object sender, EventArgs e)
        {
            stringManipulator = new StringManipulationHandler(changeToNextCharacter);
        }

        private void rbtnToFormerCharacter_CheckedChanged(object sender, EventArgs e)
        {
            stringManipulator = new StringManipulationHandler(changeToFormerCharacter);
        }

        private void rbtnToUnderscoreCharacter_CheckedChanged(object sender, EventArgs e)
        {
            stringManipulator = new StringManipulationHandler(changeToUnderscoreCharacter);
        }

        private void rbtnToLettersOnly_CheckedChanged(object sender, EventArgs e)
        {
            stringManipulator = new StringManipulationHandler(changeToLettersOnly);
        }
    }
}
