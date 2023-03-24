namespace BookApplication.Admin
{
    partial class frmReporting
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTotalMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTotalMoney = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbY3 = new System.Windows.Forms.Label();
            this.lbY2 = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTotalMoney
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalMoney.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalMoney.Legends.Add(legend1);
            this.chartTotalMoney.Location = new System.Drawing.Point(13, 91);
            this.chartTotalMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartTotalMoney.Name = "chartTotalMoney";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Rv1";
            this.chartTotalMoney.Series.Add(series1);
            this.chartTotalMoney.Size = new System.Drawing.Size(540, 781);
            this.chartTotalMoney.TabIndex = 0;
            this.chartTotalMoney.Text = "chartTotalMoney";
            this.chartTotalMoney.Click += new System.EventHandler(this.chartTotalMoney_Click);
            // 
            // chartQuantity
            // 
            chartArea2.Name = "ChartArea1";
            this.chartQuantity.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartQuantity.Legends.Add(legend2);
            this.chartQuantity.Location = new System.Drawing.Point(555, 91);
            this.chartQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartQuantity.Name = "chartQuantity";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Q";
            this.chartQuantity.Series.Add(series2);
            this.chartQuantity.Size = new System.Drawing.Size(540, 781);
            this.chartQuantity.TabIndex = 1;
            this.chartQuantity.Text = "chartQuantity";
            // 
            // chartCategory
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCategory.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCategory.Legends.Add(legend3);
            this.chartCategory.Location = new System.Drawing.Point(1103, 91);
            this.chartCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartCategory.Name = "chartCategory";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            series3.Legend = "Legend1";
            series3.Name = "Rv2";
            this.chartCategory.Series.Add(series3);
            this.chartCategory.Size = new System.Drawing.Size(540, 781);
            this.chartCategory.TabIndex = 2;
            this.chartCategory.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 893);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doanh thu năm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(570, 893);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng sách bán được năm ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1121, 893);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Doanh thu từng thể loại năm ";
            // 
            // cboTotalMoney
            // 
            this.cboTotalMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTotalMoney.FormattingEnabled = true;
            this.cboTotalMoney.Location = new System.Drawing.Point(13, 25);
            this.cboTotalMoney.Name = "cboTotalMoney";
            this.cboTotalMoney.Size = new System.Drawing.Size(299, 40);
            this.cboTotalMoney.TabIndex = 6;
            this.cboTotalMoney.SelectedIndexChanged += new System.EventHandler(this.cboTotalMoney_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1459, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(184, 58);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbY3
            // 
            this.lbY3.AutoSize = true;
            this.lbY3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbY3.Location = new System.Drawing.Point(369, 893);
            this.lbY3.Name = "lbY3";
            this.lbY3.Size = new System.Drawing.Size(88, 45);
            this.lbY3.TabIndex = 29;
            this.lbY3.Text = "2023";
            // 
            // lbY2
            // 
            this.lbY2.AutoSize = true;
            this.lbY2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbY2.Location = new System.Drawing.Point(997, 893);
            this.lbY2.Name = "lbY2";
            this.lbY2.Size = new System.Drawing.Size(88, 45);
            this.lbY2.TabIndex = 30;
            this.lbY2.Text = "2023";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbY.Location = new System.Drawing.Point(1546, 893);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(88, 45);
            this.lbY.TabIndex = 31;
            this.lbY.Text = "2023";
            // 
            // frmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 991);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbY2);
            this.Controls.Add(this.lbY3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cboTotalMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartCategory);
            this.Controls.Add(this.chartQuantity);
            this.Controls.Add(this.chartTotalMoney);
            this.Name = "frmReporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.frmReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboTotalMoney;
        private Button btnExit;
        private Label lbY3;
        private Label lbY2;
        private Label lbY;
    }
}