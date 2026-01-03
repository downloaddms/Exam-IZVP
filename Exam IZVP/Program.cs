using System;
using System.Windows.Forms;
using Exam_IZVP.UI;

namespace Exam_IZVP
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}