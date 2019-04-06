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
    public partial class PredmetDelete : Form
    {
        public PredmetDelete()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(120, 218, 97, 4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PredmetDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
