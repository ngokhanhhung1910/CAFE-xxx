
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI // <-- Namespace của bạn là "GUI"
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

            // SỬA DÒNG NÀY:
            Application.Run(new DangNhap());

            // DÒNG CŨ CỦA BẠN LÀ:
            // Application.Run(new Main());
        }
    }
}