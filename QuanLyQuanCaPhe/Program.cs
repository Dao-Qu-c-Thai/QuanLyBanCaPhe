using QUanLyQuanCaPhe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUanLyQuanCaPhe
{
    internal static class Program
    {
        public static frmMain mainFrm = null;
        public static frmLogin loginFrm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginFrm = new frmLogin();
            Application.Run(loginFrm);
        }
    }
}
