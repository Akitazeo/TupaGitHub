using System;
using System.Windows.Forms;

namespace Colledge
{
    public partial class EditUchitell : UserControl
    {
        public EditUchitell()
        {
            InitializeComponent();
            updateComboBox();
        }
        private void updateComboBox()
        {
            try
            { Autorization.connection.Close(); }
            catch { }
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select FIO_Uchit FROM Uchitel";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    comboBoxUchDelete.Items.Add(Autorization.sdr[0]);
                }
            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int Cod_Uchit;
            if (comboBoxUchDelete.Text != "")
            {
                Cod_Uchit = Autorization.GetCodeOfTheTable
                    ("SELECT Cod_Uchit FROM Uchitel WHERE FIO_Uchit = '"+comboBoxUchDelete.Text+"'");
                if (Autorization.GetExecuteNonQuery
                    ("Update Uchitel SET FIO_Uchit = '"+tbGroup.Text+"' WHERE Cod_Uchit = "+Cod_Uchit))
                    MessageBox.Show("Вы успешно изменили ФИО на " + tbGroup.Text + "!");
            }

        }

        private void ComboBoxUchDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
