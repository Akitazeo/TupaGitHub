﻿namespace Colledge
{
    partial class AddUchitel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFIO);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 54);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите ФИО учителя";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(2, 71);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 28);
            this.Cancel.TabIndex = 74;
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
            this.Save.Location = new System.Drawing.Point(116, 71);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 28);
            this.Save.TabIndex = 75;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxFIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFIO.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.textBoxFIO.Location = new System.Drawing.Point(6, 28);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(188, 20);
            this.textBoxFIO.TabIndex = 22;
            // 
            // AddUchitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUchitel";
            this.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox textBoxFIO;
    }
}
