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
    public partial class DeletePredmet : UserControl
    {
        public DeletePredmet()
        {
            InitializeComponent();
            funcRefreshList();
            
        }
        private void funcRefreshList()
        {
            cbpredDelete.Items.Clear();
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select NazvPredmeta FROM Predmet";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    cbpredDelete.Items.Add(Autorization.sdr[0]);
                }
            }
            finally { Autorization.connection.Close(); }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "DELETE FROM Predmet WHERE KodPredmeta = " +
                    "(Select KodPredmeta FROM Predmet WHERE NazvPredmeta = '" + cbpredDelete.Text + "')";
                Autorization.command.ExecuteNonQuery();
                MessageBox.Show("Предмет успешно удалён.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                funcRefreshList();
            }
            finally { Autorization.connection.Close();}
        }
    }
}
