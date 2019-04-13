using System;
using System.Windows.Forms;

namespace Colledge
{
    public partial class AddGrUch : UserControl
    {
        public AddGrUch()
        {
            InitializeComponent();
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select NameSpet From SpecFac";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    cbFac.Items.Add(Autorization.sdr[0]);
                }
            }
            finally { Autorization.connection.Close(); }
        }



        private int Cod_SF;
        private int ID;


        private void Cancel_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }
        private void cbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT  Cod_SF FROM SpecFac WHERE NameSpet= '" + cbFac.Text + "'";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    Cod_SF = (int)Autorization.sdr[0];
                }
            }
            finally { Autorization.connection.Close(); }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT TOP 1 Cod_gr FROM GrUcenic ORDER BY Cod_gr DESC";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    ID = (int)Autorization.sdr[0] + 1;
                }
            }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "INSERT INTO GrUcenic(Cod_gr,N_gr,Cod_SF) VALUES ('" +
                   ID + "','" + tbGroup.Text + "','" + Cod_SF + "')";
                Autorization.command.ExecuteNonQuery();
                MessageBox.Show("Вы удачно добавили группу!", "Успешно!");
            }
            finally { Autorization.connection.Close(); }
        }
    }
}
