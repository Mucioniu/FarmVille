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
    public partial class UpdatePlante : Form
    {
        DbConnector db;
        public UpdatePlante()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UpdatePlante_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select * from Plante", dataGridView1);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(PlanteID>0)
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa modificati?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string mySQL = string.Empty;

                    mySQL += "UPDATE Plante SET idCategoriePlante='" + categoriePlantetext.Text + "', DenumireStiintifica='" + denStiintifica.Text + "', DenumirePopulara='" + denPopulara.Text + "', PerioadaPlantare='" + perPlantare.Text + "', PerioadaRecoltare='" + perPlantare.Text + "' WHERE idPlante='" + PlanteID + "'";

                    CSLoginRegisterForm.Connection.ServerConnection.executeSQL(mySQL);
                    MessageBox.Show("Planta modificata cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public int PlanteID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PlanteID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            categoriePlantetext.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            denStiintifica.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            denPopulara.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            perPlantare.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            perRecoltare.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
