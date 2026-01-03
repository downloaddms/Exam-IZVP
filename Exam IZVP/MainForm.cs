using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Exam_IZVP.Core;

namespace Exam_IZVP.UI
{
    public partial class MainForm : BaseForm
    {
        private List<Student> _students = new List<Student>();

        public MainForm()
        {
            InitializeComponent();
            InitializeLanguageList();
        }

        private void InitializeLanguageList()
        {
            checkedListBoxLanguages.Items.Clear();
            foreach (var lang in LanguageManager.GetAllLanguages())
            {
                checkedListBoxLanguages.Items.Add(lang, false);
            }
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewLanguage.Text))
            {
                LanguageManager.AddLanguage(txtNewLanguage.Text);
                InitializeLanguageList(); // Оновити список
                txtNewLanguage.Text = "";
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Введіть ПІБ студента!");
                return;
            }

            var student = new Student
            {
                FullName = txtFullName.Text,
                ProgrammingLanguages = new List<string>()
            };

            foreach (var item in checkedListBoxLanguages.CheckedItems)
            {
                student.ProgrammingLanguages.Add(item.ToString());
            }

            _students.Add(student);
            RefreshStudentsGrid();
            txtFullName.Text = "";
            ClearLanguageChecks();
        }

        private void RefreshStudentsGrid()
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = _students.Select(s => new
            {
                s.FullName,
                Мови = s.LanguagesString
            }).ToList();
        }

        private void ClearLanguageChecks()
        {
            for (int i = 0; i < checkedListBoxLanguages.Items.Count; i++)
                checkedListBoxLanguages.SetItemChecked(i, false);
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            var secondForm = new SecondForm(_students, LanguageManager.GetAllLanguages());
            secondForm.Show();
            this.Hide();
        }
    }
}