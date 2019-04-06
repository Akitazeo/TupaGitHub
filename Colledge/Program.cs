using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colledge
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autorization());
            if (Autorization.getActiveUser() > 0) Application.Run(new Menu());
            if ((Autorization.getActiveUser() == 0)) Application.Run(new Autorization());
        }
    }
}
