namespace ExamApril2018StartUp
{
    using System.IO;
    using System.Windows.Forms;
    using System.Collections.Generic;

    public class BookShelf
    {
        private List<Readable> readables = new List<Readable>();
        // Provide your answers in the area below.

        public void BorrowReadable(int id, string name)
        {
            foreach (var read in this.readables)
            {
                if (read.Id == id)
                {
                    if (read is Book)
                    {
                        if (!((Book)read).IsBorrowed())
                        {
                            ((Book)read).Borrow(name);
                            MessageBox.Show("You borrowed a book!");
                        }
                        else
                        {
                            throw new NotABorrowableException("This book is already borrowed!");
                        }
                    }
                    else
                    {
                        throw new NotABorrowableException("This readable can not be borrowed!");
                    }
                }
            }
        }

        public void ReceiveReadable(int id)
        {
            foreach (var read in this.readables)
            {
                if (read.Id == id)
                {
                    if (read is Book)
                    {
                        if (((Book)read).IsBorrowed())
                        {
                            ((Book)read).Receive();
                        }
                        else
                        {
                            throw new NotABorrowableException("This book is already received!");
                        }
                    }
                    else
                    {
                        throw new NotABorrowableException("This readable can not be borrowed to be received!");
                    }
                }
            }
        }

        public List<Readable> GetAllBorrowedReadables()
        {
            List<Readable> temp = new List<Readable>();
            foreach (var read in this.readables)
            {
                if (read is Book)
                {
                    if (((Book)read).IsBorrowed())
                    {
                        temp.Add(read);
                    }
                }
            }
            return temp;
        }

        public void GenerateOverviewInFile(string filename)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Book Report:");
                sw.WriteLine("You currently own " + this.readables.Count + " books.");
                sw.WriteLine("You have currently borrowed " + this.GetAllBorrowedReadables().Count + " books.");
                sw.WriteLine("*******************************");
                List<Readable> temp = new List<Readable>();
                foreach (var read in this.readables)
                {
                    if (read is Book)
                    {
                        if (((Book)read).IsBorrowed() || ((Book)read).NumberOfPreviousBorrowers > 0)
                        {
                            temp.Add(read);
                        }
                    }
                }
                foreach (var book in temp)
                {
                    if (((Book)book).IsBorrowed())
                    {
                        sw.WriteLine(((Book)book).Title + " is borrowed " 
                            + ((Book)book).NumberOfPreviousBorrowers + ". "
                            + ((Book)book).CurrentBorrower + " currently borrows this book.");
                    }
                    else
                    {
                        sw.WriteLine(((Book) book).Title + " is borrowed "
                                     + ((Book) book).NumberOfPreviousBorrowers + " times.");
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Something wrong with saving to file");
            }
            finally
            {
                if (sw != null)
                    sw.Close();
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
