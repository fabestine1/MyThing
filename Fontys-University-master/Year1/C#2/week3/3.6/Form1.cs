using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carClass;

namespace _3._6
{
    public partial class CarApp : Form
    {
        Car porsche = new Car("Porsche", 12312334, 213213);
        Car mustang = new Car("Mustang", 123123, 2132);
        Car alias = new Car();

        public CarApp()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {          
            alias.UpdateCar(int.Parse(this.nudTanked.Text), int.Parse(this.tbLitersInCar.Text),
                int.Parse(this.tbTotalMileage.Text));
            this.lbMileage.Text = alias.LatestMileage.ToString();
        }

        private void rbPorsche_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rbMustang.Checked == true)
            {
                alias = mustang;
            }
            if(this.rbPorsche.Checked == true)
            {
                alias = porsche;
            }

            alias.Initialize(alias, lbBrand, lbMileage, pbCar);
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            this.lbEfficiency.Text = alias.Efficiency();
        }
    }
}
