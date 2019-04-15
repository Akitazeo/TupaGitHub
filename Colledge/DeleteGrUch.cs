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

                int Cod_gr = Autorization.GetCodeOfTheTable("Select Cod_gr FROM GrUcenic WHERE N_gr = '" + groupDelete.Text + "'");
                if (Autorization.GetExecuteNonQuery("Delete FROM Jurnal WHERE Cod_Uch in " +
                       "(Select Cod_Uch FROM Uchenik where Cod_gr = " + Cod_gr + ")"))
                {
                    if (Autorization.GetExecuteNonQuery("Delete from Uchenik where Cod_gr = " + Cod_gr))
                    {
                        if (Autorization.GetExecuteNonQuery("Delete from GrUchic = " + Cod_gr))
                        {
                            MessageBox.Show("Группа " + groupDelete.Text + " успешно удалена!");
                            groupDelete.Items.Clear();
                            funcUpdateItems();
                        }
                    }
                }
            
        }
    }
}
