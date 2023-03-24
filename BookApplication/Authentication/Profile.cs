using BookLibrary.DataAccess;
using BookLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication.Admin
{
    public partial class frmProfile : Form
    {
        public Account infoAccount { get; set; }
        private AccountRepo accountRepo= new AccountRepo();
        public frmProfile()
        {
            InitializeComponent();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtID.Text = infoAccount.AccountId.ToString();
            txtAddress.Text = infoAccount.Address;
            txtEmail.Text = infoAccount.Email;
            txtName.Text = infoAccount.Name;
            txtPhoneNumber.Text = infoAccount.Phone;
            txtUserName.Text = infoAccount.Username;
            txtPass.UseSystemPasswordChar= true;
            txtPass.Text = infoAccount.Password;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thông tin cá nhân?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (Account account in accountRepo.GetListAccount())
                {
                    if(account.AccountId != infoAccount.AccountId && txtUserName.Text.Equals(account.Username)){ 
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        frmProfile_Load(sender, e);
                        return;
                    }

                }
                infoAccount.Address = txtAddress.Text;
                infoAccount.Email = txtEmail.Text;
                infoAccount.Name = txtName.Text;
                infoAccount.Phone = txtPhoneNumber.Text;
                infoAccount.Username = txtUserName.Text;
                infoAccount.Password = txtPass.Text;
                accountRepo.UpdateAccount(infoAccount);
                MessageBox.Show("Cập nhật thành công");
                frmProfile_Load(sender, e);
            }
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }else
                txtPass.UseSystemPasswordChar = true;
        }
    }
}
