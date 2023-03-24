using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }else
                txtPass.UseSystemPasswordChar = true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new AccountRepo().CheckAuthentication(txtUsername.Text, txtPass.Text);
            if (account != null)
            {
                if(account.RoleId==1)
                {
                    frmAdmin frmAdmin = new frmAdmin()
                    {
                        infoAccount = account
                    };
                    this.Hide();
                    frmAdmin.ShowDialog();
                }
                else
                {
                    frmCustomer frmCustomer = new frmCustomer()
                    {
                        infoAccount = account
                    };
                    this.Hide();
                    frmCustomer.ShowDialog();
                }
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. Vui lòng thử lại!!!!");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            this.Hide();
            frmRegister.ShowDialog();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            frmRePass frmRePass = new frmRePass();
            this.Hide();
            frmRePass.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
