using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Colledge
{
    public partial class Menu : Form
    {
        //public string builder = @"Data Source=DESKTOP-G50ABLH\SQLEXPRESS1;Initial Catalog=newind;Integrated Security=True";
        //public SqlConnection connection = null;
        //public static SqlCommand command = new SqlCommand();
        private static byte buttonCounter = 0;
        public static int ponter_X = 220;
        public static int ponter_Y = 115;
        public Menu()
        {
            InitializeComponent();
            if (Autorization.getActiveUser() > 1) { mainAdd.Enabled = true; mainBtnDelete.Enabled = true; mainBtnEdit.Enabled = true; mainBtnBackUp.Enabled = true; }
            /*Подключение к базе: */
            //connection = new SqlConnection(builder);
            /**************/
        }

        public int Ponter_X { get { return ponter_X; } set { ponter_X = value; } }
        public int Ponter_Y { get { return ponter_Y; } set { ponter_Y = value; } }

        private void correctPlaceUserControl()
        {
            ponter_X += 300;
            if (ponter_X > 1200)
            {
                ponter_X = 220;
                ponter_Y += 250;
            }
        }

        private void funcCheckUser()
        {
            switch(Autorization.getActiveUser())
            {
                case 1:
                    mainBtnView.Visible = true;
                    mainBtnRestore.Visible = true;
                    mainBtnSwitch.Visible = true;
                    mainBtnOtchet.Visible = true;
                    mainBtnExit.Visible = true;
                    break;
                case 2:
                    mainBtnOtchet.Visible = true;
                    mainAdd.Visible = true;
                    mainBtnView.Visible = true;
                    mainBtnRestore.Visible = true;
                    mainBtnSwitch.Visible = true;
                    mainBtnExit.Visible = true;
                    mainBtnDelete.Visible = true;
                    mainBtnEdit.Visible = true;
                    break;
                case 3:
                    mainBtnOtchet.Visible = true;
                    mainAdd.Visible = true;
                    mainBtnView.Visible = true;
                    mainBtnRestore.Visible = true;
                    mainBtnSwitch.Visible = true;
                    mainBtnExit.Visible = true;
                    mainBtnDelete.Visible = true;
                    mainBtnEdit.Visible = true;
                    mainBtnMore.Visible = true;
                    mainBtnBackUp.Visible = true;
                    break;
            }
        }
        private void funcCheckTableAdd()
        {
            switch (buttonCounter)
            {
                case 1:
                    tsmUchenikAdd tsmUchenikAdd = new tsmUchenikAdd();
                    tsmUchenikAdd.Show();
                    break;
                case 2:
                    tsmAddUchitel tsmAddUchitel = new tsmAddUchitel();
                    tsmAddUchitel.Show();
                    break;
                case 3:
                    
                    break;
                case 4:
                    tsmAddSpecFaq tsmAddSpecFaq = new tsmAddSpecFaq();
                    tsmAddSpecFaq.Show();
                    break;
                case 5:
                    tsmJurnalAdd tsmJurnalAdd = new tsmJurnalAdd();
                    tsmJurnalAdd.Show();
                    break;
                case 6:
                    addGrUch grUchAdd = new addGrUch();
                    this.Controls.Add(grUchAdd);
                    grUchAdd.Location = new Point(ponter_X, ponter_Y);

                    break;
            }
        }
        private void funcCheckTableView()
        {
            switch (buttonCounter)
            {
                case 1:
                    ViewUchenik viewUchenik = new ViewUchenik();
                    viewUchenik.Show();
                    ViewUchOcenka viewUchOcenka = new ViewUchOcenka();
                    viewUchOcenka.Show();
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    
                    break;
            }
        }
        private void funcCheckTableEdit()
        {
            switch (buttonCounter)
            {
                case 1:
                    UchenikEdit uchenikEdit = new UchenikEdit();
                    uchenikEdit.Show();
                    break;
                case 2:
                    UchitelEdit uchitelEdit = new UchitelEdit();
                    uchitelEdit.Show();
                    break;
            }
        }
        private void funcCheckTableDelete()
        {
            switch (buttonCounter)
            {
                case 2:
                    UchitelDelete uchitel = new UchitelDelete();
                    uchitel.Show();
                    break;
                case 3:
                    PredmetDelete predmetDelete = new PredmetDelete();
                    predmetDelete.Show();
                    break;
                case 4:
                    SpetFacDelete spetFacDelete = new SpetFacDelete();
                    spetFacDelete.Show();
                    break;
                case 6:
                    GrUchDelete grUchDelete = new GrUchDelete();
                    grUchDelete.Show();
                    break;
            }
        }

        private void mainBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainBtnSwitch_Click(object sender, EventArgs e)
        {
            Autorization.setActiveUser(0);
            this.Dispose();
        }

        

        private void mainBtnUchenik_MouseEnter(object sender, EventArgs e)
        {
            mainBtnUchenik.BackgroundImage = new Bitmap(Properties.Resources.mainBtnUch);
        }
        private void mainBtnUchenik_Click(object sender, EventArgs e)
        {
            mainBtnUchenik.BackgroundImage = new Bitmap(Properties.Resources.mainBtnUch);
            label1.Visible = false;
            buttonCounter = 1;
            funcCheckUser();
        }

        private void mainBtnUchenik_MouseLeave(object sender, EventArgs e)
        {
            if(buttonCounter!=1)
            mainBtnUchenik.BackgroundImage = new Bitmap(Properties.Resources.mainBtnUchBrightness);
        }


        private void mainBtnUchitel_MouseEnter(object sender, EventArgs e)
        {
            mainBtnUchitel.BackgroundImage = new Bitmap(Properties.Resources.MainBtnUchitel);
        }

        private void mainBtnUchitel_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 2)
                mainBtnUchitel.BackgroundImage = new Bitmap(Properties.Resources.MainBtnUchitelBrightness);
        }
        private void mainBtnUchitel_Click(object sender, EventArgs e)
        {
            mainBtnUchitel.BackgroundImage = new Bitmap(Properties.Resources.MainBtnUchitel);
            buttonCounter = 2;
            label1.Visible = false;
            funcCheckUser();
        }


       

        private void mainBtnPredmet_MouseEnter(object sender, EventArgs e)
        {
            mainBtnPredmet.BackgroundImage = new Bitmap(Properties.Resources.MainBtnPredmet);
        }

        private void mainBtnPredmet_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            mainBtnPredmet.BackgroundImage = new Bitmap(Properties.Resources.MainBtnPredmet);
            buttonCounter = 3;
            funcCheckUser();
        }

        private void mainBtnPredmet_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 3)
                mainBtnPredmet.BackgroundImage = new Bitmap(Properties.Resources.MainBtnPredmetBrightness);
        }


        private void mainBtnOtchet_Click(object sender, EventArgs e)
        {
            AddAdministrator addAdministrator = new AddAdministrator();
            this.Controls.Add(addAdministrator);
            addAdministrator.Location = new Point(ponter_X, ponter_Y);
            addAdministrator.Visible = true;
            ponter_X += 320;
            if (ponter_X > 1200)
            {
                ponter_X = 224;
                ponter_Y += 250;
            }
        }


      

        private void mainBtnSpecFac_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 4)
                mainBtnSpecFac.BackgroundImage = new Bitmap(Properties.Resources.FacultetBrightness);
        }

        private void mainBtnSpecFac_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            mainBtnSpecFac.BackgroundImage = new Bitmap(Properties.Resources.Facultet);
            buttonCounter = 4;
            funcCheckUser();
        }

        private void mainBtnSpecFac_MouseEnter(object sender, EventArgs e)
        {
            mainBtnSpecFac.BackgroundImage = new Bitmap(Properties.Resources.Facultet);
        }

        private void mainBtnJournal_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            mainBtnJournal.BackgroundImage = new Bitmap(Properties.Resources.MainBtnJurnal);
            buttonCounter = 5;
            funcCheckUser();
        }

        private void mainBtnJournal_MouseEnter(object sender, EventArgs e)
        {
            mainBtnJournal.BackgroundImage = new Bitmap(Properties.Resources.MainBtnJurnal);
        }

        private void mainBtnJournal_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 5)
                mainBtnJournal.BackgroundImage = new Bitmap(Properties.Resources.MainBtnJurnalBrightness);
        }

        private void mainBtnGroup_MouseEnter(object sender, EventArgs e)
        {
            mainBtnGroup.BackgroundImage = new Bitmap(Properties.Resources.Group);
        }

        private void mainBtnGroup_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 6)
                mainBtnGroup.BackgroundImage = new Bitmap(Properties.Resources.GroupBrightness);
        }

        private void mainBtnGroup_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            mainBtnGroup.BackgroundImage = new Bitmap(Properties.Resources.Group);
            buttonCounter = 6;
            funcCheckUser();
        }

        private void mainAdd_Click(object sender, EventArgs e)
        {
            funcCheckTableAdd();
        }

        private void mainBtnView_Click(object sender, EventArgs e)
        {
            funcCheckTableView();
        }

        private void mainBtnEdit_Click(object sender, EventArgs e)
        {
            funcCheckTableEdit();
        }

        private void mainBtnDelete_Click(object sender, EventArgs e)
        {
            funcCheckTableDelete();
        }
    }

}
