using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tree<Test> tree = new Tree<Test>();
            tree.Add(new Test(5));
            tree.Add(new Test(2));
            tree.Add(new Test(3));
            tree.Add(new Test(-1));
            tree.Add(new Test(1));
            tree.Add(new Test(0));
            tree.Add(new Test(-2));
            tree.Remove(new Test(2));
            Test[] tests = tree.ToArray();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}