using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab2
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
        }

        public static double cos(double a,double w,double z,double c)
        {

            double x = a*Math.Cos(w*z + c);
            return x;
        }
    }
}
