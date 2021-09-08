
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CreadorDeCarpetas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            int process = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length;
            if (process > 1)
            {
                SetForegroundWindow(process);
                MessageBox.Show("Ya hay una instancia en ejecuion!", "Error, programa ya abierto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set DPI AWARE
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Start();
        }

        public static void Start()
        {
            Application.Run(new MainForm());
        }

        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);
        [DllImport("User32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
