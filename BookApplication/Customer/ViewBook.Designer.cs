namespace BookApplication.Customer
{
    partial class frmViewBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbPriceSearch = new System.Windows.Forms.Label();
            this.lbPriceMax = new System.Windows.Forms.Label();
            this.lbPriceMin = new System.Windows.Forms.Label();
            this.trackBarSearchPrice = new System.Windows.Forms.TrackBar();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.dateTimeReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSearchPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(742, 164);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchTitle.Size = new System.Drawing.Size(300, 31);
            this.txtSearchTitle.TabIndex = 34;
            this.txtSearchTitle.TextChanged += new System.EventHandler(this.txtSearchTitle_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(582, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 30);
            this.label16.TabIndex = 33;
            this.label16.Text = "Nhà xuất bản :";
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(742, 109);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchAuthor.Size = new System.Drawing.Size(300, 31);
            this.txtSearchAuthor.TabIndex = 32;
            this.txtSearchAuthor.TextChanged += new System.EventHandler(this.txtSearchAuthor_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(582, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 30);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tác giả :";
            // 
            // lbPriceSearch
            // 
            this.lbPriceSearch.AutoSize = true;
            this.lbPriceSearch.Location = new System.Drawing.Point(275, 205);
            this.lbPriceSearch.Name = "lbPriceSearch";
            this.lbPriceSearch.Size = new System.Drawing.Size(32, 25);
            this.lbPriceSearch.TabIndex = 30;
            this.lbPriceSearch.Text = "50";
            // 
            // lbPriceMax
            // 
            this.lbPriceMax.AutoSize = true;
            this.lbPriceMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceMax.Location = new System.Drawing.Point(559, 233);
            this.lbPriceMax.Name = "lbPriceMax";
            this.lbPriceMax.Size = new System.Drawing.Size(45, 28);
            this.lbPriceMax.TabIndex = 29;
            this.lbPriceMax.Text = "100";
            // 
            // lbPriceMin
            // 
            this.lbPriceMin.AutoSize = true;
            this.lbPriceMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceMin.Location = new System.Drawing.Point(165, 233);
            this.lbPriceMin.Name = "lbPriceMin";
            this.lbPriceMin.Size = new System.Drawing.Size(23, 28);
            this.lbPriceMin.TabIndex = 28;
            this.lbPriceMin.Text = "0";
            // 
            // trackBarSearchPrice
            // 
            this.trackBarSearchPrice.Location = new System.Drawing.Point(152, 233);
            this.trackBarSearchPrice.Name = "trackBarSearchPrice";
            this.trackBarSearchPrice.Size = new System.Drawing.Size(399, 69);
            this.trackBarSearchPrice.TabIndex = 27;
            this.trackBarSearchPrice.Scroll += new System.EventHandler(this.trackBarSearchPrice_Scroll);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(185, 162);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchName.Size = new System.Drawing.Size(366, 31);
            this.txtSearchName.TabIndex = 26;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(185, 109);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(366, 33);
            this.cboSearchCategory.TabIndex = 25;
            this.cboSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cboSearchCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thể loại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tìm kiếm theo :";
            // 
            // cboOrder
            // 
            this.cboOrder.FormattingEnabled = true;
            this.cboOrder.Items.AddRange(new object[] {
            "Mới nhất",
            "Cũ - mới",
            "Được yêu thích",
            "Bán chạy",
            "Giá: thấp - cao",
            "Giá: cao - thấp",
            "Tên: A - Z",
            "Tên: Z - A"});
            this.cboOrder.Location = new System.Drawing.Point(185, 21);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(366, 33);
            this.cboOrder.TabIndex = 20;
            this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.cboOrder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sắp xếp theo :";
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(25, 308);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 62;
            this.dgvBook.RowTemplate.Height = 33;
            this.dgvBook.Size = new System.Drawing.Size(1017, 655);
            this.dgvBook.TabIndex = 18;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnAddCard);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.numericPrice);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numericQuantity);
            this.groupBox1.Controls.Add(this.dateTimeReleaseDate);
            this.groupBox1.Controls.Add(this.numericDiscount);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(1049, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 939);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(21, 696);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 39);
            this.btnReload.TabIndex = 40;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(307, 811);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(273, 47);
            this.btnAddCard.TabIndex = 39;
            this.btnAddCard.Text = "Thêm vào giỏ hàng";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(21, 820);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 30);
            this.label18.TabIndex = 38;
            this.label18.Text = "Số lượng";
            // 
            // numericPrice
            // 
            this.numericPrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericPrice.Enabled = false;
            this.numericPrice.Location = new System.Drawing.Point(180, 326);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.ReadOnly = true;
            this.numericPrice.Size = new System.Drawing.Size(180, 39);
            this.numericPrice.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 764);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 32);
            this.label17.TabIndex = 36;
            this.label17.Text = "Đặt hàng :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(18, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 30);
            this.label10.TabIndex = 14;
            this.label10.Text = "Giá ($) :";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(180, 816);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(93, 39);
            this.numericQuantity.TabIndex = 37;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimeReleaseDate
            // 
            this.dateTimeReleaseDate.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimeReleaseDate.Enabled = false;
            this.dateTimeReleaseDate.Location = new System.Drawing.Point(180, 465);
            this.dateTimeReleaseDate.Name = "dateTimeReleaseDate";
            this.dateTimeReleaseDate.Size = new System.Drawing.Size(400, 39);
            this.dateTimeReleaseDate.TabIndex = 18;
            // 
            // numericDiscount
            // 
            this.numericDiscount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numericDiscount.Enabled = false;
            this.numericDiscount.Location = new System.Drawing.Point(180, 389);
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.ReadOnly = true;
            this.numericDiscount.Size = new System.Drawing.Size(180, 39);
            this.numericDiscount.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(180, 51);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(400, 31);
            this.txtID.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(465, 884);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 39);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(180, 544);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 191);
            this.txtDescription.TabIndex = 19;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTitle.Enabled = false;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(180, 285);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.Size = new System.Drawing.Size(400, 31);
            this.txtTitle.TabIndex = 22;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthor.Location = new System.Drawing.Point(180, 233);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAuthor.Size = new System.Drawing.Size(400, 31);
            this.txtAuthor.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(18, 543);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 30);
            this.label14.TabIndex = 20;
            this.label14.Text = "Miêu tả :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(18, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 30);
            this.label13.TabIndex = 19;
            this.label13.Text = "Ngày ra mắt :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(18, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giảm giá (%) :";
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboCategory.Enabled = false;
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(180, 168);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(400, 33);
            this.cboCategory.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(18, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "Thể loại :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(180, 110);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtName.Size = new System.Drawing.Size(400, 31);
            this.txtName.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(18, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 30);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tên :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(18, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tác giả :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(18, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 30);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nhà xuất bản :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID :";
            // 
            // frmViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 991);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSearchAuthor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbPriceSearch);
            this.Controls.Add(this.lbPriceMax);
            this.Controls.Add(this.lbPriceMin);
            this.Controls.Add(this.trackBarSearchPrice);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.cboSearchCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBook);
            this.Name = "frmViewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.frmViewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSearchPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSearchTitle;
        private Label label16;
        private TextBox txtSearchAuthor;
        private Label label15;
        private Label lbPriceSearch;
        private Label lbPriceMax;
        private Label lbPriceMin;
        private TrackBar trackBarSearchPrice;
        private TextBox txtSearchName;
        private ComboBox cboSearchCategory;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboOrder;
        private Label label1;
        private DataGridView dgvBook;
        private GroupBox groupBox1;
        private NumericUpDown numericPrice;
        private Label label10;
        private DateTimePicker dateTimeReleaseDate;
        private NumericUpDown numericDiscount;
        private TextBox txtID;
        private Button btnExit;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label14;
        private Label label13;
        private Label label7;
        private ComboBox cboCategory;
        private Label label12;
        private TextBox txtName;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label6;
        private Button btnAddCard;
        private Label label18;
        private Label label17;
        private NumericUpDown numericQuantity;
        private Button btnReload;
    }
}