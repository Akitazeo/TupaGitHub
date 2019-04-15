using System;
using System.Windows.Forms;

namespace Colledge
{
    public partial class AddUchenik : UserControl
    {
        int Cod_gr, Cod_Uch;
        public AddUchenik()
        {
            InitializeComponent();
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select N_gr FROM GrUcenic";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    Student.Items.Add(Autorization.sdr[0]);
                }
            }
            catch (Exception e)
            { MessageBox.Show(e.ToString(), "Error"); }
            finally { Autorization.connection.Close(); }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Cod_Uch = Autorization.GetCodeOfTheTable("Select TOP 1 Cod_Uch FROM Uchenik ORDER BY Cod_Uch DESC") + 1;
            try
            {
                if (Cod_gr != -1 && Cod_Uch != -1 && FIO.Text != "" && IDNP.Text != "" && Adress.Text != "")
                {
                    Autorization.GetExecuteNonQuery("INSERT INTO Uchenik" +
                        "(Cod_Uch,Cod_gr,IDNP,FIO_Uch,Adress) VALUES(" +
                        Cod_Uch + "," + Cod_gr + "," +
                        IDNP.Text + ",'" + FIO.Text + "','" + Adress.Text + "')");
                    MessageBox.Show("Ученик добавлен успешно!", "Успех!");
                }
                else MessageBox.Show("Заполните все необходимые поля.");
            }
            finally { Autorization.connection.Close(); }
        }

        private void Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cod_gr = Autorization.GetCodeOfTheTable("Select Cod_gr from GrUcenic where N_gr = '" + Student.Text + "'");
        }
    }
}
