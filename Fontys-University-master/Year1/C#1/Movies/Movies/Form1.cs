namespace Movies
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private MovieCollection collection = new MovieCollection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(textBox1.Text);
            movie.Director = textBox2.Text;
            movie.Location = textBox4.Text;
            movie.Year = Convert.ToInt32(numericUpDown1.Value);
            movie.MovieGerne = (Movie.Genre)comboBox1.SelectedIndex;

            collection.Add(movie);
            listBox1.Items.Add(movie.GetInfo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listMovies = collection.Search(textBox3.Text);

            listBox1.Items.Clear();
            foreach (var listMovie in listMovies)
            {
                listBox1.Items.Add(listMovie.GetInfo());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            collection.Load();
            foreach (var movie in collection.GetAll())
            {
                listBox1.Items.Add(movie);  
            }
            for (Movie.Genre genre = Movie.Genre.Action; genre < Movie.Genre.LAST; genre++)
            {
                comboBox1.Items.Add(genre);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            collection.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Movie movie in collection.GetAll())
            {
                listBox1.Items.Add(movie.GetInfo());
            }
        }
    }
}
