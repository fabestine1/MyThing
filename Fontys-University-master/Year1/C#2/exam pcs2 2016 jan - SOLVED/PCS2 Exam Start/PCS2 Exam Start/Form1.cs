using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS2_Exam_Start
{
	public partial class Form1 : Form
	{
	    private Store myStore;

        public Form1()
		{
			InitializeComponent();
		    myStore = new Store("myStore");
		    Text = myStore.Name + "'s Bookstore";
            
            myStore.AddBook("Cook with", "Jamie Oliver", Genre.COOKING, 40.99m, 10);
			myStore.AddBook("the Great Gatsby", "F. Scott", Genre.DRAMA, 5.99m, 10);
			myStore.AddBook("The two towers", "Tolkien", Genre.FANTASY, 11.99m, 10);
			myStore.AddBook("The two towers", "Tolkien", Genre.FANTASY, 11.99m, 10);
			myStore.AddBook("It", "Stephen King", Genre.HORROR, 11.99m, 10);
        }

        private void buttonShowAllBooks_Click(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
            foreach (Book b in GetListOfBooks())
            {
                listBoxBooks.Items.Add(b.AsString());
            }
        }

	    private Genre GetGenreAdd()
	    {
	        if (radioButtonComedyAdd.Checked)
	        {
	            return Genre.COMEDY;
	        }
	        else if (radioButtonCookingAdd.Checked)
	        {
	            return Genre.COOKING;
	        }
	        else if (radioButtonDramaAdd.Checked)
	        {
	            return Genre.DRAMA;
	        }
	        else if (radioButtonFantasyAdd.Checked)
	        {
	            return Genre.FANTASY;
	        }
	        return Genre.HORROR;
	    }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            string title = textBoxTitleAdd.Text;
            string author = textBoxAuthorAdd.Text;
            Genre genre = GetGenreAdd();
            decimal price = Convert.ToDecimal(numericUpDownAddPrice.Value);
            int amount = Convert.ToInt32(numCopiesAdd.Value);
            bool addedBook = myStore.AddBook(title, author, genre, price, amount);
            if (!addedBook)
            {
                MessageBox.Show("This book already exists!");
            }
        }

	    private List<Book> GetListOfBooks()
	    {
	        if (radioButtonAllBooks.Checked)
	        {
	            return myStore.GetListOfBooks();
	        }
	        Genre myGenre;
	        if (radioButtonComedy.Checked)
	        {
	            myGenre = Genre.COMEDY;
	        }
	        else if (radioButtonCooking.Checked)
	        {
	            myGenre = Genre.COOKING;
	        }
	        else if (radioButtonDrama.Checked)
	        {
	            myGenre = Genre.DRAMA;
	        }
	        else if (radioButtonFantasy.Checked)
	        {
	            myGenre = Genre.FANTASY;
	        }
	        else
	        {
	            myGenre = Genre.HORROR;
	        }
	        return myStore.GetListOfBooks(myGenre);
	    }

        private void buttonSellBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex != -1)
            {
                List<Book> books = GetListOfBooks();
                int index = listBoxBooks.SelectedIndex;
                MessageBox.Show(myStore.SellBook(books[index].Title, books[index].Author));
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myStore.GetHistory());
        }
    }
}