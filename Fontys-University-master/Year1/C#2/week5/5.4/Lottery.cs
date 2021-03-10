using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Lottery
    {
        private int _counter = 0;
        private Random rnd;
        private List<int> _remove;

        public Lottery(int maxValue, int maxDraw)
        {
            this.MaxValue = maxValue;
            this.MaxDraw = maxDraw;
            this.DrawnNumbers = new int[maxDraw];
            rnd = new Random();
            _remove = new List<int>();
            for (int i = 0; i < maxValue; i++)
            {
                this._remove.Add(i);
            }
        }

        public int MaxValue { get; private set; }
        public int[] DrawnNumbers { get; private set; }
        public int MaxDraw { get; private set; }
        public bool Ender
        {
            get
            {
                if(this._counter < this.MaxDraw)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            private set
            {
                this.Ender = value;
            }
     
        }

        public void DrawNumber()
        {
            int newNumber;
            
            if (this.Ender)
            {
                newNumber = this._remove[(rnd).Next(this.MaxValue - this._counter)];

                this.DrawnNumbers[this._counter] = newNumber;

                this._remove.Remove(newNumber);    

                this._counter++;
            }
        }

        public void DrawAllNumbers()
        {
            foreach(int i in this.DrawnNumbers)
            {
                DrawNumber();
            }
        }

        public int LastNumberDrawn()
        {
            if(this._counter > 0)
            {
                return this.DrawnNumbers[_counter];
            }
            
            return -1;         
        }

        public int GetNumberDrawn(int index)
        {
            return this.DrawnNumbers[index - 1];
        }
    }
}
