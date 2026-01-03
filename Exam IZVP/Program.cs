using System;
using System.Windows.Forms;

namespace Exam_IZVP
{
    internal static class Program
    {
        /// <summary>
        /// Головна точка входу для програми
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ініціалізація папок
            InitializeFolders();

            // Запуск головної форми
            Application.Run(new MainForm());
        }

        static void InitializeFolders()
        {
            // Створення необхідних папок, якщо їх немає
            string[] folders = { "Data", "Exports", "Reports", "Templates" };
            foreach (var folder in folders)
            {
                if (!System.IO.Directory.Exists(folder))
                    System.IO.Directory.CreateDirectory(folder);
            }
        }
    }
}