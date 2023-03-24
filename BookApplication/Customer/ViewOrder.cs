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

namespace BookApplication.Customer
{
    public partial class frmViewOrder : Form
    {
        public Account infoAccount { get; set; }
        BindingSource sourceOrder = new BindingSource();
        BindingSource sourceOrderDetail = new BindingSource();
        BookRepo bookRepo = new BookRepo();
        private OrderRepo orderRepo = new OrderRepo();
        private OrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        private ReviewRepo reviewRepo = new ReviewRepo();

        private Book book = null;
        private Order orderGeneral = null;
        private OrderDetail orderDetailGeneral = null;
        public frmViewOrder()
        {
            InitializeComponent();
        }

        private void frmViewOrder_Load(object sender, EventArgs e)
        {
            if (orderRepo.GetListOrder().Where(o => o.AccountId==infoAccount.AccountId).Count() == 0)
            {
                MessageBox.Show("Không ghi nhận lịch sử mua hàng nào!!! Tiếp tục mua sắm!");
                this.Hide();
                return;
            }
            sourceOrder.DataSource = orderRepo.GetListOrder().Where(o => o.AccountId == infoAccount.AccountId);
            dgvOrder.DataSource = sourceOrder;
            dgvOrder.Columns["AccountId"].Visible = false;
            dgvOrder.Columns["Account"].Visible = false;
            dgvOrder.Columns["OrderDetails"].Visible = false;
            dgvOrder.Columns["OrderId"].Visible = false;
            dgvOrder.Columns["Note"].Visible = false;
            dgvOrder.Columns["ShippingAddress"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
            orderGeneral = row.DataBoundItem as Order;
            sourceOrderDetail.DataSource = orderDetailRepo.GetListOrderDetail().Where(o => o.OrderId==orderGeneral.OrderId);
            dgvOrderDetail.DataSource= sourceOrderDetail;
            lbIdOrder.Text = orderGeneral.OrderId.ToString();
            dgvOrderDetail.Columns["OrderId"].Visible = false;
            dgvOrderDetail.Columns["Order"].Visible = false;
            dgvOrderDetail.Columns["Book"].Visible = false;
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numericRatingPoint.Value = 1;
            txtComment.Clear();
            DataGridViewRow row = dgvOrderDetail.Rows[e.RowIndex];
            orderDetailGeneral = row.DataBoundItem as OrderDetail;
            book = bookRepo.getBookByBookID(orderDetailGeneral.BookId);
            txtName.Text = book.BookName;
            numericDiscount.Value = (decimal)book.Discount;
            numericPrice.Value = (decimal)book.Price;
            numericQuantity.Value = (decimal)orderDetailGeneral.Quantity;
            txtTotalMoney.Text = (orderDetailGeneral.Quantity * (decimal)book.Price * (decimal)(100.0 - book.Discount) / (decimal)100.0).ToString();

            if (orderGeneral.Status.Equals("Giao hàng thành công"))
            {
                numericRatingPoint.Enabled = true;
                txtComment.Enabled = true;
                Review review = reviewRepo.GetReviewByBookIdAndAccountId(book.BookId, infoAccount.AccountId);
                if (review == null)
                {
                    btnRating.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    
                }
                else
                {
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnRating.Enabled = false;
                    numericRatingPoint.Value = (decimal)review.Rating;
                    txtComment.Text = review.Comment;
                }
            }else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnRating.Enabled = false;
                numericRatingPoint.Enabled = false;
                txtComment.Enabled = false;
            }
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đánh giá sản phẩm này?", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Review review = new Review
                {
                    BookId = book.BookId,
                    AccountId = infoAccount.AccountId,
                    Rating = (double?)numericRatingPoint.Value,
                    Comment = txtComment.Text,
                };
                reviewRepo.AddReview(review);

                book.RatingPoint = reviewRepo.GetListReview().Where(r => r.BookId == book.BookId).Average(x => x.Rating);
                bookRepo.UpdateBook(book);
                MessageBox.Show("Đánh giá đã được thêm");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn chỉnh sửa đánh giá này?", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Review review = new Review
                {
                    BookId = book.BookId,
                    AccountId = infoAccount.AccountId,
                    Rating = (double?)numericRatingPoint.Value,
                    Comment = txtComment.Text,
                };
                reviewRepo.UpdateReview(review);

                book.RatingPoint = reviewRepo.GetListReview().Where(r => r.BookId == book.BookId).Average(x => x.Rating);
                bookRepo.UpdateBook(book);
                MessageBox.Show("Chỉnh sửa thành công");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa đánh giá này?", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Review review = new Review
                {
                    BookId = book.BookId,
                    AccountId = infoAccount.AccountId,
                };
                reviewRepo.DeleteReview(review);

                book.RatingPoint = reviewRepo.GetListReview().Where(r => r.BookId == book.BookId).Average(x => x.Rating);
                bookRepo.UpdateBook(book);
                MessageBox.Show("Xóa thành công");
            }
        }
    }
}
