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
    public partial class adaugaComanda : Form
    {
        DbConnector db;
        public adaugaComanda()
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
            DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa adaugati noua comanda?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.performCRUD("insert into Comenzi ([idFurnizor], [idUtilizator], [Sosire], [Stare]) Values('" + idFurnizor.Text + "','" + idUtilizator.Text + "','" + sosire.Text + "','" + stare.Text + "')");
                MessageBox.Show("Comanda adaugata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private bool isFormValid()
        {
            if (idFurnizor.Text.Trim() == string.Empty
                 || idUtilizator.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Va rugam completati campurile obligatorii, adica idFurnizor si idUtilizator", "Unele campuri sunt goale", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
