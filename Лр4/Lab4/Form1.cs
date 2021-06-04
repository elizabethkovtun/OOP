using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Student newStudent = new Student();
            CreateStudent studentModal = new CreateStudent(newStudent);
            studentModal.ShowDialog();
            if (studentModal.ok)
            {
                StudentsList.Items.Add(studentModal.studentInfo);
                students.Add(studentModal.studentInfo);
            }
            else
            {
                MessageBox.Show("Зміни не збережено");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentsList.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= students.Count)
            {
                MessageBox.Show("Оберіть студента!");
                return;
            }
            CreateStudent studentlModal = new CreateStudent(students[StudentsList.SelectedIndex]);
            studentlModal.ShowDialog();
            if (studentlModal.ok)
            {
                StudentsList.Items[selectedIndex] = studentlModal.studentInfo;
            }
            else
            {
                MessageBox.Show("Зміни не збережено");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentsList.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= students.Count)
            {
                MessageBox.Show("Оберіть студента!");
                return;
            }
            students.RemoveAt(selectedIndex);
            StudentsList.Items.RemoveAt(selectedIndex);
        }

        private void showInfo_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = StudentsList.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= students.Count)
            {
                MessageBox.Show("Оберіть студента!");
            }
            else
            {
                MessageBox.Show(students[selectedIndex].ToString());
            }

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (students != null)
            {
                string fileName = Directory.GetCurrentDirectory() + "\\SerializedData.json";
                File.Delete(fileName);
                string json = JsonConvert.SerializeObject(students);
                File.WriteAllText(fileName, json);
                MessageBox.Show("Saved successfully!");
                MessageBox.Show($"Saved to {fileName}");
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

                    string fileName = Directory.GetCurrentDirectory() + "\\SerializedData.json";
                    File.Delete(fileName);
                    string json = JsonConvert.SerializeObject(students);

                    File.WriteAllText(fileName, json);

                    MessageBox.Show("Saved successfully!");
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            StudentsInformation journalModal = new StudentsInformation((Student)StudentsList.SelectedItem);
            journalModal.ShowDialog();
            if (journalModal.ok)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = Directory.GetCurrentDirectory() + "\\SerializedData.json";
            string json = File.ReadAllText(fileName);
            students = JsonConvert.DeserializeObject<List<Student>>(json);
            foreach (var item in students)
            {
                StudentsList.Items.Add(item);
            }
            StudentsList.Refresh();

        }

    }
}

