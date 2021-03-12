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
    public partial class updateComanda : Form
    {
        DbConnector db;
        public updateComanda()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void updateComanda_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from Comenzi", dataGridView1);
        }

        public int ComandaID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ComandaID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            idFurnizor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            idUtilizator.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sosire.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            stare.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ComandaID > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa modificati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string mySQL = string.Empty;

                    mySQL += "UPDATE Comenzi SET [idFurnizor]='" + idFurnizor.Text + "', [idUtilizator]='" + idUtilizator.Text + "', [Sosire]='" + sosire.Text + "', [Stare]='" + stare.Text + "' WHERE [idComanda]='" + ComandaID + "'";

                    CSLoginRegisterForm.Connection.ServerConnection.executeSQL(mySQL);
                    MessageBox.Show("Comanda modificata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
