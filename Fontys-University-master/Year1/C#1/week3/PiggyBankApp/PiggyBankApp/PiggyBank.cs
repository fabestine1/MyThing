using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankApp
{
    public class PiggyBank
    {
        private String _name;
        private int _twoEuros;
        private int _oneEuros;

        public PiggyBank(String name)
        {
            this._name = name;
        }

        public String Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this._name = value;
                }
            }
        }

        public int TwoEuros
        {
            get
            {
                return this._twoEuros;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this._twoEuros = value;
                }
            }
        }

        public int OneEuros
        {
            get
            {
                return this._oneEuros;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this._oneEuros = value;
                }
            }
        }

        public String ChangeName(String name)
        {
            this.Name = name;
            return this.Name;
        }

        public int Add1TwoEuros()
        {
            this.TwoEuros++;
            return this.TwoEuros;
        }

        public int Add1OneEuros()
        {
            this.OneEuros++;
            return this.OneEuros;
        }

        public int GetTotalAmount(int temp = 1)
        {
            temp = this.TwoEuros * 2 + this.OneEuros;
            return temp;
        }

        public void AddMoney(int twoEuros, int oneEuros)
        {
            this.TwoEuros += twoEuros;
            this.OneEuros += oneEuros;
        }

        public String Info(String info = "")
        {
            info  = "Ownen's name is " + Name + ", he has " + TwoEuros + " two euro coins and "
                + OneEuros + " one euro coins";
            return info;
        }
    }
}
