namespace Colledge
{
    partial class AddPredmet
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
            this.tbPredmet = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(42, 42);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(69, 28);
            this.Cancel.TabIndex = 69;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // tbPredmet
            // 
            this.tbPredmet.BackColor = System.Drawing.Color.SandyBrown;
            this.tbPredmet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPredmet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPredmet.Location = new System.Drawing.Point(137, 5);
            this.tbPredmet.MaxLength = 15;
            this.tbPredmet.Name = "tbPredmet";
            this.tbPredmet.Size = new System.Drawing.Size(110, 22);
            this.tbPredmet.TabIndex = 64;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(150, 42);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(69, 28);
            this.Save.TabIndex = 68;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(5, 5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(126, 24);
            this.Login.TabIndex = 65;
            this.Login.Text = "Новый предмет:";
            // 
            // AddPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tbPredmet);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPredmet";
            this.Size = new System.Drawing.Size(257, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox tbPredmet;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label Login;
    }
}
