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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookApplication.Customer
{
    public partial class frmViewCart : Form
    {
        public Account infoAccount { get; set; }
        BindingSource source = new BindingSource();
        BookRepo bookRepo = new BookRepo();
        CategoryRepo categoryRepo = new CategoryRepo();
        CartRepo cartRepo = new CartRepo();
        CartDetailRepo cartDetailRepo = new CartDetailRepo();
        private CartDetail cartDetailGeneral = new CartDetail();
        private OrderRepo orderRepo = new OrderRepo();
        private OrderDetailRepo orderDetailRepo = new OrderDetailRepo();

        public double totalMoneyOrder;

        private Book book = null;
        private int oldQuantity = 0;
        
        public frmViewCart()
        {
            InitializeComponent();
            
        }

        private Cart getCartCurrnentOfAccount(int accountId)
        {
            Cart cart = cartRepo.GetListCart().Where(c => c.AccountId == accountId).SingleOrDefault();
            return cart;
        }

        private void ViewCart_Load(object sender, EventArgs e)
        {
            if (getCartCurrnentOfAccount(infoAccount.AccountId) == null)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng!!! Tiếp tục mua sắm!");
                this.Hide();
                //frmCustomer frmCustomer = new frmCustomer()
                //{
                //    infoAccount = infoAccount
                //};
                //frmCustomer.ShowDialog();
                return;
            }
            source.DataSource = cartDetailRepo.GetListCartDetails().Where(c => c.CartId==getCartCurrnentOfAccount(infoAccount.AccountId).CartId);
            dgvListCartDetail.DataSource = source;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            dgvListCartDetail.Columns["CartId"].Visible = false;
            dgvListCartDetail.Columns["Book"].Visible = false;
            dgvListCartDetail.Columns["Cart"].Visible = false;
            totalMoneyOrder = (double)getCartCurrnentOfAccount(infoAccount.AccountId).TotalMoney;
            lbTotalMoney.Text = totalMoneyOrder.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvListCartDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            DataGridViewRow row = dgvListCartDetail.Rows[e.RowIndex];
            cartDetailGeneral = row.DataBoundItem as CartDetail;
            book = bookRepo.getBookByBookID(cartDetailGeneral.BookId);
            txtName.Text = book.BookName;
            numericDiscount.Value = (decimal)book.Discount;
            numericPrice.Value = (decimal)book.Price;
            numericQuantity.Value = (decimal)cartDetailGeneral.Quantity;
            lbTotalMoney.Text = getCartCurrnentOfAccount(infoAccount.AccountId).TotalMoney.ToString();
            txtTotalMoney.Text = (cartDetailGeneral.Quantity * (decimal)book.Price * (decimal)(100.0 - book.Discount) / (decimal)100.0).ToString();
            oldQuantity = (int)numericQuantity.Value;

        }

        
        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            int tempQuantity = (int)(numericQuantity.Value - oldQuantity);
            double totalMoneyOld = ((double)(cartDetailGeneral.Quantity * (decimal)book.Price * (decimal)(100.0 - book.Discount) / (decimal)100.0));
            double totalMoneyNew = ((double)(tempQuantity * (decimal)book.Price * (decimal)(100.0 - book.Discount) / (decimal)100.0)) + totalMoneyOld;
            txtTotalMoney.Text = totalMoneyNew.ToString();

            Cart cart = getCartCurrnentOfAccount(infoAccount.AccountId);
            if (cartDetailGeneral.Quantity - numericQuantity.Value != 0  
                || cartDetailRepo.GetListCartDetails().Where(c => c.CartId == cart.CartId).Count() == 1)
            {
                totalMoneyOrder = ((double)(getCartCurrnentOfAccount(infoAccount.AccountId).TotalMoney - (decimal)totalMoneyOld + (decimal)totalMoneyNew));
                lbTotalMoney.Text = totalMoneyOrder.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có sửa thông tin sản phẩm trong giỏ hàng?", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                if (cartDetailGeneral.Quantity - numericQuantity.Value != 0)
                {
                    Cart cart = getCartCurrnentOfAccount(infoAccount.AccountId);
                    cart.TotalMoney = (decimal?)totalMoneyOrder;
                    cartRepo.UpdateCart(cart);
                    cartDetailGeneral.Quantity = (int?)numericQuantity.Value;
                    cartDetailRepo.UpdateCartDetail(cartDetailGeneral);
                    MessageBox.Show("Cập nhật thành công");
                    ViewCart_Load(sender, e);
                }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi giỏ hàng?", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Cart cart = getCartCurrnentOfAccount(infoAccount.AccountId);
                if (cartDetailRepo.GetListCartDetails().Where(c => c.CartId==cart.CartId).Count() == 1)
                {
                    cartRepo.RemoveCart(cart);
                }else
                {
                    cart.TotalMoney = cart.TotalMoney - book.Price * (decimal) (100 - book.Discount) * cartDetailGeneral.Quantity /100 ;
                    cartRepo.UpdateCart(cart);
                    cartDetailRepo.RemoveCartDetail(cartDetailGeneral);
                }
                MessageBox.Show("Đã xóa sản phẩm khỏi giỏ hàng");
                ViewCart_Load(sender, e);
            }
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Cart cart = getCartCurrnentOfAccount(infoAccount.AccountId);
            List<CartDetail> cartDetails = cartDetailRepo.GetListCartDetails().Where(c => c.CartId == cart.CartId).ToList();

            DialogResult result = MessageBox.Show("Bạn có muốn đặt đơn hàng này??", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Order order = new Order
                {
                    AccountId = infoAccount.AccountId,
                    OrderDate= DateTime.Now,
                    Note = Microsoft.VisualBasic.Interaction.InputBox("Cho chúng tôi biết thêm thông tin bạn cần về đơn hàng nếu có. (thời gian nhận hàng, số điện thoại nhận hàng(nếu thay đổi))", "Ghi chú"),
                    ShippingAddress = infoAccount.Address,
                    Status = "Chờ xác nhận",
                    TotalMoney = (decimal?)totalMoneyOrder
                };
                orderRepo.AddOrder(order);

                int orderDetailID = orderRepo.GetListOrder().Max(o => o.OrderId);
                List<OrderDetail> orderDetails = new List<OrderDetail>();
                foreach (CartDetail cartDetail in cartDetails)
                {
                    orderDetails.Add(new OrderDetail
                    {
                        OrderId = orderDetailID,
                        BookId = cartDetail.BookId,
                        Quantity = (int)cartDetail.Quantity
                    });
                    Book book1 = bookRepo.getBookByBookID(cartDetail.BookId);
                    if (book1.Sold == null)
                        book1.Sold = 0;
                    book1.Sold = book1.Sold + cartDetail.Quantity;
                    bookRepo.UpdateBook(book1);
                }
                orderDetailRepo.AddOrderDetail(orderDetails);

                cartRepo.RemoveCart(cart);
                MessageBox.Show("Cảm ơn bạn đã mua hàng!!! Tiếp tục mua sắm");
                this.Hide();
            }
        }
    }
}
