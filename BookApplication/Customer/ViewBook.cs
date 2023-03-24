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
    public partial class frmViewBook : Form
    {
        public Account infoAccount { get; set; }
        BindingSource source = new BindingSource();
        BookRepo bookRepo = new BookRepo();
        CategoryRepo categoryRepo = new CategoryRepo();
        CartRepo cartRepo= new CartRepo();
        CartDetailRepo cartDetailRepo= new CartDetailRepo();
        private Book book = new Book();
        
        public frmViewBook()
        {
            InitializeComponent();

            IEnumerable<Category> listCatrgory = categoryRepo.GetListCategory();
            var listCategoryName = listCatrgory.Select(c => c.CategoryName);
            cboSearchCategory.Items.Add("Tất cả");
            cboSearchCategory.Items.AddRange(listCategoryName.ToArray());

            cboCategory.Items.AddRange(listCategoryName.ToArray());
            cboCategory.Items.Add("Khác");

            trackBarSearchPrice.Minimum = (int)bookRepo.GetMinPrice();
            trackBarSearchPrice.Maximum = (int)bookRepo.GetMaxPrice();

            dateTimeReleaseDate.Format = DateTimePickerFormat.Custom;
            dateTimeReleaseDate.CustomFormat = "dd/MM/yyyy";

            numericPrice.Maximum = decimal.MaxValue;
        }

        private void LoadDataTheFirstTime()
        {

            cboSearchCategory.SelectedIndex = 0;
            cboOrder.SelectedIndex = -1;
            txtSearchName.Clear();
            txtSearchAuthor.Clear();
            txtSearchTitle.Clear();
            trackBarSearchPrice.Value = trackBarSearchPrice.Maximum;
            lbPriceSearch.Left = trackBarSearchPrice.Left + (trackBarSearchPrice.Value * trackBarSearchPrice.Width / trackBarSearchPrice.Maximum);
            lbPriceSearch.Text = trackBarSearchPrice.Text;
            lbPriceMax.Text = bookRepo.GetMaxPrice().ToString();
            lbPriceMin.Text = bookRepo.GetMinPrice().ToString();

            txtID.Clear();
            txtName.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            cboCategory.SelectedIndex = -1;
            numericPrice.Value = 0;
            numericDiscount.Value = 0;
            txtDescription.Clear();
            dateTimeReleaseDate.Value = DateTime.Now;

            btnAddCard.Enabled = false;
            numericQuantity.Enabled = false;
            numericQuantity.Value = 1;

            source.DataSource = bookRepo.GetListBook();
            dgvBook.DataSource = source;
            dgvBook.Columns["Category"].Visible = false;
            dgvBook.Columns["CartDetails"].Visible = false;
            dgvBook.Columns["OrderDetails"].Visible = false;
            dgvBook.Columns["Reviews"].Visible = false;
        }

        private void frmViewBook_Load(object sender, EventArgs e)
        {
            LoadDataTheFirstTime();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBook.Rows[e.RowIndex];
            book = row.DataBoundItem as Book;
            txtID.Text = book.BookId.ToString();
            txtAuthor.Text = book.Author;
            txtTitle.Text = book.Title;
            txtDescription.Text = book.Describe;
            txtName.Text = book.BookName;
            IEnumerable<Category> listCatrgory = categoryRepo.GetListCategory();
            //String listCategoryName =listCatrgory.Where(c => c.CategoryId==book.CategoryId).Select(c => c.CategoryName).SingleOrDefault();
            //cboCategory.Text = listCategoryName;
            cboCategory.SelectedIndex = (int)(book.CategoryId - 1);
            dateTimeReleaseDate.Value = book.ReleaseDate.Value;
            numericDiscount.Value = (decimal)book.Discount;
            numericPrice.Value = (decimal)book.Price;
            btnAddCard.Enabled = true;
            numericQuantity.Enabled = true;
        }

        private void UpdateData()
        {
            IEnumerable<Book> listBook = bookRepo.GetListBook();

            //Order
            if (cboOrder.SelectedIndex == 0)
                listBook = listBook.OrderByDescending(b => b.ReleaseDate).ToList();
            if (cboOrder.SelectedIndex == 1)
                listBook = listBook.OrderBy(b => b.ReleaseDate).ToList();
            if (cboOrder.SelectedIndex == 2)
                listBook = listBook.OrderByDescending(b => b.RatingPoint).ToList();
            if (cboOrder.SelectedIndex == 3)
                listBook = listBook.OrderByDescending(b => b.Sold).ToList();
            if (cboOrder.SelectedIndex == 4)
                listBook = listBook.OrderBy(b => b.Price).ToList();
            if (cboOrder.SelectedIndex == 5)
                listBook = listBook.OrderByDescending(b => b.Price).ToList();
            if (cboOrder.SelectedIndex == 6)
                listBook = listBook.OrderBy(b => b.BookName).ToList();
            if (cboOrder.SelectedIndex == 7)
                listBook = listBook.OrderByDescending(b => b.BookName).ToList();

            //SEARCH

            //Search by CategoryName
            IEnumerable<Book> listBookAllCate = listBook;
            if (cboSearchCategory.SelectedIndex <= 0)
                listBook = listBookAllCate;
            else
            {
                int categoryID = cboSearchCategory.SelectedIndex;
                listBook = listBook.Where(b => b.CategoryId == categoryID);
            }

            //Search by Name
            if (txtSearchName.Text.Length > 0)
                listBook = listBook.Where(b => b.BookName.ToLower().Contains(txtSearchName.Text.ToLower()));

            //Search by Author
            if (txtSearchAuthor.Text.Length > 0)
                listBook = listBook.Where(b => b.Author.ToLower().Contains(txtSearchAuthor.Text.ToLower()));

            //Search by NXB
            if (txtSearchTitle.Text.Length > 0)
                listBook = listBook.Where(b => b.Title.ToLower().Contains(txtSearchTitle.Text.ToLower()));

            //Search by Price
            listBook = listBook.Where(b => b.Price <= trackBarSearchPrice.Value);

            source.DataSource = listBook.ToList();
            dgvBook.DataSource = source;
        }

        private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void cboSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void trackBarSearchPrice_Scroll(object sender, EventArgs e)
        {
            lbPriceSearch.Text = trackBarSearchPrice.Value.ToString();
            int trackBarThumbCenter = trackBarSearchPrice.Location.X + (int)(trackBarSearchPrice.Width * ((double)trackBarSearchPrice.Value - trackBarSearchPrice.Minimum) / (trackBarSearchPrice.Maximum - trackBarSearchPrice.Minimum));
            lbPriceSearch.Location = new Point(trackBarSearchPrice.Location.X + trackBarSearchPrice.Value * (trackBarSearchPrice.Width) / (trackBarSearchPrice.Maximum - trackBarSearchPrice.Minimum) - lbPriceSearch.Width / 2, trackBarSearchPrice.Location.Y - lbPriceSearch.Height - 5);
            UpdateData();
        }

        private void txtSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataTheFirstTime();
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thêm sản phẩm vào giỏ hàng?", "Corfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                int quantity = (int)numericQuantity.Value;
                CartDetail cartDetail = new CartDetail()
                {
                    Quantity = quantity,
                    BookId = book.BookId
                };

                IEnumerable<Cart> listCart = cartRepo.GetListCart();
                //Cart cart = new Cart();
                Cart cart = listCart.Where(c => c.AccountId == infoAccount.AccountId).SingleOrDefault();
                if (cart != null)
                {
                    IEnumerable<CartDetail> cartDetails = cartDetailRepo.GetListCartDetails();
                    foreach (var item in cartDetails)
                    {
                        if(cart.CartId==item.CartId && item.BookId==book.BookId)
                        {
                            cartDetail.Quantity = cartDetail.Quantity + item.Quantity;
                            cart.TotalMoney = cart.TotalMoney + (decimal)((quantity * book.Price * (decimal)(100.0 - book.Discount)) / (decimal)100.0);
                            cartRepo.UpdateCart(cart);
                            cartDetail.CartId = item.CartId;
                            cartDetailRepo.UpdateCartDetail(cartDetail);
                            MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng!!!");
                            return;
                        }
                    }
                    cartDetail.CartId = cart.CartId;
                    cart.TotalMoney = cart.TotalMoney + (decimal)((quantity * book.Price * (decimal)(100.0 - book.Discount)) / (decimal)100.0);
                    cartRepo.UpdateCart(cart);
                    cartDetailRepo.AddCartDetail(cartDetail);
                }
                else
                {
                    Cart cart1 = new Cart();
                    cart1.AccountId = infoAccount.AccountId;
                    cart1.TotalMoney = (decimal)((quantity * book.Price * (decimal)(100.0 - book.Discount)) / (decimal)100.0);
                    cartRepo.AddCart(cart1);
                    listCart = cartRepo.GetListCart();
                    cartDetail.CartId = listCart.Max(c => c.CartId);
                    cartDetailRepo.AddCartDetail(cartDetail);
                }
                MessageBox.Show("Sản phẩm đã được thêm vào giỏ hàng!!!");
            }
            LoadDataTheFirstTime();
        }
    }
}
