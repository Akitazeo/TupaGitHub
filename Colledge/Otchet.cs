using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colledge
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Student.Uchenik". При необходимости она может быть перемещена или удалена.
            this.UchenikTableAdapter.Fill(this.Student.Uchenik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Student.Jurnal". При необходимости она может быть перемещена или удалена.
            this.JurnalTableAdapter.Fill(this.Student.Jurnal);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
