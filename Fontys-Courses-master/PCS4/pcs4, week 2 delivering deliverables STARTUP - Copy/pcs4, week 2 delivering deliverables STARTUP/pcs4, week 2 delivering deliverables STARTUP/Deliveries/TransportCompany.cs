using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Deliveries
{
    class TransportCompany
    {
        private List<Person> myPersons;
        private List<Deliverable> myDeliverables;

        public TransportCompany()
        {
            this.myPersons = new List<Person>();
            this.myDeliverables = new List<Deliverable>();
        }

        public List<Person> Persons { get { return this.myPersons; } }
        public List<Deliverable> Deliverables { get { return this.myDeliverables; } }


        public Person FindPerson(int id)
        {
            foreach (Person p in this.myPersons)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddPerson(Person p)
        {
            if (this.FindPerson(p.ID) == null)
            {
                this.myPersons.Add(p);
            }
            else
            {
                throw new Exception("Person not added, since there is already a person with id " + p.ID.ToString());
            }
        }

        public Deliverable FindDeliverable(int id, ref int counter)
        {
            SortById();
            return BinarySearchById(id, 0, myDeliverables.Count - 1, ref counter);
            //foreach (Deliverable d in this.myDeliverables)
            //{
            //    if (d.ID == id)
            //    {
            //        return d;
            //    }
            //}
            //return null;
        }

        public Deliverable FindDeliverable(string name)
        {
            SortByName();
            return BinarySearchByName(name, 0, myDeliverables.Count - 1);
            //foreach (Deliverable d in this.myDeliverables)
            //{
            //    if (d.ID == id)
            //    {
            //        return d;
            //    }
            //}
            //return null;
        }

        public void AddDeliverable(Deliverable d)
        {
            int counter = 0;
            if (FindDeliverable(d.ID, ref counter) == null)
            {
                myDeliverables.Add(d);
            }
            else
            {
                throw new Exception("Person not added, since there is already a deliverable with id " + d.ID.ToString());
            }
        }

        public void LoadPersonsFromFile(String filename)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                //this.myPersons.Clear();
                String name, street, postalcode, city;
                int id, housenr;
                name = sr.ReadLine();
                while (name != null)
                {
                    street = sr.ReadLine();
                    housenr = Convert.ToInt32(sr.ReadLine());
                    postalcode = sr.ReadLine();
                    city = sr.ReadLine();
                    id = Convert.ToInt32(sr.ReadLine());
                    this.myPersons.Add(new Person(id, name, street, housenr, postalcode, city));
                    name = sr.ReadLine();
                    name = sr.ReadLine(); //and again read a line, because of the delimiter between persons(line with the stars)
                }
            }
            catch (IOException e)
            {
                throw new Exception("Input/Output exception with message \"" + e.Message + "\" occurred", e);
            }
            catch (FormatException e)
            {
                throw new Exception("Incorrect file format exception with message \"" + e.Message + "\" occurred", e);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public void LoadDeliverablesFromFile(String filename)
        {  //todo
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                this.myDeliverables.Clear();
                int id, weight, buyer;
                String line = sr.ReadLine();

                while (line != null)
                {
                    string[] info = line.Split(' ');
                    id = Convert.ToInt32(info[0]);
                    weight = Convert.ToInt32(info[1]);
                    buyer = Convert.ToInt32(info[2]);

                    int max = 0;
                    int index = 0;

                    for (int i = 0; i < myDeliverables.Count; i++)
                    {
                        if (myDeliverables[i].Weight >= weight)
                        {
                            if (myDeliverables[i].Weight < max || max == 0)
                            {
                                max = myDeliverables[i].Weight;
                                index = i;
                            }
                        }
                    }
                    Deliverable d = new Deliverable(id, weight, FindPerson(buyer));
                    if (weight > max) myDeliverables.Add(d);
                    else myDeliverables.Insert(index, d);

                    line = sr.ReadLine();
                }
            }
            catch (IOException e)
            {
                throw new Exception("Input/Output exception with message \"" + e.Message + "\" occurred", e);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        public void Merge(String filename)
        {
            List<Deliverable> newList = new List<Deliverable>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                int id, weight, buyer;
                String line = sr.ReadLine();

                while (line != null)
                {
                    string[] info = line.Split(' ');
                    id = Convert.ToInt32(info[0]);
                    weight = Convert.ToInt32(info[1]);
                    buyer = Convert.ToInt32(info[2]);
                    newList.Add(new Deliverable(id, weight, FindPerson(buyer)));
                    line = sr.ReadLine();
                }
                SortByAddress();
                newList.Sort(delegate (Deliverable x, Deliverable y) { return (x.Buyer.Street + x.Buyer.Housenumber).CompareTo(y.Buyer.Street + y.Buyer.Housenumber); });
                List<Deliverable> mergedList = new List<Deliverable>();
                while(myDeliverables.Count != 0 && newList.Count != 0)
                {
                    if ((myDeliverables[0].Buyer.Street + myDeliverables[0].Buyer.Housenumber).CompareTo(newList[0].Buyer.Street + newList[0].Buyer.Housenumber) == -1){
                        mergedList.Add(myDeliverables[0]);
                        myDeliverables.RemoveAt(0);
                    }
                    else if ((newList[0].Buyer.Street + newList[0].Buyer.Housenumber).CompareTo(myDeliverables[0].Buyer.Street + myDeliverables[0].Buyer.Housenumber) == -1)
                    {
                        mergedList.Add(newList[0]);
                        newList.RemoveAt(0);
                    }
                    else
                    {
                        mergedList.Add(myDeliverables[0]);
                        myDeliverables.RemoveAt(0);
                        newList.RemoveAt(0);
                    }
                    if(myDeliverables.Count == 1 && newList.Count == 0)
                    {
                        mergedList.Add(myDeliverables[0]);
                    }
                    if (newList.Count == 1 && myDeliverables.Count == 0)
                    {
                        mergedList.Add(newList[0]);
                    }
                }
                myDeliverables = mergedList;

            }
            catch (IOException e)
            {
                throw new Exception("Input/Output exception with message \"" + e.Message + "\" occurred", e);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        /// <summary>
        /// SortByWeight sorts the elements of the deliverables-list from a low weight to a high weight.
        /// </summary>
        public void SortByWeight()
        {
            //todo
            this.myDeliverables.Sort();
        }

        /// <summary>
        /// SortByName sorts the elements of the deliverables-list alfabetically by buyer's name.
        /// </summary>
        public void SortByName()
        {
            //todo
            myDeliverables.Sort((x, y) => x.Buyer.Name.CompareTo(y.Buyer.Name));
        }

        /// <summary>
        /// SortById sorts the elements of the deliverables-list from a low id to a high id.
        /// </summary>
        public void SortById()
        {
            //todo
            myDeliverables.Sort((x, y) => x.ID.CompareTo(y.ID));
        }

        /// <summary>
        /// SortByAddress sorts the elements of the deliverables-list "alfabetically by street; then by increasing house-number".
        /// So elements with a different street are sorted alfabetically by street.
        /// Elements with the same street are sorted by increasing house-number. 
        /// </summary>

        private static int CompareByAddress(Deliverable a, Deliverable b)
        {
            return (a.Buyer.Street + a.Buyer.Housenumber).CompareTo(b.Buyer.Street + b.Buyer.Housenumber);
        }

        public void SortByAddress()
        {
            //todo
            Comparison<Deliverable> comparison = new Comparison<Deliverable>(CompareByAddress);
            this.myDeliverables.Sort(comparison);
        }

        /// <summary>
        /// SortForPostman sorts the elements of the deliverables-list alfabetically by street,
        /// then by postman-ordered house-numbers.
        /// The postman walks along the street, first the side of the street with the odd numbers (in an increasing order),
        /// then back on the other side of the street for the even house-numbers (in a decreasing order). 
        /// </summary>
        public void SortForPostman()
        {
            //todo
            //myDeliverables.Sort();
            //foreach(Deliverable d in myDeliverables)
            //{
            //if(d.Buyer.Street.CompareTo)
            //}
            SortByAddress();
            this.myDeliverables.Sort(new SortDeliverableForPostman());
        }
        private Deliverable BinarySearchById(int id, int lowindex, int highindex, ref int counter)
        {
            counter++;
            if(lowindex > highindex) return null;
            int m = (lowindex + highindex) / 2;
            if(myDeliverables[m].ID == id) return myDeliverables[m];
            if(myDeliverables[m].ID < id) return BinarySearchById(id, m + 1, highindex, ref counter);
            return BinarySearchById(id, lowindex, m - 1, ref counter);
        }
        private Deliverable BinarySearchByName(string name, int lowindex, int highindex)
        {
            if (lowindex > highindex) return null;
            int m = (lowindex + highindex) / 2;
            if (myDeliverables[m].Buyer.Name.Contains(name)) return myDeliverables[m];
            else if (myDeliverables[m].Buyer.Name.CompareTo(name) == -1) return BinarySearchByName(name, m + 1, highindex);
            else return BinarySearchByName(name, lowindex, m - 1);
        }
        public List<Deliverable> FindAllDeliverables(String buyersName)
        {
            Deliverable d = FindDeliverable(buyersName);
            List<Deliverable> temp = new List<Deliverable>();
            int lowindex, highindex, m;
            lowindex = 0;
            highindex = myDeliverables.Count - 1;


            while (lowindex <= highindex)
            {
                m = (lowindex + highindex) / 2;
                if (myDeliverables[m].Buyer.Name == d.Buyer.Name && !temp.Contains(myDeliverables[m]))
                {
                        temp.Add(myDeliverables[m]);
                }
                if (myDeliverables[m].Buyer.Name.CompareTo(d.Buyer.Name) == -1 || (myDeliverables[m + 1].Buyer.Name == d.Buyer.Name && !temp.Contains(myDeliverables[m + 1]) && !temp.Contains(myDeliverables[m + 1]))) lowindex = m + 1;
                if (myDeliverables[m].Buyer.Name.CompareTo(d.Buyer.Name) == 1 || (myDeliverables[m - 1].Buyer.Name == d.Buyer.Name && !temp.Contains(myDeliverables[m - 1]) && temp.Contains(myDeliverables[m - 1]))) highindex = m - 1;
            }
            return temp;
        }
    }
}
