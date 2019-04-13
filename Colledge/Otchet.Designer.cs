namespace Colledge
{
    partial class Otchet
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.JurnalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Student = new Colledge.Student();
            this.UchenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JurnalTableAdapter = new Colledge.StudentTableAdapters.JurnalTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UchenikTableAdapter = new Colledge.StudentTableAdapters.UchenikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.JurnalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UchenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // JurnalBindingSource
            // 
            this.JurnalBindingSource.DataMember = "Jurnal";
            this.JurnalBindingSource.DataSource = this.Student;
            // 
            // Student
            // 
            this.Student.DataSetName = "Student";
            this.Student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UchenikBindingSource
            // 
            this.UchenikBindingSource.DataMember = "Uchenik";
            this.UchenikBindingSource.DataSource = this.Student;
            // 
            // JurnalTableAdapter
            // 
            this.JurnalTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TestReport";
            reportDataSource1.Value = this.JurnalBindingSource;
            reportDataSource2.Name = "Uchenik";
            reportDataSource2.Value = this.UchenikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Colledge.TestReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(748, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // UchenikTableAdapter
            // 
            this.UchenikTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(183)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(748, 449);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Otchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт по посещаемости";
            this.Load += new System.EventHandler(this.Otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JurnalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UchenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource JurnalBindingSource;
        private Student Student;
        private StudentTableAdapters.JurnalTableAdapter JurnalTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UchenikBindingSource;
        private StudentTableAdapters.UchenikTableAdapter UchenikTableAdapter;
    }
}