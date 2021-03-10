using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar
{
    class StocksComboBoxItem
    {
        string name;

        public StocksComboBoxItem(Stock s)
        {
            name = s.Name;
            Id = s.Id;
        }

        public int Id { get; private set; }

        //Override ToString method
        public override string ToString()
        {
            return name;
        }
    }
}
