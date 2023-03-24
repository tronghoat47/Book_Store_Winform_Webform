namespace BookApplication.Admin
{
    partial class frmManagerBook
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
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSearchCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.trackBarSearchPrice = new System.Windows.Forms.TrackBar();
            this.lbPriceMin = new System.Windows.Forms.Label();
            this.lbPriceMax = new System.Windows.Forms.Label();
            this.lbPriceSearch = new System.Windows.Forms.Label();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSearchPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(37, 311);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 62;
            this.dgvBook.RowTemplate.Height = 33;
            this.dgvBook.Size = new System.Drawing.Size(995, 655);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericPrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimeReleaseDate);
            this.groupBox1.Controls.Add(this.numericDiscount);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnReload);
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
            this.groupBox1.Location = new System.Drawing.Point(1048, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 939);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(180, 326);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(180, 39);
            this.numericPrice.TabIndex = 28;
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
            // dateTimeReleaseDate
            // 
            this.dateTimeReleaseDate.Location = new System.Drawing.Point(180, 465);
            this.dateTimeReleaseDate.Name = "dateTimeReleaseDate";
            this.dateTimeReleaseDate.Size = new System.Drawing.Size(400, 39);
            this.dateTimeReleaseDate.TabIndex = 18;
            // 
            // numericDiscount
            // 
            this.numericDiscount.Location = new System.Drawing.Point(180, 389);
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(180, 39);
            this.numericDiscount.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(180, 51);
            this.txtID.Name = "txtID";
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
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(482, 812);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 39);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(317, 812);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 39);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 812);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 39);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(18, 812);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 39);
            this.btnReload.TabIndex = 23;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(180, 544);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 191);
            this.txtDescription.TabIndex = 19;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(180, 285);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitle.Size = new System.Drawing.Size(400, 31);
            this.txtTitle.TabIndex = 22;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAuthor.Location = new System.Drawing.Point(180, 233);
            this.txtAuthor.Name = "txtAuthor";
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
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(180, 168);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(400, 33);
            this.cboCategory.TabIndex = 15;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
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
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(180, 110);
            this.txtName.Name = "txtName";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sắp xếp theo :";
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
            this.cboOrder.Location = new System.Drawing.Point(197, 24);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(366, 33);
            this.cboOrder.TabIndex = 2;
            this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.cboOrder_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thể loại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá :";
            // 
            // cboSearchCategory
            // 
            this.cboSearchCategory.FormattingEnabled = true;
            this.cboSearchCategory.Location = new System.Drawing.Point(197, 112);
            this.cboSearchCategory.Name = "cboSearchCategory";
            this.cboSearchCategory.Size = new System.Drawing.Size(366, 33);
            this.cboSearchCategory.TabIndex = 8;
            this.cboSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cboSearchCategory_SelectedIndexChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(197, 165);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchName.Size = new System.Drawing.Size(366, 31);
            this.txtSearchName.TabIndex = 9;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // trackBarSearchPrice
            // 
            this.trackBarSearchPrice.Location = new System.Drawing.Point(164, 236);
            this.trackBarSearchPrice.Name = "trackBarSearchPrice";
            this.trackBarSearchPrice.Size = new System.Drawing.Size(399, 69);
            this.trackBarSearchPrice.TabIndex = 10;
            this.trackBarSearchPrice.Scroll += new System.EventHandler(this.trackBarSearchPrice_Scroll);
            // 
            // lbPriceMin
            // 
            this.lbPriceMin.AutoSize = true;
            this.lbPriceMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceMin.Location = new System.Drawing.Point(145, 236);
            this.lbPriceMin.Name = "lbPriceMin";
            this.lbPriceMin.Size = new System.Drawing.Size(23, 28);
            this.lbPriceMin.TabIndex = 11;
            this.lbPriceMin.Text = "0";
            // 
            // lbPriceMax
            // 
            this.lbPriceMax.AutoSize = true;
            this.lbPriceMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPriceMax.Location = new System.Drawing.Point(559, 236);
            this.lbPriceMax.Name = "lbPriceMax";
            this.lbPriceMax.Size = new System.Drawing.Size(45, 28);
            this.lbPriceMax.TabIndex = 12;
            this.lbPriceMax.Text = "100";
            // 
            // lbPriceSearch
            // 
            this.lbPriceSearch.AutoSize = true;
            this.lbPriceSearch.Location = new System.Drawing.Point(287, 208);
            this.lbPriceSearch.Name = "lbPriceSearch";
            this.lbPriceSearch.Size = new System.Drawing.Size(32, 25);
            this.lbPriceSearch.TabIndex = 13;
            this.lbPriceSearch.Text = "50";
            this.lbPriceSearch.Click += new System.EventHandler(this.lbPriceSearch_Click);
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(754, 112);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchAuthor.Size = new System.Drawing.Size(278, 31);
            this.txtSearchAuthor.TabIndex = 15;
            this.txtSearchAuthor.TextChanged += new System.EventHandler(this.txtSearchAuthor_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(594, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 30);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tác giả :";
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(754, 167);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchTitle.Size = new System.Drawing.Size(278, 31);
            this.txtSearchTitle.TabIndex = 17;
            this.txtSearchTitle.TextChanged += new System.EventHandler(this.txtSearchTitle_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(594, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 30);
            this.label16.TabIndex = 16;
            this.label16.Text = "Nhà xuất bản :";
            // 
            // frmManagerBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 991);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBook);
            this.Name = "frmManagerBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerBook";
            this.Load += new System.EventHandler(this.frmManagerBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSearchPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBook;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cboOrder;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboSearchCategory;
        private TextBox txtSearchName;
        private TrackBar trackBarSearchPrice;
        private Label lbPriceMin;
        private Label lbPriceMax;
        private Label lbPriceSearch;
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
        private TextBox txtSearchAuthor;
        private Label label15;
        private Button btnExit;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtSearchTitle;
        private Label label16;
        private TextBox txtID;
        private NumericUpDown numericDiscount;
        private DateTimePicker dateTimeReleaseDate;
        private NumericUpDown numericPrice;
        private Label label10;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnReload;
    }
}