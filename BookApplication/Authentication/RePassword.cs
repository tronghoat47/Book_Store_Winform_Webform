using BookLibrary.DataAccess;
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
    public partial class frmRePass : Form
    {
        private AccountRepo accountRepo = new AccountRepo();
        public frmRePass()
        {
            InitializeComponent();
        }

        private void frmRePass_Load(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            txtRePass.UseSystemPasswordChar = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtRePass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                txtRePass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRegister().ShowDialog();
        }

        private void btnRePassword_Click(object sender, EventArgs e)
        {
            Account account = accountRepo.CheckAuthentication(txtUsername.Text);
            if (account != null)
            {
                if (txtPass.Text != txtRePass.Text)
                    MessageBox.Show("Mật khẩu phải trùng khớp. Vui lòng thử lại!!!!");
                else
                {
                    account.Password= txtPass.Text;
                    accountRepo.UpdateAccount(account);
                    MessageBox.Show("Mật khẩu đã được cập nhật. Đăng nhập để tiếp tục");
                    this.Hide();
                    new frmLogin().ShowDialog();
                }
            }
            else
                MessageBox.Show("Tên đăng nhập không tồn tại. Vui lòng thử lại!!!!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
