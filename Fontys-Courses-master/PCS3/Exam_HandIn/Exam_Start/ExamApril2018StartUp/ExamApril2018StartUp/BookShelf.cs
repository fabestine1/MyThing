using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamApril2018StartUp
{
    class BookShelf
    {
        private List<Readable> readables = new List<Readable>();
        // Provide your answers in the area below.

        /// <summary>
        /// Borrows a readable
        /// </summary>
        /// <param name="id">ID of the readable to be borrowed</param>
        /// <param name="name">Name of the borrower</param>
        public void BorrowReadable(int id, string name)
        {
            Readable r = GetReadable(id);
            if(r is Book)
            {
                if(!((Book)r).IsBorrowed()){
                    ((Book)r).Borrow(name);
                }
                else throw new NotABorrowableException("The book is already borrowed.");
            }
            else throw new NotABorrowableException("The readable is not borrowable.");
        }

        /// <summary>
        /// Receives a readable
        /// </summary>
        /// <param name="id">ID of the readable to be received</param>
        public void ReceiveReadable(int id)
        {
            Readable r = GetReadable(id);
            if (r is Book)
            {
                if (((Book)r).IsBorrowed())
                {
                    ((Book)r).Receive();
                }
                else throw new NotABorrowableException("The book is already received.");
            }
            else throw new NotABorrowableException("The readable is not borrowable.");
        }

        /// <summary>
        /// Gets all borrowed readables
        /// </summary>
        /// <returns>List of readables</returns>
        public List<Readable> GetAllBorrowedReadables()
        {
            List<Readable> temp = new List<Readable>();
            foreach(Readable r in readables)
            {
                if(r is Book)
                {
                    if (((Book)r).IsBorrowed())
                    {
                        temp.Add(r);
                    }
                }
            }
            return temp;
        }

        /// <summary>
        /// Generates an overview text file
        /// </summary>
        /// <param name="filename">Filename</param>
        public void GenerateOverviewInFile(string filename)
        {
            FileStream fs;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine("Book Report:");
                int[] counters = new int[2]; //to store the two numbers
                foreach(Readable r in readables)
                {
                    if(r is Book)
                    {
                        counters[0]++;
                        if (((Book)r).IsBorrowed()) counters[1]++;
                    }
                }
                sw.WriteLine("You currently own " + counters[0] + " books.");
                sw.WriteLine("You have currently borrowed " + counters[1] + " books.");
                sw.WriteLine("*******************************");
                string holder = "";
                foreach (Readable r in readables)
                {
                    if (r is Book)
                    {
                        holder = r.Title + " is borrowed " + ((Book)r).Borrowers + " times.";
                        if (((Book)r).IsBorrowed())
                        {
                            holder += " " + ((Book)r).Borrower + "currently borrows this book.";
                        }
                        sw.WriteLine(holder);
                    }
                }
            }
            catch (IOException)
            {

            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }


        //=============================== The code BELOW will not be graded ===============================

        /// <summary>
        /// Adds a readable to the list of readables in case there is no readable with the same id or title.
        /// </summary>
        /// <param name="readable">readable to be added</param>
        public void AddReadable(Readable readable)
        {
            foreach (Readable r in readables)
            {
                if (r.Id == readable.Id || r.Title == readable.Title)
                {
                    return;
                }
            }
            readables.Add(readable);
        }

        /// <summary>
        /// Provides all readables to the caller.
        /// </summary>
        /// <returns>List of readables</returns>
        public List<Readable> GetAllReadables()
        {
            return readables;
        }

        /// <summary>
        /// Provides a readable by a given id.
        /// </summary>
        /// <param name="id">the unique identity number of the wanted readable.</param>
        /// <returns>A readable when found, otherwise the null value</returns>
        public Readable GetReadable(int id)
        {
            foreach (Readable r in readables)
            {
                if (r.Id == id)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
