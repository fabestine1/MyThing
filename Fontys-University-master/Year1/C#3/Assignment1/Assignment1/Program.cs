using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Student st = new Student(5,"sdf" , 234, 0, "dsf", 324);
            st.StartAnotherSchoolyear();
            st.StartAnotherSchoolyear();
            st.StartAnotherSchoolyear();

            Teacher teacher = new Teacher(5, "sdf", 234, 0, 235234, Function.teacher2);
            teacher.StartAnotherSchoolyear();
            teacher.StartAnotherSchoolyear();
            teacher.StartAnotherSchoolyear();

            Console.WriteLine(st.YearsAtSchool);
            Console.WriteLine(teacher.YearsAtSchool);
        }
    }
}
