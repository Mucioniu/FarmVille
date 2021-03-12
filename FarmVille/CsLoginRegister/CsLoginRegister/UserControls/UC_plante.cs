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
    public partial class UC_plante : UserControl
    {
        DbConnector db;
        public UC_plante()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Adauga_plante ap = new Adauga_plante())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UC_plante_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from Plante", dataGridView1);
            db.fillDataGridView("select * from CategoriePlante", dataGridView2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if(cmbSearchBy.SelectedItem.ToString().Equals("DenumireStiintifica"))
            {
                query = "select * from Plante where DenumireStiintifica like '%" + txtSearch.Text+"%' ";
            }

            else if (cmbSearchBy.SelectedItem.ToString().Equals("DenumirePopulara"))
            {
                query = "select * from Plante where DenumirePopulara like '%" + txtSearch.Text + "%' ";
            }
            db.fillDataGridView(query, dataGridView1);
            if(txtSearch.Text == "")
            {
                this.OnLoad(e);
            }
        }

        string planteID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow item in dataGridView1.SelectedRows)
            {
                planteID = item.Cells[0].Value.ToString();
            }
        }

        private void stergePlante_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sunteti sigur ca doriti sa stergeti planta selectata?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                if (!planteID.Equals(string.Empty))
                {
                    db.performCRUD("delete from Plante where idPlante = '"+planteID+"'");
                    MessageBox.Show("Planta a fost stearsa cu succes!", "Planta stearsa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.OnLoad(e);
                }
            }
        }

        private void updatePlante_Click(object sender, EventArgs e)
        {
            using (UpdatePlante ap = new UpdatePlante())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Adauga_categorie ap = new Adauga_categorie())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
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
                    db.performCRUD("delete from CategoriePlante where idCategoriePlante = '" + categorieID + "'");
                    MessageBox.Show("Categoria a fost stearsa cu succes!", "Categorie stearsa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.OnLoad(e);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (UpdateCategorie ap = new UpdateCategorie())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
