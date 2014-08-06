using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // For UI Thread Exceptions
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler);

            //Force all windows forms erros to go through our handler
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // for Non UI thread Exceptions
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PedometerWin());
            //Application.Run(new Form1());
        }

        static void GlobalExceptionHandler(object sender, EventArgs args)
        {
            // Log the Issue
            MessageBox.Show("There was a Problem With This Application. Please Contact Support");
            System.Windows.Forms.Application.Exit();
        }
    }
}
