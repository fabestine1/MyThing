using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._3
{
    class Lottery
    {
        //fields
        Random rnd = new Random();
        int generatedNumber;
        int[] numberArray;

        //properties
        public int MaxValue { get; private set; }
        public int NrOfDrawnNumbers { get; private set; }
        public int NrOfWantedNumbers { get; private set; }
        public bool DrawingIsOver { get; private set; }

        //constructors
        public Lottery(int nwMaxValue, int nwWantedNumber){
            MaxValue = nwMaxValue;
            NrOfWantedNumbers = nwWantedNumber;
            numberArray = new int[NrOfWantedNumbers];
        }

        //methods
        public void Draw1Number()
        {
            if (numberArray[NrOfWantedNumbers - 1] != 0)
            {
                DrawingIsOver = true;
            }
            else
            {
                generatedNumber = rnd.Next(1, MaxValue + 1);
                numberArray[NrOfDrawnNumbers] = generatedNumber;
                NrOfDrawnNumbers++;
            }
        }
        public void DrawAllNumbers()
        {
            for (int i = 0; i < NrOfWantedNumbers; i++)
            {
                Draw1Number();
            }
        }
        public int GetLastNumberDrawn()
        {
            if(NrOfDrawnNumbers != 0)
            {
                return numberArray[NrOfDrawnNumbers - 1];
            }
            else
            {
                return -1;
            }
        }
        public int GetNumberDrawn(int i)
        {
            if(NrOfDrawnNumbers == 0)
            {
                return numberArray[i];
            }
            else
            {
                return -1;
            }
        }
        //public int GeefGetal (int number)
        //{

        //}
    }
}
