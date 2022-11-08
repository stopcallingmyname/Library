using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fiku_
{
    static class Program
    {
        

        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow main = new mainWindow();
            Application.Run(main);
        }
    }
}
