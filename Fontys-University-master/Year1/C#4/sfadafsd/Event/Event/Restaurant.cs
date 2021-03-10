using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;
namespace Event
{
    public partial class Restaurant : Form
    {

        private MySqlConnection dbConnection;
        private bool isEmpty17;
        private string value17;
        public Restaurant()
        {
            InitializeComponent();

        }
        Form opener;

        public Restaurant(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;


        }
        private void Reader_Tag(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag == "28007bcb0f")
            {
                lblStatus.Text = "Approved";
                lblStatus.ForeColor = Color.Green;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
           
            }
            //MessageBox.Show("dsd");
        }


        private void Restaurant_Load(object sender, EventArgs e)
        {

            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);

            String sqlStatement = "SELECT * FROM product;";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<string>();

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            while (articlesReader.Read())
            {
                var name = articlesReader[1].ToString();
                var price = articlesReader[2].ToString();
                var ingredients = articlesReader[5].ToString();
                list.Add(name);
                list.Add(price);
                list.Add(ingredients);
            }
            salad1Name.Text = list[0];
            salad1Price.Text = list[1];
            salad1Ing.Text = list[2];

            salad2Name.Text = list[3];
            salad2Price.Text = list[4];
            salad2Ing.Text = list[5];

            salad3Name.Text = list[6];
            salad3Price.Text = list[7];
            salad3Ing.Text = list[8];

            salad4Name.Text = list[9];
            salad4Price.Text = list[10];
            salad4Ing.Text = list[11];

            dess1Name.Text = list[12];
            dess1Price.Text = list[13];
            dess1Ing.Text = list[14];

            dess2Name.Text = list[15];
            groupBox.Text = list[16];
            dess2Ing.Text = list[17];

            dess3Name.Text = list[18];
            dess3Price.Text = list[19];
            dess3Ing.Text = list[20];

            dess4Name.Text = list[21];
            dess4Price.Text = list[22];
            dess4Ing.Text = list[23];

            meals1Name.Text = list[24];
            meals1Price.Text = list[25];
            meals1Ing.Text = list[26];

            meals2Name.Text = list[27];
            meals2Price.Text = list[28];
            meals2Ing.Text = list[29];

            meals3Name.Text = list[30];
            meals3Price.Text = list[31];
            meals3Ing.Text = list[32];

            meals4Name.Text = list[33];
            meals4Price.Text = list[34];
            meals4Ing.Text = list[35];

            drink1Name.Text = list[36];
            drink1Price.Text = list[37];

            drink2Name.Text = list[39];
            drink2Price.Text = list[40];

            drink3Name.Text = list[42];
            drink3Price.Text = list[43];

            drink4Name.Text = list[45];
            drink4Price.Text = list[46];

            drink5Name.Text = list[48];
            drink5Price.Text = list[49];

            drink6Name.Text = list[51];
            drink6Price.Text = list[52];

            drink7Name.Text = list[54];
            drink7Price.Text = list[55];

            drink8Name.Text = list[57];
            drink8Price.Text = list[58];

            drink9Name.Text = list[60];
            drink9Price.Text = list[61];

            drink10Name.Text = list[63];
            drink10Price.Text = list[64];

            drink11Name.Text = list[66];
            drink11Price.Text = list[67];

            drink12Name.Text = list[69];
            drink12Price.Text = list[70];




            //For Creating new item!

            GroupBox gb = new GroupBox();
            Button b = new Button();
            Label lb1 = new Label();
            Label lb2 = new Label();
            Label lb3 = new Label();
            PictureBox pb = new PictureBox();
            lb1.Text = "asd1";
            lb2.Text = "asd2";
            lb3.Text = "asd3";
            b.Text = "add";
            lb1.Location = new Point(12, 30);
            lb2.Location = new Point(12, 66);
            lb3.Location = new Point(12, 88);
            gb.Controls.Add(b);
            gb.Controls.Add(lb1);
            gb.Controls.Add(lb2);
            gb.Controls.Add(lb3);
            gb.Location = new Point(27, 632);
            gb.Size = new Size(252, 227);
            groupBox5.Controls.Add(gb);

            dbConnection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String sqlUpdate = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 1";
            //sqlCommand = new MySqlCommand(sqlUpdate, dbConnection);
            //String sqlStatement = "SELECT * FROM `product` as p \r\nJOIN storageproducts as sp on p.StorageProductId=sp.StorageProductId\r\nWHERE p.name=\'@a\';";
            //sqlCommand.Parameters.AddWithValue("@a", salad1Name.Text);

            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 1;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {salad1Name.Text} Price: {salad1Price.Text}");

            dbConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 2;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {salad2Name.Text} Price: {salad2Price.Text}");

            dbConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                groupBox5.Visible = true;
                groupBox.Visible = false;
                groupBox11.Visible = false;
                groupBox16.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                groupBox.Visible = true;
                groupBox5.Visible = false;
                groupBox11.Visible = false;
                groupBox16.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                groupBox.Visible = false;
                groupBox5.Visible = false;
                groupBox11.Visible = true;
                groupBox16.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                groupBox.Visible = false;
                groupBox5.Visible = false;
                groupBox11.Visible = false;
                groupBox16.Visible = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 3;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {salad3Name.Text} Price: {salad3Price.Text}");

            dbConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 4;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {salad4Name.Text} Price: {salad4Price.Text}");

            dbConnection.Close();
        }

        private void btnDess1_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 5;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {dess1Name.Text} Price: {dess1Price.Text}");

            dbConnection.Close();
        }

        private void btnDess2_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 6;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {dess2Name.Text} Price: {dess2Price.Text}");

            dbConnection.Close();
        }

        private void btnDess3_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 7;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {dess3Name.Text} Price: {dess3Price.Text}");

            dbConnection.Close();
        }

        private void btnDess4_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 8;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {dess4Name.Text} Price: {dess4Price.Text}");

            dbConnection.Close();
        }

        private void btnMeal1_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 9;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {meals1Name.Text} Price: {meals1Price.Text}");

            dbConnection.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 10;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {meals2Name.Text} Price: {meals2Price.Text}");

            dbConnection.Close();
        }

        private void btnMeals3_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 11;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {meals3Name.Text} Price: {meals3Price.Text}");

            dbConnection.Close();
        }

        private void btnMeals4_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 12;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {meals4Name.Text} Price: {meals4Price.Text}");

            dbConnection.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            isEmpty17 = textBox1.Text == string.Empty;
            value17 = textBox1.Text;
            lbItems.Items.Add($"Name: {drink1Name.Text} Price: {drink1Price.Text}");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 14;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink2Name.Text} Price: {drink2Price.Text}");

            dbConnection.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 15;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink3Name.Text} Price: {drink3Price.Text}");

            dbConnection.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 16;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink4Name.Text} Price: {drink4Price.Text}");

            dbConnection.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 17;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink5Name.Text} Price: {drink5Price.Text}");

            dbConnection.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 18;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink6Name.Text} Price: {drink6Price.Text}");

            dbConnection.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 19;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink7Name.Text} Price: {drink7Price.Text}");

            dbConnection.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 20;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink8Name.Text} Price: {drink8Price.Text}");

            dbConnection.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 21;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink9Name.Text} Price: {drink9Price.Text}");

            dbConnection.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 22;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink10Name.Text} Price: {drink10Price.Text}");

            dbConnection.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 23;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink11Name.Text} Price: {drink11Price.Text}");

            dbConnection.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 24;";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();

            lbItems.Items.Add($"Name: {drink12Name.Text} Price: {drink12Price.Text}");

            dbConnection.Close();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (this.lbItems.SelectedItem != null)
            {
                for (int i = 0; i < lbItems.SelectedItems.Count; i++)
                {
                    lbItems.Items.Remove(lbItems.SelectedItems[i]);
                }
            }
            else
            {
                MessageBox.Show("Please, select items!");
            }
            Refresh();

            
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            string str = "";
            var list = new List<int>();
            foreach (var item in lbItems.Items)
            {
                list.Add(Convert.ToInt32(item.ToString().Split()[3]));
            }

            TotalPrice.Text = list.Sum(x => x).ToString();

            if (isEmpty17)
            {
                String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - 1 Where StorageProductId = 13;";
            
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            
                dbConnection.Open();
                MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
            
            
                dbConnection.Close();
            
            }
            else
            {
                String number = value17;
                String sqlStatement = "Update `storageproducts` Set Quantity = Quantity - " + number + " Where StorageProductId = 13;";
            
                MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            
                dbConnection.Open();
                MySqlDataReader articlesReader = sqlCommand.ExecuteReader();
            
                for (int i = 0; i < Convert.ToInt32(number); i++)
                {
                    lbItems.Items.Add($"Name: {drink1Name.Text} Price: {drink1Price.Text}");
                }
            
                dbConnection.Close();
            }
        }
    }
}
