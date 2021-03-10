using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingReservation
{
    public class Customer
    {
        //Mick, fields zijn ALTIJD private,
        //automatic properties zijn ALTIJD public {get; set;}//PUBLIC
        //public properties = Hoofdletter
        //private properties geenhoofdletters

        private static int nextID;//initialises at 0
        public int ID { get; private set; }
        public string Name { get; private set; }
        public List<string> Cardnumbers { get; private set;}
        public DateTime DateOfRegistration { get; private set; }
        public DateTime EntranceDate { get; private set; }//niet vergeten te setten bij entrance!!
        public decimal Balance { get; private set; }
        public bool LoyalCustomer { get; set; }
        public bool TemporaryCustomer { get; private set; }
        public decimal Rate
        {
            get
            {
                if (this.LoyalCustomer == true)
                {
                    return 2.1M;//some random value
                }
                else
                {
                    return 3.2M;// some random value
                }
            }
        }

        ///////////////////////////////////////////////////
        /////////CONSTRUCTORS
        ///////////////////////////////////////////////////

        //Cardnumber in constructor????
        public Customer(string name, bool temporary)
        {
            //Eerst exceptions en fouten afbakenen

            //Vergeet hier niet de null vergelijking te doen!
            if (name == null || name.Length == 0)
            {
                throw new ArgumentException("name");
            }


            //daarna alle waardes toekennen

            this.Name = name;

            this.TemporaryCustomer = temporary;
            Cardnumbers = new List<string>();

            this.Balance = 0.0M;
            this.DateOfRegistration = DateTime.Now;

            LoyalCustomer = false;//misschien in constructor?? 
            //zeker weten in constructor!

            this.ID = ++nextID;//first add 1 to nextID before assigning to ID
        }
        public Customer(string name, bool temporary, decimal balance)
            : this(name, temporary)
        {
            if (balance > 0M)
            {
                throw new ArgumentOutOfRangeException("balance");
            }


            this.Balance = balance;       
        }
        public Customer(string name, bool temporary, decimal balance, string cardnumber)
            : this(name, temporary, balance)
        {
            if (!IsValidCardnumber(cardnumber))
            {
                throw new ArgumentException("cardnumber");
            }

            Cardnumbers.Add(cardnumber);
        }
        public Customer(string name, bool temporary, decimal balance, List<string> cardnumbers)
            :this(name, temporary, balance)
        {
            foreach(string s in cardnumbers)
            {
                if(IsValidCardnumber(s))
                {
                    throw new ArgumentException("Cardnumber invalid: " + s);
                }

                //
                this.Cardnumbers.Add(s);
            }
        }

        ///////////////////////////////////////////
        //METHODS
        //////////////////////////////////////////

        public bool LoadBalance(decimal amount)
        {
            //Misschien hernoemen naar AddBalance
            //Misschien ook een SetBalance toevoegen?

            if(amount > 0.0M)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Pay method without amount to pay, auto calc price for time spent in garage
        /// </summary>
        /// <returns>True/False if Pay succedes yes or no</returns>
        public bool Pay()
        {
            decimal price = CalcPrice();
            if(Balance > price)
            {
                Balance -= price;
                return true;
            }
            return false;
        }
        /// <summary>
        /// pay with parameter amount as given price to pay
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>True/False if Pay succedes yes or no</returns>
        public bool Pay(decimal amount)
        {
           // if(amount > 0.0M && Balance >= amount) 2 vergelijkingen

            //hoe zit het met de loyal customers? Die mogelijk een kleine hoeveelheid in de min staan!

            if (Balance - amount >= 0.0M)//Wanneer de balance betaald kan worden, slechts 1 vergelijking
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public bool AddCard(string cardnumber)
        {
            if(IsValidCardnumber(cardnumber))
            { 
                Cardnumbers.Add(cardnumber);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Given a string, checks whether the cardnumber is properly formatted
        /// SAMPLE cardnumer: E4 AF 45 23 OR 6D 12 8B 9A 00 34 E1
        /// </summary>
        /// <param name="cardnumber"></param>
        /// <returns></returns>
        public bool IsValidCardnumber(string cardnumber)
        {
            //moet deze functie hoofdletter gevoelig zijn?

            string[] arraySplittedCardnumbers = cardnumber.Split(' ');//splitten op spatie

            for (int i = 0; i < arraySplittedCardnumbers.Length; i++)
            {
                if (arraySplittedCardnumbers[i].Length != 2)
                {

                    //Check je ook of het de karakters 0-9 of A-F kan zijn?

                    return false;
                }
            }
            return true;
        }

        public decimal CalcPrice()//Deze functie moet je omzetten naar een automatic property met alleen een getter!
        {
            double totalMinutes = (EntranceDate - DateTime.Now).TotalMinutes;
            decimal price = Rate * (decimal)totalMinutes;
            return price;
        }

        public override string ToString()
        {
            string ID = "ID" + this.ID.ToString();
            string customerName = "Name: " + Name.ToString();
            string dateOfRegistration = "Date Of Registration: " + DateOfRegistration.ToString();
            string enteranceDate = "";

                if (EntranceDate == DateTime.MinValue)
                {
                    enteranceDate = "No Enterance Date";
                }
                else
                {
                    enteranceDate = EntranceDate.ToString();
                }

            string loyalCustomer = "Loyal Customer: " + LoyalCustomer.ToString();
            string rate = "Rate: €" + Rate.ToString();
            string balance = "Balance: €" + Balance.ToString();
            string cardnumbers = "Cardnumbers: <";
                foreach(string s in Cardnumbers)
                {
                   cardnumbers += s + ", ";
                }
                cardnumbers = cardnumbers.Remove(cardnumbers.Length - 2, 2) + ">";

            string spotInfo = ID + ", " +
                    customerName + ", " +
                    DateOfRegistration + ", " +
                    enteranceDate + ", " +
                    loyalCustomer + ", " +
                    rate + ", " +
                    balance + ", " +
                    cardnumbers;    

            return spotInfo;
        }
    }
}
