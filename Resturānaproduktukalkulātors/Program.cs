using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturānaproduktukalkulātors
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point(10, 80);
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(form1.Width, 80);
            form1.Show();

            Application.Run();
        }
    }
}
