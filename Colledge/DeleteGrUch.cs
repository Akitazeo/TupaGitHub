using System;
using System.Windows.Forms;

namespace Colledge
{
    public partial class DeleteGrUch : UserControl
    {
        public DeleteGrUch()
        {
            InitializeComponent();
            funcUpdateItems();
            
        }
        private void funcUpdateItems()
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT N_Gr FROM GrUcenic";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    groupDelete.Items.Add(Autorization.sdr[0]);
                }
            }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "DELETE FROM GrUcenic WHERE Cod_gr = (Select Cod_gr FROM GrUcenic WHERE N_gr = '" + groupDelete.Text + "')";
                Autorization.command.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено!");
                groupDelete.Items.Clear();
                funcUpdateItems();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); groupDelete.Text = ""; }
            finally { Autorization.connection.Close(); }
        }
    }
}
