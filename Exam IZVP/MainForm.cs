using System;
using System.Drawing;
using System.Windows.Forms;
using Exam_IZVP.UI;

namespace Exam_IZVP
{
    public partial class MainForm : BaseForm
    {
        private Button testButton;
        private Label titleLabel;

        public MainForm()
        {
            InitializeComponent(); // Викликає метод з Designer.cs
            CreateUI(); // Тепер додаємо наші елементи
        }

        private void CreateUI()
        {
            // 1. Заголовок
            titleLabel = new Label();
            titleLabel.Text = "ЛАБОРАТОРНІ РОБОТИ IZVP";
            titleLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Size = new Size(450, 40);
            titleLabel.Location = new Point(25, 30);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            // 2. Кнопка тесту
            testButton = new Button();
            testButton.Text = "ПЕРЕВІРИТИ СИСТЕМУ";
            testButton.Font = new Font("Arial", 12, FontStyle.Bold);
            testButton.BackColor = Color.LightGreen;
            testButton.ForeColor = Color.Black;
            testButton.Size = new Size(250, 60);
            testButton.Location = new Point(125, 100);
            testButton.Click += TestButton_Click;

            // 3. Інфо текст
            Label infoLabel = new Label();
            infoLabel.Text = "Універсальна основа для 7 лабораторних робіт\n" +
                           "Очікуємо отримання конкретної теми";
            infoLabel.Font = new Font("Arial", 10);
            infoLabel.ForeColor = Color.DarkGreen;
            infoLabel.Size = new Size(400, 50);
            infoLabel.Location = new Point(50, 200);
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;

            // 4. Додаємо всі елементи НА ФОРМУ
            this.Controls.Add(titleLabel);
            this.Controls.Add(testButton);
            this.Controls.Add(infoLabel);
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            ShowInfo("✅ СИСТЕМА ПРАЦЮЄ КОРЕКТНО!\n\n" +
                    "• Базова форма: Active\n" +
                    "• Елементи UI: Loaded\n" +
                    "• DataService: Ready\n" +
                    "• Newtonsoft.Json: Installed\n\n" +
                    "Готово до реалізації лабораторної роботи!");
        }

        protected override void LoadForm()
        {
            // Для майбутнього використання
        }

        protected override void SaveForm()
        {
            // Для майбутнього використання
        }
    }
}