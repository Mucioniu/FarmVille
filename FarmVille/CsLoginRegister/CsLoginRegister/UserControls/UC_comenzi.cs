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
    public partial class UC_comenzi : UserControl
    {
        DbConnector db;
        public UC_comenzi()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_comenzi_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * FROM Comenzi ", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (adaugaComanda ap = new adaugaComanda())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }

        string comandaID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                comandaID = item.Cells[0].Value.ToString();
            }
        }

        private void stergeDaunator_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Sunteti sigur ca doriti sa stergeti comanda selectata?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                if (!comandaID.Equals(string.Empty))
                {
                    db.performCRUD("delete from Comenzi where [idComanda] = '" + comandaID + "'");
                    MessageBox.Show("Comanda a fost stearsa cu succes!", "Comanda stearsa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.OnLoad(e);
                }
            }
        }

        private void updatePlante_Click(object sender, EventArgs e)
        {
            using (updateComanda ap = new updateComanda())
            {
                ap.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
