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
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            edit_button.Enabled = false;
            showInfo_button.Enabled = false;
            delete_button.Enabled = false;

            students = Student.ReadStudentList("Студент");
            students.ForEach(journalListInfo =>
            {
                StudentsList.Items.Add(journalListInfo.ToShortString());
            });
        }

        private void JournalsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_button.Enabled = true;
            showInfo_button.Enabled = true;
            delete_button.Enabled = true;
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            Student newJournal = new Student();           
            StudentsInformation journalModal = new StudentsInformation(newJournal);
            if (journalModal.ShowDialog() == DialogResult.OK)
            {
                StudentsList.Items.Add(newJournal.ToShortString());
                students.Add(newJournal);
            }
            else
            {                               
                 MessageBox.Show("Changes was not saved");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {            
            int selectedIndex = StudentsList.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= students.Count)
            {
                MessageBox.Show("You need to choose journal!");
                return;
            }
            StudentsInformation journalModal = new StudentsInformation(students[StudentsList.SelectedIndex]);
            if (journalModal.ShowDialog() == DialogResult.OK)
            {
                StudentsList.Items[selectedIndex] = students[StudentsList.SelectedIndex].ToShortString();
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentsList.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= students.Count)
            {
                MessageBox.Show("You need to choose journal!");
                return;
            }
            students.RemoveAt(selectedIndex);
            StudentsList.Items.RemoveAt(selectedIndex);
        }

        private void showInfo_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentsList.SelectedIndex;
            if(selectedIndex < 0 || selectedIndex >= students.Count)
            {
                MessageBox.Show("You don`t choose a journal");
            }
            else
            {
                MessageBox.Show(students[selectedIndex].ToString());
            }
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if(students != null)
            {
                Student.WriteJournalsToFile("Cтудент", students);
                MessageBox.Show("Saved successfully!");
            }
            else
            {
                MessageBox.Show("There are nothing to save");
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && DialogResult != DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);        
                if (result == DialogResult.Yes)
                {
                    Student.WriteJournalsToFile("Студент", students);
                    MessageBox.Show("Saved successfully!");
                }               
            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
