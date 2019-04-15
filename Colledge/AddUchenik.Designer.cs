namespace Colledge
{
    partial class AddUchenik
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FIO = new System.Windows.Forms.TextBox();
            this.Student = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IDNP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // FIO
            // 
            this.FIO.BackColor = System.Drawing.Color.SandyBrown;
            this.FIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.FIO.Location = new System.Drawing.Point(6, 28);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(188, 20);
            this.FIO.TabIndex = 22;
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.SandyBrown;
            this.Student.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Student.FormattingEnabled = true;
            this.Student.Location = new System.Drawing.Point(6, 24);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(187, 24);
            this.Student.TabIndex = 31;
            this.Student.SelectedIndexChanged += new System.EventHandler(this.Student_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FIO);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите ФИО ученика";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IDNP);
            this.groupBox2.Location = new System.Drawing.Point(9, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 54);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Введите IDNP";
            // 
            // IDNP
            // 
            this.IDNP.BackColor = System.Drawing.Color.SandyBrown;
            this.IDNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDNP.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.IDNP.Location = new System.Drawing.Point(6, 28);
            this.IDNP.Name = "IDNP";
            this.IDNP.Size = new System.Drawing.Size(188, 20);
            this.IDNP.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Student);
            this.groupBox3.Location = new System.Drawing.Point(9, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 54);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выберите группу";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Adress);
            this.groupBox5.Location = new System.Drawing.Point(9, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(208, 54);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Введите адрес";
            // 
            // Adress
            // 
            this.Adress.BackColor = System.Drawing.Color.SandyBrown;
            this.Adress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adress.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.Adress.Location = new System.Drawing.Point(6, 28);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(188, 20);
            this.Adress.TabIndex = 22;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(9, 238);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 28);
            this.Cancel.TabIndex = 71;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(138, 238);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 28);
            this.Save.TabIndex = 70;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddUchenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUchenik";
            this.Size = new System.Drawing.Size(224, 272);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.ComboBox Student;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IDNP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}
