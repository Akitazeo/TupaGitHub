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
    public partial class DeleteUchitel : UserControl
    {
        public DeleteUchitel()
        {
            InitializeComponent();
            UpdateComboBox();
        } 
        private void UpdateComboBox()
        {
            comboBoxUchDelete.Items.Clear();
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select FIO_Uchit FROM Uchitel";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    comboBoxUchDelete.Items.Add(Autorization.sdr[0]);
                }
                Autorization.connection.Close(); Autorization.sdr.Close();
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int Cod_Uchit=-1;
            if (comboBoxUchDelete.Text != "")
              Cod_Uchit = Autorization.GetCodeOfTheTable("Select Cod_Uchit FROM Uchitel where FIO_Uchit = '" + comboBoxUchDelete.Text + "'");
            if (Cod_Uchit != -1)
                if (Autorization.GetExecuteNonQuery("Delete FROM Jurnal WHERE Cod_Uchit = " + Cod_Uchit))
                    if (Autorization.GetExecuteNonQuery("Delete FROM Uchitel WHERE Cod_Uchit = " + Cod_Uchit)) MessageBox.Show("Учитель " + comboBoxUchDelete.Text + " успешно удалён!");
                    else MessageBox.Show("Учитель не был удалён.", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            UpdateComboBox();
        }
    }
}
