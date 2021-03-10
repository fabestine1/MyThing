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
        Store myStore;
        Genres genre;
        Genres displayGenre;
        List<Book> books;

        public Form1()
		{
			InitializeComponent();
            myStore = new Store("My store");
            Text = myStore.Name;
			// You can use this dummy data to test your application, delete the asterisk: "*" at the front.
			myStore.AddBook("Cook with", "Jamie Oliver", Genres.Cooking, 40.99, 10);
			myStore.AddBook("the Great Gatsby", "F. Scott", Genres.Drama, 5.99, 10);
			myStore.AddBook("The two towers", "Tolkien", Genres.Fantasy, 11.99, 10);
			myStore.AddBook("The two towers", "Tolkien", Genres.Fantasy, 11.99, 10);
			myStore.AddBook("It", "Stephen King", Genres.Horror, 11.99, 10);
			//*/
		}

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            if(myStore.GetBook(textBoxTitleAdd.Text, textBoxAuthorAdd.Text) != null)
            {
                MessageBox.Show("This book already exists!");
            }
            else
            {
                myStore.AddBook(textBoxTitleAdd.Text, textBoxAuthorAdd.Text, genre, Convert.ToDouble(numericUpDownAddPrice.Value), Convert.ToInt32(numCopiesAdd.Value));
                Book book = myStore.GetBook(textBoxTitleAdd.Text, textBoxAuthorAdd.Text);
                listBoxBooks.Items.Add(book.AsString());
            }
        }

        private void radioButtonComedyAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonComedyAdd.Checked)
            {
                genre = Genres.Comedy;
            }
        }

        private void radioButtonDramaAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDramaAdd.Checked)
            {
                genre = Genres.Drama;
            }
        }

        private void radioButtonHorrorAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHorrorAdd.Checked)
            {
                genre = Genres.Horror;
            }
        }

        private void radioButtonCookingAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCookingAdd.Checked)
            {
                genre = Genres.Cooking;
            }
        }

        private void radioButtonFantasyAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFantasyAdd.Checked)
            {
                genre = Genres.Fantasy;
            }
        }

        private void buttonShowAllBooks_Click(object sender, EventArgs e)
        {
            listBoxBooks.Items.Clear();
            if (radioButtonAllBooks.Checked)
            {
                books = myStore.GetListOfBooks();
            }
            else
            {
                books = myStore.GetListOfBooks(displayGenre);
            }
            foreach(Book book in books)
            {
                listBoxBooks.Items.Add(book.AsString());
            }
        }

        private void radioButtonCooking_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCooking.Checked)
            {
                displayGenre = Genres.Cooking;
            }
        }

        private void radioButtonFantasy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFantasy.Checked)
            {
                displayGenre = Genres.Fantasy;
            }
        }

        private void radioButtonComedy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonComedy.Checked)
            {
                displayGenre = Genres.Comedy;
            }
        }

        private void radioButtonDrama_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDrama.Checked)
            {
                displayGenre = Genres.Drama;
            }
        }

        private void radioButtonHorror_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHorror.Checked)
            {
                displayGenre = Genres.Horror;
            }
        }

        private void buttonSellBook_Click(object sender, EventArgs e)
        {
            if(listBoxBooks.SelectedIndex != -1)
            {
                MessageBox.Show(myStore.SellBook(books[listBoxBooks.SelectedIndex].Title, books[listBoxBooks.SelectedIndex].Author));
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myStore.GetHistory());
        }
    }
}