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
    public partial class AddSpecFac : UserControl
    {
        /**************************************************/
        int Cod_SF;
        /**************************************************/


        public AddSpecFac()
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
            Cod_SF = Autorization.GetCodeOfTheTable("Select TOP 1 Cod_SF FROM SpecFac" +
                " ORDER BY Cod_SF DESC") + 1;
            if(Autorization.GetExecuteNonQuery("INSERT INTO SpecFac(Cod_SF,NameSpet,NameFac)" +
                "Values(" + Cod_SF + ",'" + tbSpecialnost.Text + "','"
                + tbFacultet.Text + "')"))MessageBox.Show("Успешно добавлено!","Успех!");
        }
    }
}
