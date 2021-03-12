using CsLoginRegister.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CsLoginRegister
{
    public partial class MainForm : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public MainForm()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void informatiiButton_Click(object sender, EventArgs e)
        {
            UC_Dashboard ud = new UC_Dashboard();
            addControls(ud);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void addControls(UserControl uc)
        {
            panelControls.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelControls.Controls.Add(uc);
            uc.BringToFront();
        }
        private void planteButton_Click(object sender, EventArgs e)
        {
            UC_plante up = new UC_plante();
            addControls(up);
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comenziButton_Click(object sender, EventArgs e)
        {
            UC_comenzi up = new UC_comenzi();
            addControls(up);
        }

        private void daunatoriButton_Click(object sender, EventArgs e)
        {
            UC_daunatori up = new UC_daunatori();
            addControls(up);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
