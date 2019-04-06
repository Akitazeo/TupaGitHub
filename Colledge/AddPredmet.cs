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
    public partial class AddPredmet : UserControl
    {
        public AddPredmet()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Autorization.connection.Open();
                //Autorization.command.CommandText = "INSERT INTO PREDMET(NazvPredmeta, KodPredmeta) VALUES ('" + tbPredmet +"','" + 
            }
            finally { Autorization.connection.Close();}
        }
    }
}
