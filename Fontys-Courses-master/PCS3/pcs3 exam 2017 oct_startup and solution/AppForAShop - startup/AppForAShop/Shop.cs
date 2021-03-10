using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForAShop
{
    class Shop
    {
        private String name; //the name of this shop
        private List<Article> theArticles; //the articles this shop is selling

        public Shop(String name)
        {
            this.name = name;
            this.theArticles = new List<Article>();
        }

        public String Name { get { return this.name; } }

        /// <summary>
        /// returns a list of all articles of this shop
        /// </summary>
        /// <returns></returns>
        public List<Article> GetAllArticles()
        {
            return this.theArticles; ;
        }

        /// <summary>
        /// if the list of this shop contains an article with identity equal to id,
        /// then this article is returned
        /// else null is returned
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Article GetArticle(int id)
        {
            foreach(Article a in this.theArticles)
            {
                if (a.getID() == id) return a;
            }
            return null;
        }

        /// <summary>
        /// if the list of this shop does not contain an article with
        /// the same id as article a,
        /// then article a is added to the list and returnvalue is true
        /// else nothing is added to the list and returnvalue is false
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool AddArticle(Article a)
        { 
            if (this.GetArticle(a.getID()) == null)
            {
                this.theArticles.Add(a);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// if the list of this shop contains an article with identity equal to idnr,
        /// then for this article the number in stock should be lowered by amount
        /// and the returnvalue is the total selling price for these amount of articles
        /// else -1 is returned
        /// </summary>
        /// <param name="idnr"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double SellArticle(int idnr, int amount)
        {
            Article a = this.GetArticle(idnr);
            if (a != null)
            {
                a.sellSome(amount);
                return amount * a.getSellingPrice();
            }
            else
            {
                return -1;
            }
        }

        //******************************************************
        //IMPORTANT: No changes above this line.
        //******************************************************

        /// <summary>
        /// returns a list of wine that is bottled in year yrr or earlier
        /// </summary>
        /// <param name="yrr"></param>
        /// <returns></returns>
        public List<Article> GetListOfOldWine(int yrr)
        {
            //todo, see assignment 2
            List<Article> temp = new List<Article>();
            foreach(Article article in theArticles)
            {
                if(article is WineArt)
                {
                    if(((WineArt)article).Year <= yrr)
                    {
                        temp.Add(article);
                    }
                }
            }
            return temp;
        }
    }
}
