namespace Exam_IZVP.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // ОГОЛОШЕННЯ ЕЛЕМЕНТІВ (додати ці рядки)
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.CheckedListBox checkedListBoxLanguages;
        private System.Windows.Forms.Label labelNewLanguage;
        private System.Windows.Forms.TextBox txtNewLanguage;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label labelStudentsList;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.checkedListBoxLanguages = new System.Windows.Forms.CheckedListBox();
            this.labelNewLanguage = new System.Windows.Forms.Label();
            this.txtNewLanguage = new System.Windows.Forms.TextBox();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.labelStudentsList = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();

            // labelFullName
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 20);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(84, 13);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ПІБ студента:";

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(12, 36);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(250, 20);
            this.txtFullName.TabIndex = 1;

            // labelLanguages
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(12, 70);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(125, 13);
            this.labelLanguages.TabIndex = 2;
            this.labelLanguages.Text = "Мови програмування:";

            // checkedListBoxLanguages
            this.checkedListBoxLanguages.CheckOnClick = true;
            this.checkedListBoxLanguages.FormattingEnabled = true;
            this.checkedListBoxLanguages.Location = new System.Drawing.Point(12, 86);
            this.checkedListBoxLanguages.Name = "checkedListBoxLanguages";
            this.checkedListBoxLanguages.Size = new System.Drawing.Size(250, 124);
            this.checkedListBoxLanguages.TabIndex = 3;

            // labelNewLanguage
            this.labelNewLanguage.AutoSize = true;
            this.labelNewLanguage.Location = new System.Drawing.Point(12, 220);
            this.labelNewLanguage.Name = "labelNewLanguage";
            this.labelNewLanguage.Size = new System.Drawing.Size(100, 13);
            this.labelNewLanguage.TabIndex = 4;
            this.labelNewLanguage.Text = "Нова мова програмування:";

            // txtNewLanguage
            this.txtNewLanguage.Location = new System.Drawing.Point(12, 236);
            this.txtNewLanguage.Name = "txtNewLanguage";
            this.txtNewLanguage.Size = new System.Drawing.Size(150, 20);
            this.txtNewLanguage.TabIndex = 5;

            // btnAddLanguage
            this.btnAddLanguage.Location = new System.Drawing.Point(168, 234);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(94, 23);
            this.btnAddLanguage.TabIndex = 6;
            this.btnAddLanguage.Text = "Додати мову";
            this.btnAddLanguage.UseVisualStyleBackColor = true;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);

            // btnAddStudent
            this.btnAddStudent.Location = new System.Drawing.Point(12, 270);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(250, 30);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Додати студента";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            // btnShowTable
            this.btnShowTable.Location = new System.Drawing.Point(12, 310);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(250, 30);
            this.btnShowTable.TabIndex = 8;
            this.btnShowTable.Text = "Перейти до таблиці";
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);

            // panelLeft
            this.panelLeft.Controls.Add(this.labelFullName);
            this.panelLeft.Controls.Add(this.btnShowTable);
            this.panelLeft.Controls.Add(this.txtFullName);
            this.panelLeft.Controls.Add(this.btnAddStudent);
            this.panelLeft.Controls.Add(this.labelLanguages);
            this.panelLeft.Controls.Add(this.btnAddLanguage);
            this.panelLeft.Controls.Add(this.checkedListBoxLanguages);
            this.panelLeft.Controls.Add(this.txtNewLanguage);
            this.panelLeft.Controls.Add(this.labelNewLanguage);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(280, 400);
            this.panelLeft.TabIndex = 9;

            // labelStudentsList
            this.labelStudentsList.AutoSize = true;
            this.labelStudentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentsList.Location = new System.Drawing.Point(10, 10);
            this.labelStudentsList.Name = "labelStudentsList";
            this.labelStudentsList.Size = new System.Drawing.Size(148, 17);
            this.labelStudentsList.TabIndex = 0;
            this.labelStudentsList.Text = "Додані студенти:";

            // dataGridViewStudents
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(10, 30);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(390, 360);
            this.dataGridViewStudents.TabIndex = 1;

            // panelRight
            this.panelRight.Controls.Add(this.dataGridViewStudents);
            this.panelRight.Controls.Add(this.labelStudentsList);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(280, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(420, 400);
            this.panelRight.TabIndex = 10;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MinimumSize = new System.Drawing.Size(716, 439);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення студентів та мов програмування";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}