using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakinaMeQera
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* var endDate = DateTime.Today.AddDays(1);
             var startDate = DateTime.Today;
             var ts = endDate - startDate;
             var nrIDiteve = ts.Days;*/
            //ts.TotalDays
 


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
