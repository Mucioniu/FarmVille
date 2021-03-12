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
    public partial class updateDaunator : Form
    {
        DbConnector db;
        public updateDaunator()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateDaunator_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from Daunatori", dataGridView1);
        }

        public int DaunatorID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DaunatorID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            categorieDaunator.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            denStiintifica.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            denPopulara.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            planteAtacate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            culoare.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            marime.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (DaunatorID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa modificati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string mySQL = string.Empty;

                    mySQL += "UPDATE Daunatori SET idCategorieDaunatori='" + categorieDaunator.Text + "', [DenumireStiintifica]='" + denStiintifica.Text + "', DenumirePopulara='" + denPopulara.Text + "', [Pagubele la nivelul plantei]='" + planteAtacate.Text + "', [Culoare]='" + culoare.Text + "', [Marime]='" + marime.Text + "' WHERE [idDaunator]='" + DaunatorID + "'";

                    CSLoginRegisterForm.Connection.ServerConnection.executeSQL(mySQL);
                    MessageBox.Show("Daunator modificat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
