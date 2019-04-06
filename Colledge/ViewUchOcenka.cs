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
    public partial class ViewUchOcenka : UserControl
    {
        public ViewUchOcenka()
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
    "WHERE GrUcenic.cod_gr = (SELECT Cod_gr FROM GrUcenic WHERE N_gr = " + "'" + comboBox1.Text + "'" + ")";
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
            comboBox3.Items.Clear();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-G50ABLH\SQLEXPRESS1";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "newind";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();

            string us = "Select NazvPredmeta FROM Predmet";
            if (comboBox1.Text != "")
            {
                SqlCommand usc = new SqlCommand(us, connection);
                SqlDataReader usr = usc.ExecuteReader();

                while (usr.Read())
                {
                    comboBox3.Items.Add(usr[0]);
                }
                usr.Close();
                connection.Close();
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Средняя оценка: ";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-G50ABLH\SQLEXPRESS1";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "newind";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();

            string us = "select ISNULL(AVG(Ocenka),0) " +
                "as 'Средняя оценка' from Jurnal " +
                "inner join Uchenik on Uchenik.Cod_Uch = Jurnal.Cod_Uch " +
                "where Jurnal.KodPredmeta = " +
                "(Select KodPredmeta from Predmet where NazvPredmeta = " +
                "'"+comboBox3.Text+"')"+
                "and Uchenik.Cod_Uch = " +
                "(SELECT Uchenik.Cod_Uch FROM Uchenik where FIO_Uch = " +
                "'"+comboBox2.Text+"')";
            if (comboBox1.Text != "")
            {
                SqlCommand usc = new SqlCommand(us, connection);
                SqlDataReader usr = usc.ExecuteReader();

                while (usr.Read())
                {
                    label3.Text+=usr[0];
                    if ((int)usr[0] > 7) label3.ForeColor = Color.Green;
                }
                usr.Close();
                connection.Close();

            }
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
