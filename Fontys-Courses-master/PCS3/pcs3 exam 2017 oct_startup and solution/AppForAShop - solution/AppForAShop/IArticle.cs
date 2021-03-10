using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    interface IArticle
    {
        int getID(); //returns the id of this article
        double getBasicPrice(); //returns the basic price of this article
        double getSellingPrice(); //returns the selling price of this article
        void sellSome(int amount);  //if the nrInStock >= amount, nrInStock is lowered by amount
                                    // otherwise an exception is thrown 
    }
}
