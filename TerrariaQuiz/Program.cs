using System.Threading;
using System.Windows.Forms;
using System;
using TerrariaQuiz;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Checking if an instance is already running
        bool createdNew;
        using (Mutex mutex = new Mutex(true, "RunningInstanceCheck", out createdNew))
        {
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmSplashScreen());
            }
            else
            {
                // Another instance is already running
                MessageBox.Show("Another instance of the application is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
