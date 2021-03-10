using System.Drawing;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class EmployeeCosts : UserControl
    {
        Color workingColor = Color.LawnGreen;
        public EmployeeCosts(Worker worker)
        {
            InitializeComponent();
            nameLbl.Text = worker.FirstName + " " + worker.LastName;
            wageLbl.Text = worker.GetWage().ToString();
            costsLbl.Text = (Worker.TotalHoursWeekWorked(worker.Id) * worker.GetWage()).ToString();

            ChangeColors(worker.Id);
        }

        private void ChangeColors(int id)
        {
            if (Department.GetWorkersShifts(id)[0]) mondayBttn.BackColor = workingColor;
            if (Department.GetWorkersShifts(id)[1]) tuesdayBttn.BackColor = workingColor;
            if (Department.GetWorkersShifts(id)[2]) wednesdayBttn.BackColor = workingColor;
            if (Department.GetWorkersShifts(id)[3]) thursdayBttn.BackColor = workingColor;
            if (Department.GetWorkersShifts(id)[4]) fridayBttn.BackColor = workingColor;
            if (Department.GetWorkersShifts(id)[5]) saturdayBttn.BackColor = workingColor;
            if (Department.GetWorkersShifts(id)[6]) sundayBttn.BackColor = workingColor;
        }
    }
}
