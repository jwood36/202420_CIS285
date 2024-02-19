using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCal
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate the frmAbout form
            frmAbout aboutForm = new frmAbout();



            // Show the frmAbout form
            Application.Run(aboutForm);


            // You can add menu items to the MenuStrip here if needed


        }



    }
}
