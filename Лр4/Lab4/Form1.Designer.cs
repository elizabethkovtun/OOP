namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StudentsList = new System.Windows.Forms.ListBox();
            this.create_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.showInfo_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsList
            // 
            this.StudentsList.BackColor = System.Drawing.Color.White;
            this.StudentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.ItemHeight = 16;
            this.StudentsList.Location = new System.Drawing.Point(203, 11);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(716, 404);
            this.StudentsList.TabIndex = 2;
            this.StudentsList.SelectedIndexChanged += new System.EventHandler(this.JournalsList_SelectedIndexChanged);
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.create_button.FlatAppearance.BorderSize = 0;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Location = new System.Drawing.Point(41, 11);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(156, 27);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "Створити";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.edit_button.FlatAppearance.BorderSize = 0;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Location = new System.Drawing.Point(41, 56);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(156, 28);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "Змінити";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // save_button
            // 
            this.save_button.FlatAppearance.BorderSize = 0;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Image = ((System.Drawing.Image)(resources.GetObject("save_button.Image")));
            this.save_button.Location = new System.Drawing.Point(41, 341);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(156, 34);
            this.save_button.TabIndex = 1;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // showInfo_button
            // 
            this.showInfo_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.showInfo_button.FlatAppearance.BorderSize = 0;
            this.showInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showInfo_button.Location = new System.Drawing.Point(41, 102);
            this.showInfo_button.Name = "showInfo_button";
            this.showInfo_button.Size = new System.Drawing.Size(156, 28);
            this.showInfo_button.TabIndex = 5;
            this.showInfo_button.Text = "Інформація";
            this.showInfo_button.UseVisualStyleBackColor = false;
            this.showInfo_button.Click += new System.EventHandler(this.showInfo_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delete_button.FlatAppearance.BorderSize = 0;
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_button.Location = new System.Drawing.Point(41, 148);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(156, 28);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Удалити";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(41, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Відкрити меню екзаменів";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(41, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Відкрити серіалізований файл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.showInfo_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.StudentsList);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsList;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button showInfo_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

