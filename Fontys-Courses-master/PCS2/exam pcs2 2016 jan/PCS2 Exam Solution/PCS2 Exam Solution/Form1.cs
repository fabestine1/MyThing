using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS2_Exam_Solution
{
	public partial class Form1 : Form
	{
		Store myStore;
		public Form1()
		{
			InitializeComponent();
			myStore = new Store("John Doe");
			Text = myStore.Name + "'s Bookstore";
			// You can use this dummy data to test your application, delete the asterisk: "*" at the front.
			myStore.AddBook("Cook with", "Jamie Oliver", Genres.COOKING, 40.99, 10);
			myStore.AddBook("the Great Gatsby", "F. Scott", Genres.DRAMA, 5.99, 10);
			myStore.AddBook("The two towers", "Tolkien", Genres.FANTASY, 11.99, 10);
			myStore.AddBook("The two towers", "Tolkien", Genres.FANTASY, 11.99, 10);
			myStore.AddBook("It", "Stephen King", Genres.HORROR, 11.99, 10);
			// */
		}
		private Genres GetGenreAdd()
		{
			if (radioButtonComedyAdd.Checked)
			{
				return Genres.COMEDY;
			}
			else if (radioButtonCookingAdd.Checked)
			{
				return Genres.COOKING;
			}
			else if (radioButtonDramaAdd.Checked)
			{
				return Genres.DRAMA;
			}
			else if (radioButtonFantasyAdd.Checked)
			{
				return Genres.FANTASY;
			}
			return Genres.HORROR;
		}
		private void buttonAddBook_Click(object sender, EventArgs e)
		{
			string title = textBoxTitleAdd.Text;
			string author = textBoxAuthorAdd.Text;
			Genres genre = GetGenreAdd();
			double price = Convert.ToDouble(numericUpDownAddPrice.Value);
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
			Genres myGenre;
			if (radioButtonComedy.Checked)
			{
				myGenre = Genres.COMEDY;
			}
			else if (radioButtonCooking.Checked)
			{
				myGenre = Genres.COOKING;
			}
			else if (radioButtonDrama.Checked)
			{
				myGenre = Genres.DRAMA;
			}
			else if (radioButtonFantasy.Checked)
			{
				myGenre = Genres.FANTASY;
			}
			else
			{
				myGenre = Genres.HORROR;
			}
			return myStore.GetListOfBooks(myGenre);
		}
		private void buttonDisplayBooks_Click(object sender, EventArgs e)
		{
			listBoxBooks.Items.Clear();
			foreach (Book b in GetListOfBooks())
			{
				listBoxBooks.Items.Add(b.AsString());
			}
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