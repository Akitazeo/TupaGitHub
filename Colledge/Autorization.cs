using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colledge
{
    
    public partial class Autorization : Form
    {

        public Autorization()
        {
            
            connection = new SqlConnection(builder);
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(120, 253, 253, 196);
        }
        public static DateTime last_enter;
        private byte score = 3;
        public static string builder = @"Data Source=DESKTOP-G50ABLH\SQLEXPRESS1;Initial Catalog=newind;Integrated Security=True";
        public static SqlConnection connection = null;
        public static SqlCommand command = new SqlCommand();
        public static SqlDataReader sdr;
        private static int ActiveUser=0;
        
        public static int getActiveUser() { return ActiveUser; }
        public static void setActiveUser(int value) { ActiveUser = value; }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            last_enter = DateTime.Now;
            
            string login = tbLogin.Text;
            connection.ConnectionString = builder; //Соеденяюсь с БД
            connection.Open();                      // Открываю доступ
            command.CommandText = "SELECT * " + // Задаю команду T-SQL
                "FROM Userlog " +
                "WHERE (Lgn = '" + tbLogin.Text + "') and " +
                "(Pass = '" + tbPassword.Text + "')";
            try 
            {
                command.Connection = connection;     // Указываю для какого соеденения предназначен запрос
                sdr = command.ExecuteReader();       // Читаю результат из БД
                if (sdr.HasRows)                    // Проверяю наличие строк
                {
                    while (sdr.Read())
                    setActiveUser(sdr.GetByte(4));
                    this.Dispose();
                    command.Connection.Close();
                    command.Connection.Open();
                    command.CommandText = "UPDATE Userlog SET Last_Enter = '"+ last_enter.ToString("yyyy-dd-MM HH:mm:ss") + "' WHERE Lgn = '" + login + "'";
                    command.ExecuteNonQuery();
                }
                else
                {
                    tbPassword.Text = "";
                    tbLogin.Text = "";
                    score--;
                    MessageBox.Show("Неверная комбинация Логин/Пароль. Попробуйте ещё раз.");
                    if (score < 1) Application.Exit();
                }
            }
            finally
            {
                connection.Close();
                command.Connection.Close();
            }

           
        }


        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnAutorization_Click(sender, e);
        }



        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnAutorization_Click(sender, e);

        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
