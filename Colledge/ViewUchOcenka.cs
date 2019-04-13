using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace Colledge
{
    public partial class ViewUchOcenka : UserControl
    {
        public ViewUchOcenka()
        {
            InitializeComponent();
            Otchet otchet = new Otchet();
            otchet.Show();
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
            finally
            {
                Autorization.sdr.Close();
                Autorization.connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Autorization.connection.Open();
            Autorization.command.CommandText = "SELECT FIO_Uch FROM Uchenik " +
    "INNER JOIN GrUcenic ON GrUcenic.cod_gr = Uchenik.Cod_gr " +
    "WHERE GrUcenic.cod_gr = (SELECT Cod_gr FROM GrUcenic WHERE N_gr = " + "'" + comboBox1.Text + "'" + ")";
            try
            {
                if (comboBox1.Text != "")
                {
                    Autorization.sdr = Autorization.command.ExecuteReader();
                    while (Autorization.sdr.Read())
                    {
                        comboBox2.Items.Add(Autorization.sdr[0]);
                    }
                }

            }
            finally { Autorization.connection.Close();Autorization.sdr.Close(); }
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            Autorization.connection.Open();
            Autorization.command.CommandText = "Select NazvPredmeta FROM Predmet";
            try
            {
                if (comboBox1.Text != "")
                {
                    Autorization.sdr = Autorization.command.ExecuteReader();

                    while (Autorization.sdr.Read())
                    {
                        comboBox3.Items.Add(Autorization.sdr[0]);
                    }
                }
            }
            finally { Autorization.connection.Close();Autorization.sdr.Close(); }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "Средняя оценка: ";

            try
            {
                Autorization.connection.Open();


                if (comboBox1.Text != "")
                {
                    Autorization.command.CommandText = "select ISNULL(AVG(Ocenka),0) " +
                    "as 'Средняя оценка' from Jurnal " +
                    "inner join Uchenik on Uchenik.Cod_Uch = Jurnal.Cod_Uch " +
                    "where Jurnal.KodPredmeta = " +
                    "(Select KodPredmeta from Predmet where NazvPredmeta = " +
                    "'" + comboBox3.Text + "')" +
                    "and Uchenik.Cod_Uch = " +
                    "(SELECT Uchenik.Cod_Uch FROM Uchenik where FIO_Uch = " +
                    "'" + comboBox2.Text + "')";
                    Autorization.sdr = Autorization.command.ExecuteReader();

                    while (Autorization.sdr.Read())
                    {
                        label3.Text += Autorization.sdr[0];
                        if ((int)Autorization.sdr[0] > 7) label3.ForeColor = Color.Green;
                    }

                }
            }
            finally { Autorization.connection.Close();Autorization.sdr.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu.Ponter_X -= 220;
            Menu.Ponter_Y -= 115;
            this.Dispose();
        }
    }
}
