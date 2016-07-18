using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PKUAutoGateway.GUI;

namespace PKUAutoGateway
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmMain());
        }
    }
}
