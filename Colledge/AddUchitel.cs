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
    public partial class AddUchitel : UserControl
    {
        public AddUchitel()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Menu.deleteSpace();
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(textBoxFIO.Text!="")
            {
                
                
                    int Cod_Uchit = Autorization.GetCodeOfTheTable("SELECT TOP 1 Cod_Uchit FROM Uchitel ORDER BY DESC") + 1;
                    if(Autorization.GetExecuteNonQuery("INSERT INTO Uchitel(Cod_Uchit,FIO_Uchit) VALUES(" + Cod_Uchit + ",'" + textBoxFIO.Text + "')"))
                    MessageBox.Show("Учитель успешно добавлен!","Успех",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                
                
            }
        }
    }
}
