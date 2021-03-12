using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSLoginRegisterForm.Connection;
using SLRDbConnector;

namespace CsLoginRegister.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        DbConnector db;
        public UC_Dashboard()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT Top 1 P1.DenumirePopulara, P1.PerioadaPlantare, CP.DenumireUzuala FROM PLante P1 INNER JOIN CategoriePlante CP ON P1.idCategoriePlante = CP.idCategoriePlante Order BY MONTH(P1.PerioadaPlantare) DESC; ", dataGridView1);  
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT Distinct CD.DenumireStiintifica, CD.DenumireUzuala FROM CategoriePlante CD INNER JOIN Plante P ON CD.idCategoriePlante = P.idCategoriePlante Where MONTH(P.PerioadaRecoltare) BETWEEN 4 AND 8; ", dataGridView3);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT P1.DenumireStiintifica,P1.DenumirePopulara FROM Plante P1 INNER JOIN CategoriePlante CD ON CD.idCategoriePlante = P1.idCategoriePlante WHERE CD.CalitateSol > 2.5", dataGridView2);
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT P.DenumirePopulara, D.DenumirePopulara FROM Plante P INNER JOIN PlanteDaunatori PD ON P.idPlante = PD.idPlante INNER JOIN Daunatori D ON PD.idDaunatori = D.idDaunator", dataGridView6);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT TOP 1 P.DenumirePopulara, P.DenumireStiintifica FROM Plante P ORDER BY(Select COUNT(*) FROM PlanteDaunatori PD WHERE PD.idPlante = P.idPlante) DESC; ", dataGridView7);
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT CD.DenumireStiintifica, CD.DenumireUzuala FROM CategoriePlante CD WHERE CD.idCategoriePlante != ALL(SELECT P.idCategoriePlante FROM Plante P); ", dataGridView9);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT DISTINCT P.DenumirePopulara FROM PLante P INNER JOIN PlanteDaunatori PD ON P.idPlante = PD.idPlante WHERE PD.idDaunatori IN(SELECT D.idDaunator FROM Daunatori D WHERE D.[Pagubele la nivelul plantei] = 'Floarea'); ", dataGridView10);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT DISTINCT P.DenumirePopulara FROM PLante P INNER JOIN PlanteDaunatori PD ON P.idPlante = PD.idPlante WHERE PD.idDaunatori IN(SELECT D.idDaunator FROM Daunatori D WHERE D.[Pagubele la nivelul plantei] = 'Frunzele'); ", dataGridView8);
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT COUNT(D.idCategorieDaunatori) FROM CategorieDaunatori CD INNER JOIN Daunatori D ON D.idCategorieDaunatori = CD.idCategorieDaunatori WHERE D.idCategorieDaunatori = 2", dataGridView4);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            db.fillDataGridView("SELECT COUNT(D.idCategorieDaunatori) FROM CategorieDaunatori CD INNER JOIN Daunatori D ON D.idCategorieDaunatori = CD.idCategorieDaunatori WHERE D.idCategorieDaunatori = 1", dataGridView5);
        }
    }
}
