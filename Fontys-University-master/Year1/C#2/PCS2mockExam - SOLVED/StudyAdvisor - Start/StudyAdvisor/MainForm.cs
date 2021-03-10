using System.Drawing;

namespace StudyAdvisor
{
    using System;
    using System.Windows.Forms;
    
    public partial class MainForm : Form
    {
        private Student student;

        public MainForm()
        {
            student = new Student("Kaloyan", 123);
            Text = $"Study Advisor for {this.student.Name} ({this.student.Number})";
            InitializeComponent();
        }

        private void buttonAddModule_Click(object sender, EventArgs e)
        {
            Module module = student.AddModule(textBoxCode.Text, Convert.ToInt32(textBoxEC),
                Convert.ToInt32(numericUpDownMark.Value), checkBoxPractical.Checked);

            listBoxModules.Items.Add(module.AsString());
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            student.RemoveModule(listBoxModules.SelectedIndex);
            listBoxModules.ClearSelected();
        }

        private void buttonAdvice_Click(object sender, EventArgs e)
        {
            int Mark10 = this.student.NrOfModulesWithExamMark(10);
            int Mark9 = this.student.NrOfModulesWithExamMark(9);
            int Mark8 = this.student.NrOfModulesWithExamMark(8);
            int Mark7 = this.student.NrOfModulesWithExamMark(7);
            int Mark6 = this.student.NrOfModulesWithExamMark(6);
            int Mark5 = this.student.NrOfModulesWithExamMark(5);
            int Mark4 = this.student.NrOfModulesWithExamMark(4);
            int Mark3 = this.student.NrOfModulesWithExamMark(3);
            int Mark2 = this.student.NrOfModulesWithExamMark(2);
            int Mark1 = this.student.NrOfModulesWithExamMark(1);

            labelMark10.Text = Mark10.ToString();
            labelMark9.Text = Mark9.ToString();
            labelMark8.Text = Mark8.ToString();
            labelMark7.Text = Mark7.ToString();
            labelMark6.Text = Mark6.ToString();
            labelMark5.Text = Mark5.ToString();
            labelMark4.Text = Mark4.ToString();
            labelMark3.Text = Mark3.ToString();
            labelMark2.Text = Mark2.ToString();
            labelMark1.Text = Mark1.ToString();

            labelTotalGainedEC.Text = ((Mark10 + Mark9 + Mark8 + Mark7 + Mark6 + Mark5 + Mark4 + Mark3 
                + Mark2 + Mark1) /10).ToString();

        }

        private void buttonRecommendation_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxMaxPossibeEC.Text) <= 0)
            {
                MessageBox.Show("Has to be greather than 0!");
            }
            else
            {
                string recommendation = student.GetRecommendation(Convert.ToInt32(textBoxMaxPossibeEC.Text)).ToString();
                labelRecommendation.Text = recommendation;

                if (recommendation == "POSITIVE")
                {
                    labelRecommendation.ForeColor = Color.Green;
                }
                else if (recommendation == "CONDITIONAL_POSITIVE")
                {
                    labelRecommendation.ForeColor = Color.Orange;
                }
                else if (recommendation == "CONDITIONAL_NEGATIVE")
                {
                    labelRecommendation.ForeColor = Color.Coral;
                }
                else 
                {
                    labelRecommendation.ForeColor = Color.Red;
                }
            }

        }
    }
}
