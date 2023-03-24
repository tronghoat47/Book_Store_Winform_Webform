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
using System.Xml.Linq;

namespace BookApplication.Admin
{
    public partial class frmManagerOrder : Form
    {
        public Account infoAccount { get; set; }
        BindingSource sourceOrder = new BindingSource();
        BindingSource sourceOrderDetail = new BindingSource();
        BindingSource sourceReview =new BindingSource();
        BookRepo bookRepo = new BookRepo();
        private OrderRepo orderRepo = new OrderRepo();
        private OrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        private ReviewRepo reviewRepo = new ReviewRepo();

        private Book book = null;
        private Order orderGeneral = null;
        private OrderDetail orderDetailGeneral = null;
        public frmManagerOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmManagerOrder_Load(object sender, EventArgs e)
        {
            if (orderRepo.GetListOrder().Count() == 0)
            {
                MessageBox.Show("Không ghi nhận lịch sử mua hàng nào!!!");
                this.Hide();
                return;
            }
            sourceOrder.DataSource = orderRepo.GetListOrder().OrderBy(o => o.Status);
            dgvOrder.DataSource = sourceOrder;
            //dgvOrder.Columns["AccountId"].Visible = false;
            dgvOrder.Columns["Account"].Visible = false;
            dgvOrder.Columns["OrderDetails"].Visible = false;
            //dgvOrder.Columns["Status"].Visible = false;
            dgvOrder.Columns["Note"].Visible = false;
            dgvOrder.Columns["ShippingAddress"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text != orderGeneral.Status)
            {
                orderGeneral.Status = comboBox1.Text;
                orderRepo.UpdateOrder(orderGeneral);
                MessageBox.Show("Cập nhật thành công!!");
                frmManagerOrder_Load(sender, e);
            }
            
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
            orderGeneral = row.DataBoundItem as Order;
            sourceOrderDetail.DataSource = orderDetailRepo.GetListOrderDetail().Where(o => o.OrderId == orderGeneral.OrderId);
            dgvOrderDetail.DataSource = sourceOrderDetail;
            lbIdOrder.Text = orderGeneral.OrderId.ToString();
            dgvOrderDetail.Columns["OrderId"].Visible = false;
            dgvOrderDetail.Columns["Order"].Visible = false;
            dgvOrderDetail.Columns["Book"].Visible = false;
            comboBox1.Text = orderGeneral.Status;
            if(orderGeneral.Status.Equals("Giao hàng thành công"))
                comboBox1.Enabled= false;
            else
                comboBox1.Enabled= true;
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvOrderDetail.Rows[e.RowIndex];
            orderDetailGeneral = row.DataBoundItem as OrderDetail;
            book = bookRepo.getBookByBookID(orderDetailGeneral.BookId);
            txtName.Text = book.BookName;
            numericDiscount.Value = (decimal)book.Discount;
            numericPrice.Value = (decimal)book.Price;
            numericQuantity.Value = (decimal)orderDetailGeneral.Quantity;
            txtTotalMoney.Text = (orderDetailGeneral.Quantity * (decimal)book.Price * (decimal)(100.0 - book.Discount) / (decimal)100.0).ToString();

            sourceReview.DataSource = reviewRepo.GetListReview().Where(r => r.BookId== orderDetailGeneral.BookId).ToList();
            dgvRating.DataSource = sourceReview;
            dgvRating.Columns["BookId"].Visible = false;
            dgvRating.Columns["Book"].Visible = false;
        }
    }
}
