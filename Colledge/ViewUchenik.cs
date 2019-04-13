using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Colledge
{
    public partial class ViewUchenik : UserControl
    {
        Label label = new Label();
        public ViewUchenik()
        {
           
            InitializeComponent();
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT n_gr FROM GrUcenic ORDER BY n_gr";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    comboBox1.Items.Add(Autorization.sdr[0]);
                }
            }
            finally { Autorization.connection.Close(); }

            
            //comboBox1.Text = (string)comboBox1.Items[0];
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "SELECT FIO_Uch FROM Uchenik " +
                 "INNER JOIN GrUcenic ON GrUcenic.cod_gr = Uchenik.Cod_gr " +
                    "WHERE GrUcenic.cod_gr = (SELECT Cod_gr FROM GrUcenic WHERE N_gr = " + "'" + comboBox1.Text + "'" + ")";
                Autorization.sdr = Autorization.command.ExecuteReader();
                if(comboBox1.Text !="")
                while (Autorization.sdr.Read())
                {
                    comboBox2.Items.Add(Autorization.sdr[0]);
                }
            }
            finally { Autorization.connection.Close(); }
            }
        

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        try
        {
            Autorization.connection.Open();
            Autorization.command.CommandText = "SELECT COUNT(Propusk) " +
            "FROM Jurnal INNER JOIN Uchenik ON Uchenik.Cod_Uch " +
            "= Jurnal.Cod_Uch where Uchenik.FIO_Uch = '" + comboBox2.Text + "'";
            Autorization.sdr = Autorization.command.ExecuteReader();
            if (comboBox1.Text != "")
                while (Autorization.sdr.Read())
                {
                        label.Text = Autorization.sdr[0].ToString();
                }
        }
        finally { Autorization.connection.Close(); }
    
       
        int absence = Convert.ToInt32(label.Text);
            label1.Text +=' ' + label.Text;
            if (absence > 20) label1.ForeColor = Color.Yellow;
            if (absence > 30) label1.ForeColor = Color.Coral;
            if (absence > 40) label1.ForeColor = Color.Red;
            else label1.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
