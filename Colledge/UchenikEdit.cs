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
    public partial class UchenikEdit : Form
    {
        public UchenikEdit()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(120, 218, 97, 4);
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel4.Visible = true;
            }
            else panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
