using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookApplication.Admin
{
    public partial class frmManagerBook : Form
    {

        public Account infoAccount { get; set; }
        BindingSource source = new BindingSource();
        BookRepo bookRepo = new BookRepo();
        CategoryRepo categoryRepo = new CategoryRepo();
        
        public frmManagerBook()
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

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            source.DataSource = bookRepo.GetListBook();
            dgvBook.DataSource = source;
            dgvBook.Columns["Category"].Visible = false;
            dgvBook.Columns["CartDetails"].Visible = false;
            dgvBook.Columns["OrderDetails"].Visible = false;
            dgvBook.Columns["Reviews"].Visible = false;
        }

        private void frmManagerBook_Load(object sender, EventArgs e)
        {
            LoadDataTheFirstTime();
        }

        private void lbPriceSearch_Click(object sender, EventArgs e)
        {
            lbPriceSearch.Location = new Point(trackBarSearchPrice.Location.X + trackBarSearchPrice.Width / 2 - lbPriceSearch.Width / 2, trackBarSearchPrice.Location.Y - lbPriceSearch.Height - 5);
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
            Book book = row.DataBoundItem as Book;
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
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
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
            if(txtSearchName.Text.Length > 0)
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

        private void txtSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataTheFirstTime();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAuthor.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtDescription.Text)
                || cboCategory.SelectedIndex < 0 || numericPrice.Value <= 0)
                MessageBox.Show("Điền đầy đủ thông tin sản phẩm trước khi thêm!!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Book newBook = new Book
                {
                    BookName = txtName.Text,
                    CategoryId = cboCategory.SelectedIndex + 1,
                    Price = numericPrice.Value,
                    ReleaseDate = dateTimeReleaseDate.Value,
                    Author = txtAuthor.Text,
                    Title = txtTitle.Text,
                    Describe = txtDescription.Text,
                    Discount = (double?)numericDiscount.Value
                };
                bookRepo.AddBook(newBook);
                MessageBox.Show("Thêm sản phẩm thành công");
                LoadDataTheFirstTime();
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem!=null && cboCategory.SelectedItem.Equals("Khác"))
            {
                string newCategory = Microsoft.VisualBasic.Interaction.InputBox("Enter new category:", "New Category");
                if (!string.IsNullOrEmpty(newCategory))
                {
                    cboCategory.Items.Insert(cboCategory.Items.Count - 1, newCategory);
                    cboCategory.SelectedItem = newCategory;
                    categoryRepo.AddCategory(new Category() { CategoryName= newCategory });
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = bookRepo.getBookByBookID(int.Parse(txtID.Text));
            book.BookName = txtName.Text;
            book.CategoryId = cboCategory.SelectedIndex + 1;
            book.Author = txtAuthor.Text;
            book.Title = txtTitle.Text;
            book.Price = numericPrice.Value;
            book.Discount = (double?)numericDiscount.Value;
            book.ReleaseDate = dateTimeReleaseDate.Value;
            book.Describe = txtDescription.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật sản phẩm có ID: " + txtID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bookRepo.UpdateBook(book);
                MessageBox.Show("Cập nhật thành công");
                LoadDataTheFirstTime();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookID = int.Parse(txtID.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm có ID: " + txtID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bookRepo.RemoveBook(bookRepo.getBookByBookID(bookID));
                MessageBox.Show("Xóa thành công");
                LoadDataTheFirstTime();
            }
            
        }
    }
}
