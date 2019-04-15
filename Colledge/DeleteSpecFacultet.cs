using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colledge
{
    public partial class DeleteSpecFacultet : UserControl
    {
        public DeleteSpecFacultet()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(120, 218, 97, 4);
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            updateComboBox();
            
        }
        private void updateComboBox()
        {
            comboBoxFacultet.Items.Clear();
            comboBoxSpecialnost.Items.Clear();
            Autorization.connection.Open();
            Autorization.command.CommandText = "Select NameSpet,NameFac FROM SpecFac";
            Autorization.sdr = Autorization.command.ExecuteReader();
            while (Autorization.sdr.Read())
            {
                comboBoxSpecialnost.Items.Add(Autorization.sdr[0]);
                comboBoxFacultet.Items.Add(Autorization.sdr[1]);
            }
            Autorization.connection.Close();
            Autorization.sdr.Close();
        }

        private void BtnAutorization_Click(object sender, EventArgs e)
        {
            if (comboBoxFacultet.Text != "")
            {
                int Cod_SF = Autorization.GetCodeOfTheTable("Select Cod_SF FROM SpecFac " +
                    "WHERE NameFac = '" + comboBoxFacultet.Text + "'");
                if (Autorization.GetExecuteNonQuery("Delete FROM Jurnal WHERE Cod_Uch in " +
                    "(Select Cod_Uch FROM Uchenik where Cod_gr in " +
                    "(Select Cod_gr FROM GrUcenic WHERE Cod_SF = " + Cod_SF + "))"))
                if (Autorization.GetExecuteNonQuery("Delete from Uchenik where Cod_gr in (Select Cod_Gr from GrUcenic where Cod_SF = "+Cod_SF+")"))
                if(Autorization.GetExecuteNonQuery("DELETE FROM GrUcenic WHERE Cod_SF = " + Cod_SF))
                if (Autorization.GetExecuteNonQuery("DELETE FROM SpecFac WHERE Cod_SF = " + Cod_SF)) MessageBox.Show("Вы успешно удалили факультет "+comboBoxFacultet.Text+"!", "Успех");
                
                
            }
            else if (comboBoxSpecialnost.Text != "")
            {
                int Cod_SF = Autorization.GetCodeOfTheTable("Select Cod_SF FROM SpecFac " +
                    "WHERE NameSpet = '" + comboBoxSpecialnost.Text + "'");
                if (Autorization.GetExecuteNonQuery("Delete FROM Jurnal WHERE Cod_Uch in " +
                    "(Select Cod_Uch FROM Uchenik where Cod_gr in " +
                    "(Select Cod_gr FROM GrUcenic WHERE Cod_SF = " + Cod_SF + "))"))
                    if (Autorization.GetExecuteNonQuery("Delete from Uchenik where Cod_gr in (Select Cod_Gr from GrUcenic where Cod_SF = " + Cod_SF+")"))
                if (Autorization.GetExecuteNonQuery("DELETE FROM GrUcenic WHERE Cod_SF = " + Cod_SF))
                if (Autorization.GetExecuteNonQuery("DELETE FROM SpecFac WHERE Cod_SF = " + Cod_SF)) MessageBox.Show("Вы успешно удалили специальность "+comboBoxSpecialnost.Text+"!", "Успех");
            }
            else MessageBox.Show("Заполните одно из полей для удаления.");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateComboBox();
            if (RadioButton1.Checked == true)
            {
                panel2.Visible = true;
                panel3.Visible = false;
                comboBoxSpecialnost.Text = "";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel3.Visible = true;
                panel2.Visible = false;
                comboBoxFacultet.Text = "";
            }
        }
    }
}
