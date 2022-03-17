using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notepad
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splash());
            Application.Run(new Form1(args));
        }
    }
}
