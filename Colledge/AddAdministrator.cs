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
    public partial class AddAdministrator : UserControl
    {
        public AddAdministrator()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Menu.ponter_X = 220;
            Menu.ponter_Y = 115;
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text !="" && tbPassword.Text !="" && lvlModificaton.Text !="")
                try
                {
                    Autorization.last_enter = DateTime.Now;
                    Autorization.connection.Open();

                    Autorization.command.CommandText = "INSERT INTO Userlog " +
                    "(Lgn,Pass,Date_Registration,Last_Enter,LevelUser) VALUES ('" +
                     tbLogin.Text + "'" + ",'" + tbPassword.Text + "','" +
                     Autorization.last_enter.ToString("yyyy-dd-MM HH:mm:ss") + "','"
                     + Autorization.last_enter.ToString("yyyy-dd-MM HH:mm:ss") +
                     "','" + lvlModificaton.Text + "')";
                    //Autorization.command.Connection.Open();
                    Autorization.command.ExecuteNonQuery();
                    MessageBox.Show("Вы удачно добавили пользователя!", "Успешно!");
                    this.Dispose();
                }
                finally { Autorization.command.Connection.Close(); Autorization.connection.Close(); }
            else MessageBox.Show("Произошла ошибка.", "Неудача..");
        }
    }
}
