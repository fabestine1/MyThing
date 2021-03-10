namespace ExamApril2018StartUp
{
    using System;
    using System.Windows.Forms;

    public partial class MyBookShelfForm : Form
    {
        private void btnAllReadables_Click(object sender, EventArgs e)
        {
            // Assignment 3a
            lbReadables.Items.Clear();
            foreach (var readable in myBookShelf.GetAllReadables())
            {
                lbReadables.Items.Add(readable.ToString());
            }
        }

        private void btnAllBorrowedBooks_Click(object sender, EventArgs e)
        {
            // Assignment 3b
            lbReadables.Items.Clear();
            foreach (var readable in myBookShelf.GetAllBorrowedReadables())
            {
                lbReadables.Items.Add(readable.ToString());
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            // Assignment 3c
            string borrower = tbBorrower.Text;
            int id = Convert.ToInt32(tbBorrowId.Text);
            var read = this.myBookShelf.GetReadable(id);

            if (read != null)
            {
                foreach (var readable in this.myBookShelf.GetAllReadables())
                {
                    if (readable.Id == id)
                    {
                        if (readable is Book)
                        {
                            if (!((Book)readable).IsBorrowed())
                            {
                                ((Book)readable).Borrow(borrower);
                                MessageBox.Show("This readable successfully has been borrowed!!!");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("This readable is already borrowed!!!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("This readable is not borrowable!!!");
                            return;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("There is not a readable with this Id!!!");
                return;
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Assignment 3d
            int id = Convert.ToInt32(tbReceiveId.Text);
            var read = this.myBookShelf.GetReadable(id);

            if (read != null)
            {
                foreach (var readable in this.myBookShelf.GetAllReadables())
                {
                    if (readable.Id == id)
                    {
                        if (readable is Book)
                        {
                            if (((Book) readable).IsBorrowed())
                            {
                                ((Book) readable).Receive();
                                MessageBox.Show("This readable successfully has been received!!!");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("This readable is already received!!!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("This readable is not borrowable to be received!!!");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There is not a readable with this Id!!!");
                return;
            }
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            // assignment 3e
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.myBookShelf.GenerateOverviewInFile(this.saveFileDialog1.FileName);
                MessageBox.Show("You successfully saved the file!!!");
            }
            else
            {
                MessageBox.Show("Nothing saved, since you pressed the CANCEL-button.");
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
            myBookShelf.AddReadable(new NewsPaper(1234, "the New York Times", "20-12-2012"));
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
