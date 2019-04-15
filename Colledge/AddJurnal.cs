using System;
using System.Windows.Forms;

namespace Colledge
{
    public partial class AddJurnal : UserControl
    {
        int KodPredmeta,Cod_Uchit,Cod_Uch;

        public AddJurnal()
        {
            InitializeComponent();
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select NazvPredmeta FROM Predmet ORDER BY KodPredmeta DESC";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    Predmet.Items.Add(Autorization.sdr[0]);
                }
                
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select FIO_Uchit FROM Uchitel ORDER BY Cod_Uchit DESC";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    Prepod.Items.Add(Autorization.sdr[0]);
                }
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select FIO_Uch from Uchenik ORDER BY Cod_Uch DESC";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    Student.Items.Add(Autorization.sdr[0]);
                    
                }
            }
            //catch (Exception ex) { MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
        }
        private string data;

        private void Cancel_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            KodPredmeta = Autorization.GetCodeOfTheTable("Select KodPredmeta FROM Predmet Where KodPredmeta = (Select KodPredmeta FROM Predmet Where NazvPredmeta = '" + Predmet.Text + "')");
            Cod_Uch = Autorization.GetCodeOfTheTable("Select Cod_Uch FROM Uchenik WHERE Cod_Uch = (Select Cod_Uch FROM Uchenik WHERE FIO_Uch = '" + Student.Text + "')");
            Cod_Uchit = Autorization.GetCodeOfTheTable("Select Cod_Uchit FROM Uchitel WHERE Cod_Uchit = (Select Cod_Uchit FROM Uchitel WHERE FIO_Uchit = '" + Prepod.Text + "')");
            data = tsmUchenikAddDate.Text.Replace('.', '-');
            if (KodPredmeta != -1 && Cod_Uch != -1 && Cod_Uchit != -1)
            {
                if (radioButtonWas.Checked && checkBox1.Checked && rate.Text != "")
                {
                    Autorization.GetExecuteNonQuery("INSERT INTO Jurnal(KodPredmeta,Cod_Uchit,Cod_Uch,Ocenka,Jur_data) " +
                        "VALUES(" + KodPredmeta + "," + Cod_Uchit + "," + Cod_Uch + "," + rate.Text + ",'" + data + "')");
                }
                else if (radioButton1.Checked)
                {
                    Autorization.GetExecuteNonQuery("INSERT INTO Jurnal(KodPredmeta,Cod_Uchit,Cod_Uch,Propusk,Jur_data) " +
                        "VALUES(" + KodPredmeta + "," + Cod_Uchit + "," + Cod_Uch + ",'a','" + data + "')");
                }
                else
                {
                    Autorization.GetExecuteNonQuery("INSERT INTO Jurnal(KodPredmeta,Cod_Uchit,Cod_Uch,Jur_data) " +
                        "VALUES(" + KodPredmeta + "," + Cod_Uchit + "," + Cod_Uch + ",'" + data + "')");
                }
                MessageBox.Show("Запись успешно добавлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Visible = false;
            }
        }

        private void RadioButtonWas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWas.Checked)
            {
                checkBox1.Visible = true;
            }
        }

        private void Rate_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                rate.Visible = true;
            }

            else
            {
                rate.Visible = false;
                rate.Text = "";
            }
        }

        private void TsmUchenikAddDate_ValueChanged(object sender, EventArgs e)
        {
            data = tsmUchenikAddDate.Text.Replace('.', '-');
            MessageBox.Show(data);
        }
    }
}
