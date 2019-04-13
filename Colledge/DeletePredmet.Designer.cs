namespace Colledge
{
    partial class DeletePredmet
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
            this.tsmJurnalAdd = new System.Windows.Forms.Label();
            this.cbpredDelete = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tsmJurnalAdd
            // 
            this.tsmJurnalAdd.BackColor = System.Drawing.Color.Transparent;
            this.tsmJurnalAdd.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmJurnalAdd.ForeColor = System.Drawing.Color.Black;
            this.tsmJurnalAdd.Location = new System.Drawing.Point(10, 14);
            this.tsmJurnalAdd.Name = "tsmJurnalAdd";
            this.tsmJurnalAdd.Size = new System.Drawing.Size(158, 52);
            this.tsmJurnalAdd.TabIndex = 39;
            this.tsmJurnalAdd.Text = "Выберите предмет для удаления:";
            // 
            // cbpredDelete
            // 
            this.cbpredDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.cbpredDelete.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbpredDelete.FormattingEnabled = true;
            this.cbpredDelete.Location = new System.Drawing.Point(10, 69);
            this.cbpredDelete.Name = "cbpredDelete";
            this.cbpredDelete.Size = new System.Drawing.Size(158, 23);
            this.cbpredDelete.TabIndex = 40;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(3, 113);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(69, 28);
            this.Cancel.TabIndex = 65;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(108, 113);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(69, 28);
            this.Save.TabIndex = 64;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DeletePredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.tsmJurnalAdd);
            this.Controls.Add(this.cbpredDelete);
            this.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DeletePredmet";
            this.Size = new System.Drawing.Size(184, 160);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tsmJurnalAdd;
        private System.Windows.Forms.ComboBox cbpredDelete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}
