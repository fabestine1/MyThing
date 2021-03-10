using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StudentWiseClient
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
            Application.ThreadException += ShowExceptionHandler;
            Login firstForm = new Login();
            firstForm.Show();
            Application.Run();
        }

        static public void ExitIfLastForm()
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        static void ShowExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(
                e.Exception.Message,
                null,
                MessageBoxButtons.OK,                   
                e.Exception is ApplicationException ? MessageBoxIcon.Warning : MessageBoxIcon.Error
            );
        }
    }
}
