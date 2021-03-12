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

namespace CsLoginRegister.UserControls
{
    
    public partial class UC_daunatori : UserControl
    {
        DbConnector db;
        public UC_daunatori()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void UC_daunatori_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from Daunatori", dataGridView1);
            db.fillDataGridView("select * from CategorieDaunatori", dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Adauga_daunatori ap = new Adauga_daunatori())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        string daunatorID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                daunatorID = item.Cells[0].Value.ToString();
            }
        }

        private void stergePlante_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sunteti sigur ca doriti sa stergeti daunatorul selectat?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (!daunatorID.Equals(string.Empty))
                {
                    db.performCRUD("delete from Daunatori where idDaunator = '" + daunatorID + "'");
                    MessageBox.Show("Daunatorul a fost sters cu succes", "Daunator sters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.OnLoad(e);
                }
            }
        }

        private void updatePlante_Click(object sender, EventArgs e)
        {
            using (updateDaunator ap = new updateDaunator())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (adaugaCategorieDaunatori ap = new adaugaCategorieDaunatori())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string categorieID;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView2.SelectedRows)
            {
                categorieID = item.Cells[0].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sunteti sigur ca doriti sa stergeti categoria selectata?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (!categorieID.Equals(string.Empty))
                {
                    db.performCRUD("delete from CategorieDaunatori where [idCategorieDaunatori] = '" + categorieID + "'");
                    MessageBox.Show("Categoria a fost stearsa cu succes!", "Categorie stearsa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.OnLoad(e);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (cmbSearchBy.SelectedItem.ToString().Equals("DenumireStiintifica"))
            {
                query = "select * from Daunatori where DenumireStiintifica like '%" + txtSearch.Text + "%' ";
            }

            else if (cmbSearchBy.SelectedItem.ToString().Equals("DenumirePopulara"))
            {
                query = "select * from Daunatori where DenumirePopulara like '%" + txtSearch.Text + "%' ";
            }
            db.fillDataGridView(query, dataGridView1);
            if (txtSearch.Text == "")
            {
                this.OnLoad(e);
            }
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (updateCategorieDaunator ap = new updateCategorieDaunator())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
