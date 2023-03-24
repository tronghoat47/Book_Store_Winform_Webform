using BookLibrary.DataAccess;
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
    public partial class frmAdmin : Form
    {

        private Button currentButton;
        private Form activeForm;

        private void ActiveButton(object btnSender)
        {
            if(btnSender != null)
            {
                DisableButton();
                if(currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.BackColor= Color.WhiteSmoke;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control preBtn in panelMenuAdmin.Controls)
            {
                if (preBtn.GetType() == typeof(Button))
                {
                    preBtn.BackColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form chilForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm= chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle= FormBorderStyle.None;
            chilForm.Dock=DockStyle.Fill;
            this.panelAdmin.Controls.Add(chilForm);
            this.panelAdmin.Tag= chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        public Account infoAccount { get; set; }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmManagerBook() { infoAccount = infoAccount}, sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmManagerOrder() { infoAccount = infoAccount }, sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmReporting() { infoAccount = infoAccount }, sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin.frmProfile() { infoAccount = infoAccount }, sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new frmLogin().ShowDialog();
            }
        }
    }
}
