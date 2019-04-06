namespace Colledge
{
    partial class GrUchDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrUchDelete));
            this.grdelete = new System.Windows.Forms.ComboBox();
            this.tsmUchenikAddIDNP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAutorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grdelete
            // 
            this.grdelete.FormattingEnabled = true;
            this.grdelete.Location = new System.Drawing.Point(154, 55);
            this.grdelete.Name = "grdelete";
            this.grdelete.Size = new System.Drawing.Size(121, 21);
            this.grdelete.TabIndex = 0;
            // 
            // tsmUchenikAddIDNP
            // 
            this.tsmUchenikAddIDNP.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddIDNP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddIDNP.ForeColor = System.Drawing.Color.Black;
            this.tsmUchenikAddIDNP.Location = new System.Drawing.Point(12, 33);
            this.tsmUchenikAddIDNP.Name = "tsmUchenikAddIDNP";
            this.tsmUchenikAddIDNP.Size = new System.Drawing.Size(136, 53);
            this.tsmUchenikAddIDNP.TabIndex = 22;
            this.tsmUchenikAddIDNP.Text = "Выберите группу для удаления:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(12, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 28);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAutorization
            // 
            this.btnAutorization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.btnAutorization.FlatAppearance.BorderSize = 0;
            this.btnAutorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorization.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAutorization.Location = new System.Drawing.Point(202, 112);
            this.btnAutorization.Name = "btnAutorization";
            this.btnAutorization.Size = new System.Drawing.Size(69, 28);
            this.btnAutorization.TabIndex = 39;
            this.btnAutorization.Text = "Save";
            this.btnAutorization.UseVisualStyleBackColor = false;
            // 
            // GrUchDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(283, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAutorization);
            this.Controls.Add(this.tsmUchenikAddIDNP);
            this.Controls.Add(this.grdelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrUchDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление группы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox grdelete;
        private System.Windows.Forms.Label tsmUchenikAddIDNP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAutorization;
    }
}