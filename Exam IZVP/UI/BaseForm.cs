using System;
using System.Windows.Forms;

namespace Exam_IZVP.UI
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        // ЗМІНИТИ НА ЦІ ІМЕНА:
        protected virtual void LoadForm() { }
        protected virtual void SaveForm() { }

        protected void ShowInfo(string message)
        {
            MessageBox.Show(message, "Інформація",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected bool AskYesNo(string question)
        {
            return MessageBox.Show(question, "Питання",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}