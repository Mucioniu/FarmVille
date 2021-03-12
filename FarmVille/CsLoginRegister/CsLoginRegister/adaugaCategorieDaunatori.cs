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
    public partial class adaugaCategorieDaunatori : Form
    {
        DbConnector db;
        public adaugaCategorieDaunatori()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                insertValues();
            }
        }

        private void insertValues()
        {
            DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa adaugati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.performCRUD("insert into CategorieDaunatori ([Denumire Stiintifica], [Denumire uzuala], Ordin) Values('" + denStiintifica.Text + "','" + denPopulara.Text + "','" + ordin.Text + "')");
                MessageBox.Show("Categorie adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private bool isFormValid()
        {
            if (denStiintifica.Text.Trim() == string.Empty
                 || denPopulara.Text.Trim() == string.Empty
                 || ordin.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Va rugam completati campurile obligatorii", "Unele campuri sunt goale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
