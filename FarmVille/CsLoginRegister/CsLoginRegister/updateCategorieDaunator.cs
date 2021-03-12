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
    public partial class updateCategorieDaunator : Form
    {
        DbConnector db;
        public updateCategorieDaunator()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void updateCategorieDaunator_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from CategorieDaunatori", dataGridView1);
        }

        public int CategorieID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategorieID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            denStiintifica.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            denPopulara.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ordin.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CategorieID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa modificati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string mySQL = string.Empty;

                    mySQL += "UPDATE CategorieDaunatori SET [Denumire Stiintifica]='" + denStiintifica.Text + "', [Denumire uzuala]='" + denPopulara.Text + "', [Ordin]='" + ordin.Text + "' WHERE [idCategorieDaunatori]='" + CategorieID + "'";

                    CSLoginRegisterForm.Connection.ServerConnection.executeSQL(mySQL);
                    MessageBox.Show("Daunator modificat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
