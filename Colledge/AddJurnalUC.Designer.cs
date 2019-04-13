namespace Colledge
{
    partial class AddJurnalUC
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Predmet = new System.Windows.Forms.ComboBox();
            this.tsmJurnalAdd = new System.Windows.Forms.Label();
            this.Prepod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonWas = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rate = new System.Windows.Forms.NumericUpDown();
            this.tsmUchenikAddDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rate)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(36, 221);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(98, 28);
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
            this.Save.Location = new System.Drawing.Point(188, 221);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(98, 28);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Predmet
            // 
            this.Predmet.BackColor = System.Drawing.Color.SandyBrown;
            this.Predmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Predmet.FormattingEnabled = true;
            this.Predmet.Location = new System.Drawing.Point(133, 3);
            this.Predmet.Name = "Predmet";
            this.Predmet.Size = new System.Drawing.Size(202, 24);
            this.Predmet.TabIndex = 13;
            // 
            // tsmJurnalAdd
            // 
            this.tsmJurnalAdd.BackColor = System.Drawing.Color.Transparent;
            this.tsmJurnalAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmJurnalAdd.ForeColor = System.Drawing.Color.Black;
            this.tsmJurnalAdd.Location = new System.Drawing.Point(-1, 3);
            this.tsmJurnalAdd.Name = "tsmJurnalAdd";
            this.tsmJurnalAdd.Size = new System.Drawing.Size(135, 18);
            this.tsmJurnalAdd.TabIndex = 72;
            this.tsmJurnalAdd.Text = "Выберите предмет:";
            // 
            // Prepod
            // 
            this.Prepod.BackColor = System.Drawing.Color.SandyBrown;
            this.Prepod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prepod.FormattingEnabled = true;
            this.Prepod.Location = new System.Drawing.Point(133, 41);
            this.Prepod.Name = "Prepod";
            this.Prepod.Size = new System.Drawing.Size(202, 24);
            this.Prepod.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Выберите препода:";
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.SandyBrown;
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Student.FormattingEnabled = true;
            this.Student.Location = new System.Drawing.Point(133, 80);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(202, 24);
            this.Student.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "Выберите студента:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButtonWas);
            this.panel1.Location = new System.Drawing.Point(11, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 53);
            this.panel1.TabIndex = 78;
            // 
            // radioButtonWas
            // 
            this.radioButtonWas.Checked = true;
            this.radioButtonWas.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWas.Location = new System.Drawing.Point(1, 4);
            this.radioButtonWas.Name = "radioButtonWas";
            this.radioButtonWas.Size = new System.Drawing.Size(121, 23);
            this.radioButtonWas.TabIndex = 0;
            this.radioButtonWas.TabStop = true;
            this.radioButtonWas.Text = "Присутствовал";
            this.radioButtonWas.UseVisualStyleBackColor = true;
            this.radioButtonWas.CheckedChanged += new System.EventHandler(this.RadioButtonWas_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(1, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Отсутствовал";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(271, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 21);
            this.checkBox1.TabIndex = 80;
            this.checkBox1.Text = "Оценка";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // rate
            // 
            this.rate.BackColor = System.Drawing.Color.SandyBrown;
            this.rate.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold);
            this.rate.Location = new System.Drawing.Point(275, 149);
            this.rate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(44, 24);
            this.rate.TabIndex = 16;
            this.rate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rate.Visible = false;
            // 
            // tsmUchenikAddDate
            // 
            this.tsmUchenikAddDate.CustomFormat = "";
            this.tsmUchenikAddDate.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold);
            this.tsmUchenikAddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tsmUchenikAddDate.Location = new System.Drawing.Point(12, 179);
            this.tsmUchenikAddDate.MaxDate = new System.DateTime(2021, 4, 13, 0, 0, 0, 0);
            this.tsmUchenikAddDate.MinDate = new System.DateTime(2000, 2, 2, 0, 0, 0, 0);
            this.tsmUchenikAddDate.Name = "tsmUchenikAddDate";
            this.tsmUchenikAddDate.Size = new System.Drawing.Size(122, 24);
            this.tsmUchenikAddDate.TabIndex = 81;
            this.tsmUchenikAddDate.Value = new System.DateTime(2019, 4, 13, 0, 0, 0, 0);
            this.tsmUchenikAddDate.ValueChanged += new System.EventHandler(this.TsmUchenikAddDate_ValueChanged);
            // 
            // AddJurnalUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tsmUchenikAddDate);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Prepod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Predmet);
            this.Controls.Add(this.tsmJurnalAdd);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddJurnalUC";
            this.Size = new System.Drawing.Size(337, 261);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox Predmet;
        private System.Windows.Forms.Label tsmJurnalAdd;
        private System.Windows.Forms.ComboBox Prepod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonWas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown rate;
        private System.Windows.Forms.DateTimePicker tsmUchenikAddDate;
    }
}
