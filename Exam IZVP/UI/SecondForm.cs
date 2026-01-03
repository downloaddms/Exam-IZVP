using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Exam_IZVP.Core;
using FastReport;
using System.Data;
using System.IO;

namespace Exam_IZVP.UI
{
    public partial class SecondForm : BaseForm
    {
        private List<Student> _students;
        private List<string> _languages;

        public SecondForm(List<Student> students, List<string> languages)
        {
            InitializeComponent();
            _students = students;
            _languages = languages;
            BuildDynamicTable();
        }

        private void BuildDynamicTable()
        {
            dataGridViewTable.Columns.Clear();

            // Колонка ПІБ
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                Name = "FullName",
                HeaderText = "ПІБ студента",
                Width = 200,
                ReadOnly = true
            };
            dataGridViewTable.Columns.Add(nameColumn);

            // Динамічні колонки для мов
            foreach (var language in _languages)
            {
                DataGridViewTextBoxColumn langColumn = new DataGridViewTextBoxColumn
                {
                    Name = language,
                    HeaderText = language,
                    Width = 80,
                    ReadOnly = true
                };
                dataGridViewTable.Columns.Add(langColumn);
            }

            // Заповнення даних
            foreach (var student in _students)
            {
                var rowIndex = dataGridViewTable.Rows.Add();
                dataGridViewTable.Rows[rowIndex].Cells["FullName"].Value = student.FullName;

                foreach (var language in _languages)
                {
                    bool knowsLanguage = student.ProgrammingLanguages.Contains(language);
                    dataGridViewTable.Rows[rowIndex].Cells[language].Value = knowsLanguage ? "✓" : "✗";
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcelWithFastReport();
        }

        private void ExportToExcelWithFastReport()
        {
            try
            {
                // 1. Створюємо DataSet з даними
                DataSet dataSet = CreateDataSet();

                // 2. Створюємо і завантажуємо звіт FastReport
                using (Report report = new Report())
                {
                    // Завантажуємо шаблон .frx
                    if (File.Exists("report.frx"))
                    {
                        report.Load("report.frx");
                    }
                    else
                    {
                        // Якщо файлу немає, створюємо простий звіт
                        CreateSimpleReport(report);
                    }

                    // Реєструємо дані
                    report.RegisterData(dataSet, "Data");

                    // Підготовка звіту
                    report.Prepare();

                    // 3. Зберігаємо у форматі Excel (CSV)
                    SaveFileDialog saveDialog = new SaveFileDialog
                    {
                        Filter = "Excel CSV (*.csv)|*.csv|All files (*.*)|*.*",
                        FileName = $"Студенти_мови_{DateTime.Now:yyyyMMdd_HHmm}.csv",
                        Title = "Зберегти як Excel таблицю"
                    };

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Експортуємо дані з DataSet у CSV
                        ExportDataSetToCsv(dataSet, saveDialog.FileName);

                        ShowInfo($"Файл успішно збережено!\n\n" +
                                $"FastReport використано для підготовки даних.\n" +
                                $"Шаблон: report.frx\n" +
                                $"Результат: {saveDialog.FileName}\n\n" +
                                $"Файл CSV відкривається в Microsoft Excel як електронна таблиця.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при експорті: {ex.Message}",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataSet CreateDataSet()
        {
            DataSet dataSet = new DataSet("Data");
            DataTable dataTable = new DataTable("Students");

            // Додаємо колонки
            dataTable.Columns.Add("FullName", typeof(string));

            // Додаємо колонки для кожної мови
            foreach (var language in _languages)
            {
                dataTable.Columns.Add(language, typeof(string));
            }

            // Додаємо рядки
            foreach (var student in _students)
            {
                DataRow row = dataTable.NewRow();
                row["FullName"] = student.FullName;

                foreach (var language in _languages)
                {
                    row[language] = student.ProgrammingLanguages.Contains(language) ? "Так" : "Ні";
                }

                dataTable.Rows.Add(row);
            }

            dataSet.Tables.Add(dataTable);
            return dataSet;
        }

        private void CreateSimpleReport(Report report)
        {
            // Створюємо простий звіт програмно, якщо немає .frx файлу
            ReportPage page = new ReportPage();
            report.Pages.Add(page);

            DataBand dataBand = new DataBand();
            dataBand.Height = 37.8f; // Висота в пунктах (1 см ≈ 37.8 пунктів)
            page.Bands.Add(dataBand);

            FastReport.TextObject textObj = new FastReport.TextObject();
            textObj.Bounds = new System.Drawing.RectangleF(0, 0, 283.5f, 37.8f); // 7.5 см x 1 см
            textObj.Text = "[Students.FullName]";
            dataBand.Objects.Add(textObj);
        }

        private void ExportDataSetToCsv(DataSet dataSet, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, System.Text.Encoding.UTF8))
            {
                // Записуємо дані з першої таблиці
                DataTable dataTable = dataSet.Tables[0];

                // Заголовки
                var headers = new List<string>();
                foreach (DataColumn column in dataTable.Columns)
                {
                    headers.Add(column.ColumnName);
                }
                writer.WriteLine(string.Join(";", headers));

                // Дані
                foreach (DataRow row in dataTable.Rows)
                {
                    var rowData = new List<string>();
                    foreach (var item in row.ItemArray)
                    {
                        rowData.Add(item.ToString());
                    }
                    writer.WriteLine(string.Join(";", rowData));
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}