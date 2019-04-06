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
        public ViewUchenik()
        {
           
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-G50ABLH\SQLEXPRESS1";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "newind";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            string groupselect = "SELECT n_gr FROM GrUcenic ORDER BY n_gr";
            SqlCommand gs = new SqlCommand(groupselect, connection);
            connection.Open();
            SqlDataReader gsr = gs.ExecuteReader();

            while (gsr.Read())
            {
                comboBox1.Items.Add(gsr[0]);
            }
            gsr.Close();
            connection.Close();
            
            //comboBox1.Text = (string)comboBox1.Items[0];
        }

        private void ViewUchenik_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-G50ABLH\SQLEXPRESS1";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "newind";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();
            
            string us = "SELECT FIO_Uch FROM Uchenik " +
    "INNER JOIN GrUcenic ON GrUcenic.cod_gr = Uchenik.Cod_gr " +
    "WHERE GrUcenic.cod_gr = (SELECT Cod_gr FROM GrUcenic WHERE N_gr = " + "'"  + comboBox1.Text + "'"  + ")";
            if (comboBox1.Text != "")
            {
                SqlCommand usc = new SqlCommand(us, connection);
                SqlDataReader usr = usc.ExecuteReader();

                while (usr.Read())
                {
                    comboBox2.Items.Add(usr[0]);
                }
                usr.Close();
                connection.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            string pr = "SELECT COUNT(Propusk) " +
                "FROM Jurnal INNER JOIN Uchenik ON Uchenik.Cod_Uch " +
                "= Jurnal.Cod_Uch where Uchenik.FIO_Uch = '"+ comboBox2.Text + "'";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-G50ABLH\SQLEXPRESS1";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "newind";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            SqlCommand prc = new SqlCommand(pr, connection);
            SqlDataReader prdr = prc.ExecuteReader();

            while(prdr.Read())
            {
                label1.Text += prdr[0];
            }
            int absence = Convert.ToInt32(label1.Text);
            if (absence > 20) label1.ForeColor = Color.Yellow;
            if (absence > 30) label1.ForeColor = Color.Coral;
            if (absence > 40) label1.ForeColor = Color.Red;
            prdr.Close();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Menu m = new Menu();
            m.Ponter_X = 0;
            m.Ponter_Y = 20;
            this.Dispose();
        }
    }
}
