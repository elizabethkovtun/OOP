namespace Lab4
{
    partial class StudentsInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exams_list = new System.Windows.Forms.ListBox();
            this.create_exam = new System.Windows.Forms.Button();
            this.edit_Exam = new System.Windows.Forms.Button();
            this.journal_full_info = new System.Windows.Forms.Label();
            this.total_pages_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.educationLevel_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exams_list
            // 
            this.exams_list.FormattingEnabled = true;
            this.exams_list.Location = new System.Drawing.Point(373, 55);
            this.exams_list.Name = "exams_list";
            this.exams_list.Size = new System.Drawing.Size(292, 225);
            this.exams_list.TabIndex = 3;
            this.exams_list.SelectedIndexChanged += new System.EventHandler(this.articles_list_SelectedIndexChanged);
            // 
            // create_exam
            // 
            this.create_exam.Location = new System.Drawing.Point(687, 55);
            this.create_exam.Name = "create_exam";
            this.create_exam.Size = new System.Drawing.Size(91, 34);
            this.create_exam.TabIndex = 4;
            this.create_exam.Text = "Создать";
            this.create_exam.UseVisualStyleBackColor = true;
            this.create_exam.Click += new System.EventHandler(this.create_article_Click);
            // 
            // edit_Exam
            // 
            this.edit_Exam.Location = new System.Drawing.Point(687, 103);
            this.edit_Exam.Name = "edit_Exam";
            this.edit_Exam.Size = new System.Drawing.Size(91, 34);
            this.edit_Exam.TabIndex = 5;
            this.edit_Exam.Text = "Изменить";
            this.edit_Exam.UseVisualStyleBackColor = true;
            this.edit_Exam.Click += new System.EventHandler(this.edit_Article_Click);
            // 
            // journal_full_info
            // 
            this.journal_full_info.AutoSize = true;
            this.journal_full_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journal_full_info.Location = new System.Drawing.Point(402, 40);
            this.journal_full_info.Name = "journal_full_info";
            this.journal_full_info.Size = new System.Drawing.Size(0, 17);
            this.journal_full_info.TabIndex = 6;
            // 
            // total_pages_label
            // 
            this.total_pages_label.AutoSize = true;
            this.total_pages_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total_pages_label.Location = new System.Drawing.Point(386, 186);
            this.total_pages_label.Name = "total_pages_label";
            this.total_pages_label.Size = new System.Drawing.Size(0, 17);
            this.total_pages_label.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя:";
            // 
            // educationLevel_comboBox
            // 
            this.educationLevel_comboBox.FormattingEnabled = true;
            this.educationLevel_comboBox.Location = new System.Drawing.Point(12, 252);
            this.educationLevel_comboBox.Name = "educationLevel_comboBox";
            this.educationLevel_comboBox.Size = new System.Drawing.Size(267, 21);
            this.educationLevel_comboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Учеюный уровень:";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(675, 244);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(103, 34);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Сохранить и выйти";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(675, 201);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(103, 36);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "Отменить и выйти";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(687, 145);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(91, 34);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить ";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // firstName_textBox
            // 
            this.firstName_textBox.Location = new System.Drawing.Point(16, 55);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(263, 20);
            this.firstName_textBox.TabIndex = 11;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(16, 117);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(263, 20);
            this.lastName_textBox.TabIndex = 12;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(16, 182);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(263, 20);
            this.dateOfBirth.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(369, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Экзамени:";
            // 
            // StudentsInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 290);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.firstName_textBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.educationLevel_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_pages_label);
            this.Controls.Add(this.journal_full_info);
            this.Controls.Add(this.edit_Exam);
            this.Controls.Add(this.create_exam);
            this.Controls.Add(this.exams_list);
            this.Name = "StudentsInformation";
            this.Text = "JournalInfo";
            this.Load += new System.EventHandler(this.StudentsInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox exams_list;
        private System.Windows.Forms.Button create_exam;
        private System.Windows.Forms.Button edit_Exam;
        private System.Windows.Forms.Label journal_full_info;
        private System.Windows.Forms.Label total_pages_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox educationLevel_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}