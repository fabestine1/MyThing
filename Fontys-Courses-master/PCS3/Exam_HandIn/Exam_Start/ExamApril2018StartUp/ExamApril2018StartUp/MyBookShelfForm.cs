using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApril2018StartUp
{
    public partial class MyBookShelfForm : Form
    {
        private void btnAllReadables_Click(object sender, EventArgs e)
        {
            // Assignment 3a
            lbReadables.Items.Clear();
            foreach(Readable r in myBookShelf.GetAllReadables())
            {
                lbReadables.Items.Add(r);
            }
        }

        private void btnAllBorrowedBooks_Click(object sender, EventArgs e)
        {
            // Assignment 3b
            lbReadables.Items.Clear();
            foreach (Readable r in myBookShelf.GetAllBorrowedReadables())
            {
                lbReadables.Items.Add(r);
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            // Assignment 3c
            try
            {
                if(tbBorrower.Text != "" && tbBorrowId.Text != "")
                {
                    myBookShelf.BorrowReadable(Convert.ToInt32(tbBorrowId.Text), tbBorrower.Text);
                }
                else
                {
                    MessageBox.Show("You have to fill in the fields.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The format of the input fields is incorrect.");
            }
            catch (NotABorrowableException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Assignment 3d
            try
            {
                if (tbReceiveId.Text != "")
                {
                    myBookShelf.ReceiveReadable(Convert.ToInt32(tbReceiveId.Text));
                }
                else
                {
                    MessageBox.Show("You have to fill in the ID.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The format of the ID field is incorrect.");
            }
            catch (NotABorrowableException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            // assignment 3e
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    myBookShelf.GenerateOverviewInFile(sfd.FileName);
                }
                else
                {
                    MessageBox.Show("Nothing is saved.");
                }
            }
        }

        //=============================== The code BELOW will not be graded ===============================

        BookShelf myBookShelf = new BookShelf();
        public MyBookShelfForm()
        {
            InitializeComponent();
            GenerateDummyReadables();
        }

        /// <summary>
        /// This method will generate dummy data to help you test your app during this exam.
        /// </summary>
        private void GenerateDummyReadables()
        {
            myBookShelf.AddReadable(new Book(3501, "the Lord of the Rings 1", "J.R.R. Tolkien"));
            myBookShelf.AddReadable(new Magazine(22, "Quest", 20));
            myBookShelf.AddReadable(new Book(12, "the Hobbit", "J.R.R. Tolkien"));
            myBookShelf.AddReadable(new NewsPaper(1234, "the New York Times","20-12-2012"));
            myBookShelf.AddReadable(new Book(491, "Alice in wonderland", "Lewis Carroll"));
            myBookShelf.AddReadable(new Magazine(491, "Game Informer", 12));
            myBookShelf.AddReadable(new NewsPaper(3307, "the Guardian", "31-12-2017"));
            myBookShelf.AddReadable(new Book(60, "Moby Dick", "Herman Melville"));
            myBookShelf.AddReadable(new Book(131, "Frankenstein", "Nick Dear"));
            myBookShelf.AddReadable(new Magazine(1523, "Quest", 21));
            myBookShelf.AddReadable(new NewsPaper(872, "Daily news", "6-6-1999"));
            myBookShelf.AddReadable(new Book(19, "Dracula", "Bram Stoker"));
            myBookShelf.AddReadable(new Book(2053, "Gatsby", "F. Scott Fitsgerald"));
        }
    }
}
