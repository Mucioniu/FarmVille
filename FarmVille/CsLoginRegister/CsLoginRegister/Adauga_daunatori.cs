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
    public partial class Adauga_daunatori : Form
    {
        DbConnector db;
        public Adauga_daunatori()
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
                db.performCRUD("insert into Daunatori (idCategorieDaunatori, DenumireStiintifica, DenumirePopulara, [Pagubele la nivelul plantei], Culoare, Marime) Values('" + categorieDaunatori.Text + "','" + denStiintifica.Text + "','" + denPopulara.Text + "','" + planteAtacate.Text + "','" + culoare.Text + "','" + marime.Text + "')");
                MessageBox.Show("Daunator adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private bool isFormValid()
        {
            if (categorieDaunatori.Text.Trim() == string.Empty
                 || denStiintifica.Text.Trim() == string.Empty
                 || denPopulara.Text.Trim() == string.Empty)
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
