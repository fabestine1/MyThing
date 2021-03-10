using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class DepartmentActions : Form
    {
        static string morning = "morning";
        static string afternoon = "afternoon";
        static string evening = "evening";

        public DepartmentActions()
        {
            InitializeComponent();
            LoadDepartments();
            LoadPeople();
        }

        private void LoadPeople()
        {
            List<Worker> people = Worker.GetAllEmployees();
            PopulatePeople(people);
        }

        private void LoadDepartments()
        {
            PopulateDepartments(Department.GetAllDepartments(), departmentsCmbbxAddingStock);
            PopulateDepartments(Department.GetAllDepartments(), departmentAvailableCmbbx);

        }

        private void PopulateDepartments(List<Department> departments, ComboBox combobox)
        {
            foreach (Department d in departments)
                combobox.Items.Add(new DepartmentComboBoxItem(d));
        }

        private string GetDataForLabel(int having, int total)
        {
            return $"{having} out of {total}";
        }

        private void departmentsCmbbxAddingStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxAddingStock.SelectedItem).Id;
            int neededPeople = Department.GetNeededPeopleCount(departmentId);

            int[] morningPeople = Department.GetWorkersCountFor(departmentId, morning);
            int[] afternoonPeople = Department.GetWorkersCountFor(departmentId, afternoon);
            int[] eveningPeople = Department.GetWorkersCountFor(departmentId, evening);

            List<WordaysControl> controls = new List<WordaysControl>();
            controls.Clear();
            controls.Add(new WordaysControl(morningPeople, neededPeople, morning));
            controls.Add(new WordaysControl(afternoonPeople, neededPeople, afternoon));
            controls.Add(new WordaysControl(eveningPeople, neededPeople, evening));

            flpDays.Controls.Clear();
            foreach (WordaysControl day in controls)
            {
                flpDays.Controls.Add(day);
            }
            neededWorkersCount.Text = neededPeople.ToString();
        }

        private void departmentAvailableCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentId = ((DepartmentComboBoxItem)departmentAvailableCmbbx.SelectedItem).Id;
            List<Worker> people = Worker.GetAllEmployeesFromDepartment(departmentId);
            PopulatePeople(people);
        }

        private void PopulatePeople(List<Worker> people)
        {
            availablePanel.Controls.Clear();
            foreach (Worker w in people)
            {
                List<EmployeeCosts> controls = new List<EmployeeCosts>();
                controls.Clear();
                controls.Add(new EmployeeCosts(w));

                flpDays.Controls.Clear();
                foreach (EmployeeCosts costs in controls)
                {
                    availablePanel.Controls.Add(costs);
                }
            }
        }
    }
}
