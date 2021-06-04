using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ExamInformation : Form
    {
        public Exam examInfo { get; set; }

        public ExamInformation(Exam exam)
        {
            InitializeComponent();
            examInfo = exam;

            if (examInfo != null && examInfo.NameOfExam != null && examInfo.DateOfExam != null && examInfo.Mark != null)
            {
                nameOfExam_textBox.Text = exam.NameOfExam;
                mark_textBox.Text = exam.Mark.ToString();
                dateTimePicker1.Text = exam.DateOfExam.ToString();
            }
        }



        private void nameOfExam_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\w+");
            if (!regexGroupFormat.IsMatch(nameOfExam_textBox.Text))
            {
                e.Cancel = true;

            }
        }

        private void mark_textBox_Validating(object sender, CancelEventArgs e)
        {
            Regex regexGroupFormat = new Regex(@"^\d+$");
            if (!regexGroupFormat.IsMatch(mark_textBox.Text))
            {
                e.Cancel = true;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (nameOfExam_textBox.Text == "" || mark_textBox.Text == "")
            {
                MessageBox.Show("Заповніть пусті поля!");
                return;
            }
            examInfo.NameOfExam = nameOfExam_textBox.Text;
            examInfo.Mark = int.Parse(mark_textBox.Text);
            examInfo.DateOfExam = dateTimePicker1.Value;
            DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ArticleInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Зберегти змінии?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    examInfo.NameOfExam = nameOfExam_textBox.Text;
                    examInfo.Mark = int.Parse(mark_textBox.Text);
                    examInfo.DateOfExam = dateTimePicker1.Value;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
