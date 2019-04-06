namespace Colledge
{
    partial class addGrUch
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
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFac = new System.Windows.Forms.ComboBox();
            this.Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(83, 93);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(69, 28);
            this.Cancel.TabIndex = 63;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tbGroup
            // 
            this.tbGroup.BackColor = System.Drawing.Color.SandyBrown;
            this.tbGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGroup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGroup.Location = new System.Drawing.Point(188, 14);
            this.tbGroup.MaxLength = 15;
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(110, 22);
            this.tbGroup.TabIndex = 56;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(188, 93);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(69, 28);
            this.Save.TabIndex = 60;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Выберите факультет:";
            // 
            // cbFac
            // 
            this.cbFac.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cbFac.FormattingEnabled = true;
            this.cbFac.Location = new System.Drawing.Point(188, 54);
            this.cbFac.Name = "cbFac";
            this.cbFac.Size = new System.Drawing.Size(110, 23);
            this.cbFac.TabIndex = 58;
            this.cbFac.SelectedIndexChanged += new System.EventHandler(this.cbFac_SelectedIndexChanged);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(66, 14);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(109, 24);
            this.Login.TabIndex = 57;
            this.Login.Text = "Новая группа:";
            // 
            // grUchAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tbGroup);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFac);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "grUchAdd";
            this.Size = new System.Drawing.Size(314, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFac;
        private System.Windows.Forms.Label Login;
    }
}
