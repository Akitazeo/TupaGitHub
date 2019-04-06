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
    public partial class addGrUch : UserControl
    {
        public addGrUch()
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
            finally {Autorization.connection.Close();}
        }
        private static int ID = 12;
        public int Cod_SF;
        private void Cancel_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            try
            {
                Autorization.connection.Open();

                Autorization.command.CommandText = "INSERT INTO GrUcenic(Cod_gr,N_gr,Cod_SF) VALUES ('" +
                    ID++ + "','" + tbGroup.Text + "','" + Cod_SF + "')";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    cbFac.Items.Add(Autorization.sdr[0]);
                }
                MessageBox.Show("Вы удачно добавили пользователя!", "Успешно!");
            }
            finally { Autorization.connection.Close(); }
        }

        private void cbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT Cod_SF FROM SpecFac WHERE NameSpet= '" + cbFac.Text + "'";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while(Autorization.sdr.Read())
                {
                    Cod_SF = (int) Autorization.sdr[0];
                }
            }
            finally { Autorization.connection.Close(); }
        }
    }
}
