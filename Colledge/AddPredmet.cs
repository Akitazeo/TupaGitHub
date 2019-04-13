using System;
using System.Windows.Forms;

namespace Colledge
{
    public partial class AddPredmet : UserControl
    {
        public AddPredmet()
        {
            InitializeComponent();
        }
        int id;
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT TOP 1 KodPredmeta FROM Predmet ORDER BY KodPredmeta DESC";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                    id = (int)Autorization.sdr[0] + 1;
                Autorization.sdr.Close();
                if (tbPredmet.Text != "")
                {
                    Autorization.command.CommandText = "INSERT INTO Predmet (NazvPredmeta, KodPredmeta) VALUES ('" + tbPredmet.Text + "','" + id + "')";
                    Autorization.command.ExecuteNonQuery();
                    MessageBox.Show("Предмет добавлен успешно!", "Успех!");
                }
                else { MessageBox.Show("Введите предмет!", "Ошибка!"); tbPredmet.Text = ""; }

            }
            finally { Autorization.connection.Close(); }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }
    }
}
