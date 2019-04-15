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
    public partial class EditUchUK : UserControl
    {
        public EditUchUK()
        {
            InitializeComponent();
            
            panel1.BackColor = Color.FromArgb(120, 218, 97, 4);
            SmenaGr.BackColor = Color.Transparent;
            SmenaFIO.BackColor = Color.Transparent;
            SmenaAd.BackColor = Color.Transparent;
            SmenaFIO.Visible = false;
            SmenaAd.Visible = false;
            updateNEWgroup();
        }
        int Cod_GR=-1;

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNEWGroup.Checked == true)
            {
                SmenaGr.Visible = true;

            }
            else SmenaGr.Visible = false;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNEWFIO.Checked == true)
            {
                SmenaFIO.Visible = true;
            }
            else SmenaFIO.Visible = false;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNEWADRESS.Checked == true)
            {
                SmenaAd.Visible = true;
            }
            else SmenaAd.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateComboBox()
        {
            
            
            ComboBoxEUnewgr.Items.Clear();
            try { Autorization.connection.Close(); }catch{ }
            try
            {

                Autorization.connection.Open();
                Autorization.command.CommandText = "Select N_gr FROM GrUchenic";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    
                }
            }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
        }
        private void updateNEWgroup()
        {
            ComboBoxEUgr3.Items.Clear();
            ComboBoxEUelev3.Items.Clear();
            ComboBoxEUnewgr.Items.Clear();
            fillComboBoxGroupOld();
        }
        private void fillComboBoxGroupOld()
        {
            try { Autorization.connection.Close(); } catch { }
            try
            {
                Autorization.connection.Open();
                Autorization.command.CommandText = "Select N_gr FROM GrUcenic";
                Autorization.sdr = Autorization.command.ExecuteReader();
                while (Autorization.sdr.Read())
                {
                    ComboBoxEUgr3.Items.Add(Autorization.sdr[0]);
                    if (radioButtonNEWGroup.Checked)
                    {
                        ComboBoxEUnewgr.Items.Add(Autorization.sdr[0]);
                    }
                }
            }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
        }
        private void fillSelectedUchenik()
        {
            try { Autorization.connection.Close(); } catch { }
            try
            {
                Autorization.connection.Open();
                
                Cod_GR = Autorization.GetCodeOfTheTable("Select Cod_gr from " +
                    "GrUcenic where N_gr = '" + ComboBoxEUgr3.Text + "'");

                if (Cod_GR != -1)
                {
                    Autorization.command.CommandText =
                          "Select FIO_Uch FROM " +
                      "Uchenik WHERE Cod_gr = " + Cod_GR;
                    Autorization.connection.Open();
                    Autorization.sdr = Autorization.command.ExecuteReader();
                    while (Autorization.sdr.Read())
                    {
                            ComboBoxEUelev3.Items.Add(Autorization.sdr[0]);
                    }
                }
            }
            finally { Autorization.connection.Close(); Autorization.sdr.Close(); }
        }

        private void ComboBoxEUgr3_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillSelectedUchenik();
        }

        private void ComboBoxEUelev3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
