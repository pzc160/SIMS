using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BackHome
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new BackHome_Student());
               UI.Log_in log_in = new UI.Log_in();
              log_in.ShowDialog();
               if (log_in.DialogResult==DialogResult.OK)
               {
                log_in.Dispose();
                Application.Run(new BackHome_Student());
               }
               else
               {
                log_in.Dispose();
                Application.Run(new BackHome_Manager());
               }
        }
    }
}
