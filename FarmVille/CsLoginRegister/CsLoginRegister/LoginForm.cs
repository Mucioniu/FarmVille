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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Select();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openRegisterFromLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(usernameTextBox.Text) &&
                !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                string mySQL = string.Empty;
                string mySQL1 = string.Empty;

                mySQL += "SELECT * FROM Utilizatori WHERE NumeUtilizator = '" + usernameTextBox.Text + "' " + "AND Parola = '" + passwordTextBox.Text + "'";
                mySQL1 += "SELECT Nume FROM Utilizatori WHERE NumeUtilizator = '" + usernameTextBox.Text + "' ";

                DataTable userData = ServerConnection.executeSQL(mySQL);
                DataTable userData1 = ServerConnection.executeSQL(mySQL1);

                string res = string.Join(Environment.NewLine, userData1.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));

                if (userData.Rows.Count > 0)
                {

                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    showPasswordCheckBox.Checked = false;
                    
                    this.Hide();

                    MainForm formMain = new MainForm();
                    MessageBox.Show("Bine ati venit domnule/doamna " + res,"Main Form" ,MessageBoxButtons.OK);
                    formMain.ShowDialog();
                    formMain = null;                   
      
                }

                else
                {
                    MessageBox.Show("Numele de ultilizator sau parola nu sunt corecte. Te rog mai incearca!","Login Form" , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usernameTextBox.Focus();
                    usernameTextBox.SelectAll();   
                }


            }

            else
            {
                MessageBox.Show("Va rugam sa introuceti numele de utilizator si parola", "Login From",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usernameTextBox.Select();
            }
        }
    }
}
