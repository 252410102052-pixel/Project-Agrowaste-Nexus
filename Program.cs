using AgroWasteNexus.Forms;
using System;
using System.Windows.Forms;

namespace AgroWasteNexus
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}