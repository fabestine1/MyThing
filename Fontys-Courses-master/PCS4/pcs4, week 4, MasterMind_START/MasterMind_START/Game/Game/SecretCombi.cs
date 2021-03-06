using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class SecretCombi
    {
        private int[] combination;
        private Random random;
        private int counter = 0;
        public SecretCombi()
        {
            combination = new int[4];
            random = new Random();
            int newNumber;
            for (int i = 0; i < 4; i++)
            {
                newNumber = random.Next(1, 10);
                while (combination.Contains(newNumber))
                {
                    newNumber = random.Next(1, 10);
                }
                combination[i] = newNumber;
            }
        }
        private bool CalculateScore(int[] newGuess, out int score1, out int score2)
        {
            score1 = 0;
            score2 = 0;
            for(int i = 0; i < 4; i++)
            {
                if(newGuess[i] == combination[i])
                {
                    score1++;
                }
                else
                {
                    if (combination.Contains(newGuess[i]))
                    {
                        score2++;
                    }
                }
            }
            if(score1 == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int[] CheckGuess(int[] newGuess, out int score1, out int score2)
        {
            score1 = 0;
            score2 = 0;
            CalculateScore(newGuess, out score1, out score2);
            counter++;
            if (counter == 10) return combination;
            return null;
        }
    }
}
