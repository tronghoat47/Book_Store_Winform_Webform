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
    public partial class frmRegister : Form
    {

        AccountRepo accountRepo = new AccountRepo();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Account account = accountRepo.CheckAuthentication(txtUsername.Text);
            if (account == null)
            {
                if (txtPass.Text != txtRePass.Text)
                    MessageBox.Show("Mật khẩu phải trùng khớp. Vui lòng thử lại!!!!");
                else
                {
                    Account a = new Account()
                    {
                        Username = txtUsername.Text,
                        Password = txtPass.Text,
                        RoleId = 2
                    };
                    accountRepo.AddAccount(a);
                    MessageBox.Show("Đăng ký thành công. Đăng nhập để tiếp tục");
                    this.Hide();
                    new frmLogin().ShowDialog();
                }
            }
            else
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác!!!!");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().ShowDialog();
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
