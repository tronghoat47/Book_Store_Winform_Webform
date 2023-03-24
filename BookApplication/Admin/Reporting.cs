using BookLibrary;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace BookApplication.Admin
{
    public partial class frmReporting : Form
    {
        public Account infoAccount { get; set; }
        private OrderRepo orderRepo = new OrderRepo();
        private OrderDetailRepo orderDetailRepo = new OrderDetailRepo();
        private BookRepo bookRepo = new BookRepo();
        private CategoryRepo categoryRepo= new CategoryRepo();

        public frmReporting()
        {
            InitializeComponent();
        }

        private void frmReporting_Load(object sender, EventArgs e)
        {
            LoadDataChart(DateTime.Now.Year);
            List<string> listYear = orderRepo.GetListOrder().Select(y => y.OrderDate.Value.Year.ToString()).Distinct().ToList();
            cboTotalMoney.Items.AddRange(listYear.ToArray());
            cboTotalMoney.Text = DateTime.Now.Year.ToString();
        }

        private void LoadDataChart(int year)
        {
            chartCategory.DataSource = null;
            chartQuantity.DataSource = null;
            chartTotalMoney.DataSource = null;
            chartCategory.Series.Clear();
            chartQuantity.Series.Clear();
            chartTotalMoney.Series.Clear();

            IEnumerable<Order> ListOrder = orderRepo.GetListOrder();
            IEnumerable<OrderDetail> ListOrderDetail = orderDetailRepo.GetListOrderDetail();
            IEnumerable<Book> ListBook = bookRepo.GetListBook();
            IEnumerable<Category> ListCategory = categoryRepo.GetListCategory();

            List<Report> reportTotalMoney = new List<Report>();
            var totalMoneyByMonth = ListOrder
                                    .Join(ListOrderDetail, o => o.OrderId, od => od.OrderId, (o, od) => new { Order = o, OrderDetail = od })
                                    .Where(x => x.Order.OrderDate.HasValue && x.Order.OrderDate.Value.Year == year)
                                    .GroupBy(x => x.Order.OrderDate.Value.Month)
                                    .Select(g => new { Month = g.Key, TotalMoney = g.Sum(x => x.Order.TotalMoney) })
                                    .ToList();
            foreach (var item in totalMoneyByMonth)
            {
                Report report = new Report()
                {
                    Key = item.Month,
                    Value = (double)item.TotalMoney
                };
                reportTotalMoney.Add(report);
            }

            List<Report> reportQuantity = new List<Report>();
            var quantityByMonth = ListOrder
                                    .Join(ListOrderDetail, o => o.OrderId, od => od.OrderId, (o, od) => new { Order = o, OrderDetail = od })
                                    .Where(x => x.Order.OrderDate.HasValue && x.Order.OrderDate.Value.Year == year)
                                    .GroupBy(x => x.Order.OrderDate.Value.Month)
                                    .Select(g => new { Month = g.Key, Quantity = g.Sum(x => x.OrderDetail.Quantity) })
                                    .ToList();
            foreach (var item in quantityByMonth)
            {
                Report report = new Report()
                {
                    Key = item.Month,
                    Value = (double)item.Quantity
                };
                reportQuantity.Add(report);
            }

            List<Report> reportMoneyCategory = new List<Report>();
            var categoryByMonth = ListOrder
                .Join(ListOrderDetail, o => o.OrderId, od => od.OrderId, (o, od) => new { Order = o, OrderDetail = od })
                .Join(ListBook, od => od.OrderDetail.BookId, b => b.BookId, (od, b) => new { od.Order, b.CategoryId, od.Order.TotalMoney })
                .Join(ListCategory, x => x.CategoryId, c => c.CategoryId, (x, c) => new { x.Order.OrderDate, c.CategoryId, c.CategoryName, x.TotalMoney })
                .Where(x => x.OrderDate.HasValue && x.OrderDate.Value.Year == year)
                .GroupBy(x => new { Year = x.OrderDate.Value.Year, x.CategoryName, x.CategoryId })
                .Select(g => new { CateogryID = g.Key.CategoryId, CategoryName = g.Key.CategoryName, TotalMoney = g.Sum(x => x.TotalMoney) })
                .ToList();
            foreach (var item in categoryByMonth)
            {
                Report report = new Report()
                {
                    Key = (int)item.CateogryID,
                    Value = (double)item.TotalMoney,
                    Title =item.CategoryName
                };
                reportMoneyCategory.Add(report);
            }

            chartTotalMoney.Series.Add("Rv1");
            chartTotalMoney.ChartAreas[0].AxisX.Interval = 1;
            chartTotalMoney.ChartAreas[0].AxisY.Interval = 500;
            chartTotalMoney.DataSource = reportTotalMoney;
            chartTotalMoney.Series["Rv1"].XValueMember = "Key";
            chartTotalMoney.Series["Rv1"].YValueMembers = "Value";


            chartQuantity.Series.Add("Q");
            chartQuantity.ChartAreas[0].AxisX.Interval = 1;
            chartQuantity.DataSource = reportQuantity;
            chartQuantity.Series["Q"].XValueMember = "Key";
            chartQuantity.Series["Q"].YValueMembers = "Value";

            chartCategory.Series.Add("Rv2");
            chartCategory.Series["Rv2"].ChartType = SeriesChartType.Pie;
            chartCategory.DataSource = reportMoneyCategory;
            chartCategory.Series["Rv2"].IsValueShownAsLabel= true;
            chartCategory.Series["Rv2"].XValueMember = "Title";
            chartCategory.Series["Rv2"].YValueMembers = "Value";
        }

        private void cboTotalMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataChart(int.Parse(cboTotalMoney.Text));
            lbY.Text = cboTotalMoney.Text;
            lbY2.Text = cboTotalMoney.Text;
            lbY3.Text = cboTotalMoney.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chartTotalMoney_Click(object sender, EventArgs e)
        {

        }
    }
}
