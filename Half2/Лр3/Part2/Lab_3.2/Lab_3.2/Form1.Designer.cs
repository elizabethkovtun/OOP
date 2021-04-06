
namespace Lab_3._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.New_object = new System.Windows.Forms.Button();
            this.Hide_object = new System.Windows.Forms.Button();
            this.Show_object = new System.Windows.Forms.Button();
            this.Up_1 = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Down_1 = new System.Windows.Forms.Button();
            this.Lefter_1 = new System.Windows.Forms.Button();
            this.Lefter = new System.Windows.Forms.Button();
            this.Righter = new System.Windows.Forms.Button();
            this.Righter_1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 525);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(712, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // New_object
            // 
            this.New_object.Location = new System.Drawing.Point(712, 63);
            this.New_object.Name = "New_object";
            this.New_object.Size = new System.Drawing.Size(228, 23);
            this.New_object.TabIndex = 2;
            this.New_object.Text = "Створити новий об\'єкт";
            this.New_object.UseVisualStyleBackColor = true;
            this.New_object.Click += new System.EventHandler(this.New_object_Click);
            // 
            // Hide_object
            // 
            this.Hide_object.Location = new System.Drawing.Point(712, 92);
            this.Hide_object.Name = "Hide_object";
            this.Hide_object.Size = new System.Drawing.Size(228, 23);
            this.Hide_object.TabIndex = 3;
            this.Hide_object.Text = "Приховати об\'єкт";
            this.Hide_object.UseVisualStyleBackColor = true;
            this.Hide_object.Click += new System.EventHandler(this.Hide_object_Click);
            // 
            // Show_object
            // 
            this.Show_object.Location = new System.Drawing.Point(712, 121);
            this.Show_object.Name = "Show_object";
            this.Show_object.Size = new System.Drawing.Size(228, 23);
            this.Show_object.TabIndex = 4;
            this.Show_object.Text = "Показати об\'єкт";
            this.Show_object.UseVisualStyleBackColor = true;
            this.Show_object.Click += new System.EventHandler(this.Show_object_Click);
            // 
            // Up_1
            // 
            this.Up_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Up_1.Location = new System.Drawing.Point(805, 205);
            this.Up_1.Name = "Up_1";
            this.Up_1.Size = new System.Drawing.Size(50, 25);
            this.Up_1.TabIndex = 5;
            this.Up_1.Text = "↑↑↑↑";
            this.Up_1.UseVisualStyleBackColor = false;
            this.Up_1.Click += new System.EventHandler(this.Up_1_Click);
            // 
            // Up
            // 
            this.Up.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Up.Location = new System.Drawing.Point(805, 236);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(50, 25);
            this.Up.TabIndex = 6;
            this.Up.Text = "↑";
            this.Up.UseVisualStyleBackColor = false;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Plus.Location = new System.Drawing.Point(805, 279);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(50, 25);
            this.Plus.TabIndex = 7;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Minus.Location = new System.Drawing.Point(805, 310);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(50, 25);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Down
            // 
            this.Down.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Down.Location = new System.Drawing.Point(805, 358);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(50, 25);
            this.Down.TabIndex = 9;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = false;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Down_1
            // 
            this.Down_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Down_1.Location = new System.Drawing.Point(805, 389);
            this.Down_1.Name = "Down_1";
            this.Down_1.Size = new System.Drawing.Size(50, 25);
            this.Down_1.TabIndex = 10;
            this.Down_1.Text = "↓↓↓↓";
            this.Down_1.UseVisualStyleBackColor = false;
            this.Down_1.Click += new System.EventHandler(this.Down_1_Click);
            // 
            // Lefter_1
            // 
            this.Lefter_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Lefter_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lefter_1.Location = new System.Drawing.Point(727, 279);
            this.Lefter_1.Name = "Lefter_1";
            this.Lefter_1.Size = new System.Drawing.Size(25, 55);
            this.Lefter_1.TabIndex = 11;
            this.Lefter_1.Text = "←←←←";
            this.Lefter_1.UseVisualStyleBackColor = false;
            this.Lefter_1.Click += new System.EventHandler(this.Lefter_1_Click);
            // 
            // Lefter
            // 
            this.Lefter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Lefter.Location = new System.Drawing.Point(758, 279);
            this.Lefter.Name = "Lefter";
            this.Lefter.Size = new System.Drawing.Size(25, 55);
            this.Lefter.TabIndex = 12;
            this.Lefter.Text = "←";
            this.Lefter.UseVisualStyleBackColor = false;
            this.Lefter.Click += new System.EventHandler(this.Lefter_Click);
            // 
            // Righter
            // 
            this.Righter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Righter.Location = new System.Drawing.Point(873, 280);
            this.Righter.Name = "Righter";
            this.Righter.Size = new System.Drawing.Size(25, 55);
            this.Righter.TabIndex = 13;
            this.Righter.Text = "→";
            this.Righter.UseVisualStyleBackColor = false;
            this.Righter.Click += new System.EventHandler(this.Righter_Click);
            // 
            // Righter_1
            // 
            this.Righter_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Righter_1.Location = new System.Drawing.Point(904, 280);
            this.Righter_1.Name = "Righter_1";
            this.Righter_1.Size = new System.Drawing.Size(24, 55);
            this.Righter_1.TabIndex = 14;
            this.Righter_1.Text = "→→→→";
            this.Righter_1.UseVisualStyleBackColor = false;
            this.Righter_1.Click += new System.EventHandler(this.Righter_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 546);
            this.Controls.Add(this.Righter_1);
            this.Controls.Add(this.Righter);
            this.Controls.Add(this.Lefter);
            this.Controls.Add(this.Lefter_1);
            this.Controls.Add(this.Down_1);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Up_1);
            this.Controls.Add(this.Show_object);
            this.Controls.Add(this.Hide_object);
            this.Controls.Add(this.New_object);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №3.2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button New_object;
        private System.Windows.Forms.Button Hide_object;
        private System.Windows.Forms.Button Show_object;
        private System.Windows.Forms.Button Up_1;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Down_1;
        private System.Windows.Forms.Button Lefter_1;
        private System.Windows.Forms.Button Lefter;
        private System.Windows.Forms.Button Righter;
        private System.Windows.Forms.Button Righter_1;
    }
}

