using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace YourNxtHome
{
    internal class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Mainpage());
        }
    }
}