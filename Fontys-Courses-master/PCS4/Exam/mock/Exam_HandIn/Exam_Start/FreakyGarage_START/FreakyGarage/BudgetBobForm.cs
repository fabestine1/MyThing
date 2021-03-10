using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreakyGarage
{
    public partial class BudgetBobForm : Form
    {
        public BudgetBobForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        public void showCheapCar(Garage g, Car c, String reason)
        {
            lbBudgetBob.Items.Add("Garage " + g.Name + " sells a cheap car " + c.Brand + " " + c.Type + " for price " + c.CurrentPrice + ". Reason for notification: " + reason);
        }
    }
}
