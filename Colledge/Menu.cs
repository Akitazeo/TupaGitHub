using System;
using System.Drawing;
using System.Windows.Forms;
namespace Colledge
{
    public partial class Menu : Form
    {
        //public string builder = @"Data Source=DESKTOP-G50ABLH\SQLEXPRESS1;Initial Catalog=newind;Integrated Security=True";
        //public SqlConnection connection = null;
        //public static SqlCommand command = new SqlCommand();
        private byte buttonCounter = 0;
        private static int ponter_X = 220;
        private static int ponter_Y = 115;
        public Menu()
        {
            InitializeComponent();
            funcCheckValidation();
            /*Подключение к базе: */
            //connection = new SqlConnection(builder);
            /**************/
        }

        public static int Ponter_X { get { return ponter_X; } set { ponter_X = value; } }
        public static int Ponter_Y { get { return ponter_Y; } set { ponter_Y = value; } }

        public static void addSpace(int x)
        {
            ponter_X += x;
            if (ponter_X > 1200)
            {
                ponter_X = 220;
                ponter_Y += 300;
            }
        }
        public static void deleteSpace()
        {
            if (Ponter_X > 300) ponter_X -= 220;
            if (Ponter_Y > 250) ponter_Y -= 150;
        }
        private void funcCheckValidation()
        {

            if (Autorization.getActiveUser() > 0)
            {
                mainBtnView.Enabled = true;
                mainBtnRestore.Enabled = true;
                mainBtnSwitch.Enabled = true;
                mainBtnOtchet.Enabled = true;
                mainBtnExit.Enabled = true;
            }
            if (Autorization.getActiveUser() > 1)
            {
                mainAdd.Enabled = true;
                mainBtnDelete.Enabled = true;
                mainBtnEdit.Enabled = true;
            }
            if (Autorization.getActiveUser() > 2)
            {
                mainBtnMore.Enabled = true;
                mainBtnBackUp.Enabled = true;
            }

        }
        private void funcCheckUser()
        {

            if (Autorization.getActiveUser() > 0)
            {
                mainBtnView.Visible = true;
                mainBtnRestore.Visible = true;
                mainBtnSwitch.Visible = true;
                mainBtnOtchet.Visible = true;
                mainBtnExit.Visible = true;
            }
            if (Autorization.getActiveUser() > 1)
            {
                mainAdd.Visible = true;
                mainBtnDelete.Visible = true;
                mainBtnEdit.Visible = true;
            }
            if (Autorization.getActiveUser() > 2)
            {
                mainBtnMore.Visible = true;
                mainBtnBackUp.Visible = true;
            }
            
        }
        private void funcCheckTableAdd()
        {
            switch (buttonCounter)
            {
                case 1:
                    AddUchenik addUchenik = new AddUchenik();
                    this.Controls.Add(addUchenik);
                    addUchenik.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(225+20);
                        break;
                case 2:
                    AddUchitel addUchitel = new AddUchitel();
                    this.Controls.Add(addUchitel);
                    addUchitel.Location = new Point(Ponter_X, ponter_Y);
                    addSpace(200 + 20);
                    break;
                case 3:
                    AddPredmet addPredmet = new AddPredmet();
                    this.Controls.Add(addPredmet);
                    addPredmet.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(257+20);
                    break;
                case 4:
                    AddSpecFac addSpecFac = new AddSpecFac();
                    this.Controls.Add(addSpecFac);
                    addSpecFac.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(225 + 20);
                    break;
                    
                case 5:
                    AddJurnal addJurnalUC = new AddJurnal();
                    this.Controls.Add(addJurnalUC);
                    addJurnalUC.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(337+20);
                    break;
                case 6:
                    AddGrUch grUchAdd = new AddGrUch();
                    this.Controls.Add(grUchAdd);
                    grUchAdd.Location = new Point(ponter_X, ponter_Y);
                    addSpace(178+20);
                    break;
            }
        }
        private void funcCheckTableView()
        {
            switch (buttonCounter)
            {
                case 1: // 1 -- Вывод информации об ученике
                    ViewUchenik viewUchenik = new ViewUchenik();
                    this.Controls.Add(viewUchenik);
                    viewUchenik.Location = new Point(ponter_X, ponter_Y);
                    addSpace(290+20);
                    ViewUchOcenka viewUchOcenka = new ViewUchOcenka();
                    this.Controls.Add(viewUchOcenka);
                    viewUchOcenka.Location = new Point(ponter_X, ponter_Y);
                    addSpace(290+20);
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
                    EditUchUK editUchUK = new EditUchUK();
                    this.Controls.Add(editUchUK);
                    editUchUK.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(390+20);
                    break;
                case 2:
                    EditUchitell editUchitell = new EditUchitell();
                    this.Controls.Add(editUchitell);
                    editUchitell.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(266 + 20);
                    break;
                

            }
        }
        private void funcCheckTableDelete()
        {
            switch (buttonCounter)
            {
                case 1:
                    mainBtnDelete.Enabled = false;
                    break;
                case 2:
                    DeleteUchitel deleteUchitel = new DeleteUchitel();
                    this.Controls.Add(deleteUchitel);
                    deleteUchitel.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(225 + 20); //??? Проверить размеры формы.
                    break;
                case 3:
                    DeletePredmet predmetDelete = new DeletePredmet();
                    this.Controls.Add(predmetDelete);
                    predmetDelete.Location = new Point(Ponter_X, ponter_Y);
                    addSpace(225);
                    break;
                case 4:
                    DeleteSpecFacultet deleteSpecFacultet = new DeleteSpecFacultet();
                    this.Controls.Add(deleteSpecFacultet);
                    deleteSpecFacultet.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(273 + 20);
                    break;
                case 5:
                    mainBtnDelete.Enabled = false;
                    break;
                case 6:
                    DeleteGrUch deleteGrUch = new DeleteGrUch();
                    this.Controls.Add(deleteGrUch);
                    deleteGrUch.Location = new Point(Ponter_X, Ponter_Y);
                    addSpace(267+20);
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
            mainBtnDelete.Enabled = false;
            funcCheckUser();
        }

        private void mainBtnUchenik_MouseLeave(object sender, EventArgs e)
        {
            if (buttonCounter != 1)
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
            addSpace(306+20);
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

        private void MainBtnOtchet_Click_1(object sender, EventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.ShowDialog();
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
