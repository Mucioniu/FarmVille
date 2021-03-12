using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLRDbConnector;

namespace CsLoginRegister
{
    public partial class Adauga_plante : Form
    {
        DbConnector db;
        public Adauga_plante()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void Adauga_plante_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isFormValid())
            {
                insertValues();
            }
        }

        private void insertValues()
        {
            DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa adaugati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                db.performCRUD("insert into Plante (idCategoriePlante, DenumireStiintifica, DenumirePopulara, PerioadaPlantare, PerioadaRecoltare) Values('" + categoriePlanteText.Text + "','" + denStiintifica.Text + "','" + denPopulara.Text + "','" + perPlantare.Text + "','" + perRecoltare.Text + "')");
                MessageBox.Show("Planta adaugata cu succes","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private bool isFormValid()
        {
           if(denStiintifica.Text.Trim() == string.Empty 
                || denPopulara.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Va rugam completati campurile obligatorii","Unele campuri sunt goale",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           else {
                return true;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void categoriePlanteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void perRecoltare_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void perPlantare_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void denPopulara_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void denStiintifica_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
