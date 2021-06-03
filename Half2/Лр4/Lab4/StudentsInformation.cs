using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class StudentsInformation : Form
    {
        public Student studentInfo;

        public StudentsInformation(Student student)
        {
            InitializeComponent();
            studentInfo = student;

            EducationLevel[] educationLevel = (EducationLevel[])Enum.GetValues(typeof(EducationLevel));
            foreach (EducationLevel education in educationLevel)
            {
                educationLevel_comboBox.Items.Add(education.ToString());
            }            
            if(studentInfo != null && student.Person != null && student.educationLevel != null)
            {
                educationLevel_comboBox.SelectedIndex = educationLevel_comboBox.Items.IndexOf(student.educationLevel.ToString());
              //  student_name.Text = student.Name;
                if (student.Exams != null)
                {
                    student.Exams.ForEach(article =>
                    {
                        exams_list.Items.Add(article);
                    });
                }
            }                      
            edit_Exam.Enabled = false;
            delete_button.Enabled = false;
        }
            
        private void edit_Article_Click(object sender, EventArgs e)
        {            
            int selectedIndex = exams_list.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= studentInfo.Exams.Count)
            {
                MessageBox.Show("You need to choose exam!");
                return;
            }
            ExamInformation articleModal = new ExamInformation(studentInfo.Exams[selectedIndex]);
            if (articleModal.ShowDialog() == DialogResult.OK)
            {
                exams_list.Items[selectedIndex] = studentInfo.Exams[selectedIndex].ToString();
               // studentInfo.CalculatePagesAndAuthors();
                //total_pages_label.Text = studentInfo.TotalPagesNumber.ToString();
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void create_article_Click(object sender, EventArgs e)
        {
            Exam newExam = new Exam();
            ExamInformation examModal = new ExamInformation(newExam);
            if (examModal.ShowDialog() == DialogResult.OK)
            {
                studentInfo.AddExam(newExam);
                //studentInfo.CalculatePagesAndAuthors();
                //articles_list.Items.Add(newArticle.ToString());
                //total_pages_label.Text = studentInfo.TotalPagesNumber.ToString();
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void articles_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_Exam.Enabled = true;
            delete_button.Enabled = true;
        }      

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void save_button_Click(object sender, EventArgs e)
        {               
            if (educationLevel_comboBox.SelectedItem == null) /*|| student_name.Text == " "*/
            {
                MessageBox.Show("You need to fill empty fields!");
                return;
            }
            studentInfo.educationLevel = (EducationLevel)Enum.Parse(typeof(EducationLevel), educationLevel_comboBox.SelectedItem.ToString());        
            DialogResult = DialogResult.OK;
        }

        private void studentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                   // studentInfo.Name = student_name.Text;
                    studentInfo.educationLevel = (EducationLevel)Enum.Parse(typeof(EducationLevel), educationLevel_comboBox.SelectedItem.ToString());
                    studentInfo.Exams = studentInfo.Exams != null ? studentInfo.Exams : null;
                    DialogResult = DialogResult.OK;                  
                }
               else
               {
                    DialogResult = DialogResult.Cancel;
               }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = exams_list.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= studentInfo.Exams.Count)
            {
                MessageBox.Show("You need to choose article!");
                return;
            }
            studentInfo.Exams.RemoveAt(selectedIndex);
            exams_list.Items.RemoveAt(selectedIndex);
        }

        private void StudentsInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
