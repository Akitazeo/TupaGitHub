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
    public partial class SpetFacDelete : Form
    {
        public SpetFacDelete()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(120, 218, 97, 4);
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                panel2.Visible = true;
            }
            else panel2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel3.Visible = true;
            }
            else panel3.Visible = false;
        }
    }
}
