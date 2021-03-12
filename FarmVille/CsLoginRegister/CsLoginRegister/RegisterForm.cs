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

namespace CsLoginRegister
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearControls();
            firstNameTextBox.Select();
        }

        private void clearControls()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            loadUserData();
            firstNameTextBox.Select();
        }

        private void loadUserData()
        {
            DataTable userData = ServerConnection.executeSQL("SELECT (Nume + ' ' + Prenume) AS NumeComplet, NumeUtilizator FROM Utilizatori");
            dataGridView1.DataSource = userData;
            dataGridView1.Columns[0].HeaderText = "Nume Complet";
            dataGridView1.Columns[1].HeaderText = "Nume Utilizator";
            dataGridView1.Columns[0].Width = 234;
            dataGridView1.Columns[1].Width = 234;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Salveaza datele";

            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                MessageBox.Show("Va rugam sa va treceti prenumele.", caption, btn, ico);
                firstNameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Va rugam sa va treceti numele.", caption, btn, ico);
                lastNameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(adresaTextBox.Text))
            {
                MessageBox.Show("Va rugam sa va treceti adresa completa.", caption, btn, ico);
                adresaTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                MessageBox.Show("Va rugam sa va treceti numele de utilizator.", caption, btn, ico);
                usernameTextBox.Select();
                return;
                
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Va rugam sa va treceti parola.", caption, btn, ico);
                passwordTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(confirmPasswordTextBox.Text))
            {
                MessageBox.Show("Va rugam sa treceti confirmarea parolei.", caption, btn, ico);
                confirmPasswordTextBox.Select();
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Parola nu este identica cu cea trecuta mai devreme.", caption, btn, ico);
                confirmPasswordTextBox.SelectAll();
                return;
            }


            string yourSQL = "SELECT NumeUtilizator FROM Utilizatori WHERE NumeUtilizator = '" + usernameTextBox.Text + "'";
            DataTable checkDuplicates = CSLoginRegisterForm.Connection.ServerConnection.executeSQL(yourSQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("Numele de utilizator exista deja. Va ruam sa alegeti altul.",
                    "Registration Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernameTextBox.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Doriti sa salvati noul cont?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO Utilizatori (Prenume, Nume, AdresaCompleta, Email, NumeUtilizator, Parola) ";
                mySQL += "VALUES ('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + adresaTextBox.Text + "','" + emailTextBox.Text + "',";
                mySQL += "'" + usernameTextBox.Text + "','" + passwordTextBox.Text + "')";

                CSLoginRegisterForm.Connection.ServerConnection.executeSQL(mySQL);

                MessageBox.Show("Contul a fost creeat cu succes.",
                                "Save Data", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                loadUserData();
                clearControls();

            }

        }

        private void adresaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
