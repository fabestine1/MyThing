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
    public partial class Materials : Form
    {
        private MySqlConnection dbConnection;
        RFID reader;
        public Materials()
        {
            InitializeComponent();
        }
        Form opener;
        public Materials(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            string dbConnectionInfo =
                "server=studmysql01.fhict.local;" +
                "database=dbi378522;" +
                "user id=dbi378522;" +
                "password=Tia8W8a47Z;";
            dbConnection = new MySqlConnection(dbConnectionInfo);

            String sqlStatement = "SELECT * FROM material as m JOIN loan as l on l.LoanId = m.LoanId JOIN materialtype mt on mt.MaterialTypeId = m.MaterialTypeId";
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);
            var list = new List<string>();

            dbConnection.Open();
            MySqlDataReader materialsReader = sqlCommand.ExecuteReader();

            while (materialsReader.Read())
            {
                var materialID = materialsReader[0].ToString();
                var name = materialsReader[9].ToString();
                var price = materialsReader[10].ToString();
                var returned = materialsReader[2].ToString();

                list.Add(materialID);
                list.Add(name);
                list.Add(price);
                list.Add(returned);
            }
            //mtrl3Name.Text = list[0];
            //label3.Text = list[1];
            label5.Text = list[0];

            dbConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(label5.Text);
            String sqlStatement = "Update `material` Set Returned = 1 Where MaterialID = " + number + ";";

            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, dbConnection);

            dbConnection.Open();
            MySqlDataReader articlesReader = sqlCommand.ExecuteReader();


        }

        private void btnMtrl1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add($"MaterialID 1  Name: ewq Price: 123");
        }

        private void materialsGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
