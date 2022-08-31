using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GameClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            bool result = new AccountBUS().CheckAccount(account);
            if (result)
            {
                new MainForm().Show();
                this.Hide();
            }
            else { MessageBox.Show("SORRY BABY!"); }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            bool result = new AccountBUS().AddNew(newAccount);
            if (result) MessageBox.Show("OK BABY!");
            else MessageBox.Show("SORRY BABY!");
        }
        bool isChecked = false;
        private void btnShow_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = btnShow.Checked;
            if (btnShow.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (btnShow.Checked && !isChecked)
                btnShow.Checked = false;
            else
            {
                btnShow.Checked = true;
                isChecked = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
