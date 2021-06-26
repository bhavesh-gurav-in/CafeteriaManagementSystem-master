namespace CafeteriaSystem
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameIDMenuLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BillGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.CategoryGroupBox.SuspendLayout();
            this.ProductsGroupBox.SuspendLayout();
            this.BillGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.Red;
            this.MainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCategoryToolStripMenuItem,
            this.addProductToolStripMenuItem,
            this.viewAllProductsToolStripMenuItem,
            this.viewSalesToolStripMenuItem,
            this.UserNameIDMenuLabel,
            this.logOutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1313, 31);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.addProductToolStripMenuItem.Text = "Add Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // viewAllProductsToolStripMenuItem
            // 
            this.viewAllProductsToolStripMenuItem.Name = "viewAllProductsToolStripMenuItem";
            this.viewAllProductsToolStripMenuItem.Size = new System.Drawing.Size(163, 27);
            this.viewAllProductsToolStripMenuItem.Text = "View All Products";
            this.viewAllProductsToolStripMenuItem.Click += new System.EventHandler(this.viewAllProductsToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.viewSalesToolStripMenuItem.Text = "View Sales";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // UserNameIDMenuLabel
            // 
            this.UserNameIDMenuLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserNameIDMenuLabel.BackColor = System.Drawing.Color.White;
            this.UserNameIDMenuLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserNameIDMenuLabel.Enabled = false;
            this.UserNameIDMenuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameIDMenuLabel.Image = global::CafeteriaSystem.Properties.Resources.UserIcon;
            this.UserNameIDMenuLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserNameIDMenuLabel.Name = "UserNameIDMenuLabel";
            this.UserNameIDMenuLabel.Size = new System.Drawing.Size(41, 27);
            this.UserNameIDMenuLabel.Text = " ";
            this.UserNameIDMenuLabel.Click += new System.EventHandler(this.UserNameIDMenuLabel_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.logOutToolStripMenuItem.Text = "About Us";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(82, 27);
            this.logOutToolStripMenuItem1.Text = "LogOut";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // CategoryGroupBox
            // 
            this.CategoryGroupBox.Controls.Add(this.CategoriesFlowPanel);
            this.CategoryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CategoryGroupBox.Location = new System.Drawing.Point(16, 46);
            this.CategoryGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryGroupBox.Name = "CategoryGroupBox";
            this.CategoryGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CategoryGroupBox.Size = new System.Drawing.Size(616, 255);
            this.CategoryGroupBox.TabIndex = 1;
            this.CategoryGroupBox.TabStop = false;
            this.CategoryGroupBox.Text = "Categories";
            // 
            // CategoriesFlowPanel
            // 
            this.CategoriesFlowPanel.AutoScroll = true;
            this.CategoriesFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CategoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesFlowPanel.Location = new System.Drawing.Point(4, 21);
            this.CategoriesFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CategoriesFlowPanel.Name = "CategoriesFlowPanel";
            this.CategoriesFlowPanel.Size = new System.Drawing.Size(608, 230);
            this.CategoriesFlowPanel.TabIndex = 0;
            this.CategoriesFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoriesFlowPanel_Paint);
            // 
            // ProductsGroupBox
            // 
            this.ProductsGroupBox.Controls.Add(this.ProductsFlowPanel);
            this.ProductsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductsGroupBox.Location = new System.Drawing.Point(16, 308);
            this.ProductsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsGroupBox.Name = "ProductsGroupBox";
            this.ProductsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ProductsGroupBox.Size = new System.Drawing.Size(612, 369);
            this.ProductsGroupBox.TabIndex = 2;
            this.ProductsGroupBox.TabStop = false;
            this.ProductsGroupBox.Text = "Products";
            // 
            // ProductsFlowPanel
            // 
            this.ProductsFlowPanel.AutoScroll = true;
            this.ProductsFlowPanel.BackColor = System.Drawing.Color.White;
            this.ProductsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsFlowPanel.Location = new System.Drawing.Point(4, 21);
            this.ProductsFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsFlowPanel.Name = "ProductsFlowPanel";
            this.ProductsFlowPanel.Size = new System.Drawing.Size(604, 344);
            this.ProductsFlowPanel.TabIndex = 0;
            // 
            // BillGroupBox
            // 
            this.BillGroupBox.Controls.Add(this.ProductsGridView);
            this.BillGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BillGroupBox.Location = new System.Drawing.Point(640, 46);
            this.BillGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.BillGroupBox.Name = "BillGroupBox";
            this.BillGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.BillGroupBox.Size = new System.Drawing.Size(673, 577);
            this.BillGroupBox.TabIndex = 3;
            this.BillGroupBox.TabStop = false;
            this.BillGroupBox.Text = "Select Product";
            this.BillGroupBox.Enter += new System.EventHandler(this.BillGroupBox_Enter);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.TotalPriceColumn,
            this.DeleteColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductsGridView.Location = new System.Drawing.Point(4, 21);
            this.ProductsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.Size = new System.Drawing.Size(665, 552);
            this.ProductsGridView.TabIndex = 0;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            this.ProductsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellEndEdit);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductIDColumn.FillWeight = 50F;
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.Name = "ProductIDColumn";
            this.ProductIDColumn.Width = 30;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductQuantityColumn.HeaderText = "Quantity";
            this.ProductQuantityColumn.MinimumWidth = 20;
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            this.ProductQuantityColumn.Width = 80;
            // 
            // TotalPriceColumn
            // 
            this.TotalPriceColumn.HeaderText = "Product Total";
            this.TotalPriceColumn.Name = "TotalPriceColumn";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(667, 643);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillBox.Location = new System.Drawing.Point(784, 640);
            this.TotalBillBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(257, 27);
            this.TotalBillBox.TabIndex = 5;
            this.TotalBillBox.TextChanged += new System.EventHandler(this.TotalBillBox_TextChanged);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(1081, 633);
            this.CheckOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(119, 41);
            this.CheckOutButton.TabIndex = 6;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1313, 691);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BillGroupBox);
            this.Controls.Add(this.ProductsGroupBox);
            this.Controls.Add(this.CategoryGroupBox);
            this.Controls.Add(this.MainMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.CategoryGroupBox.ResumeLayout(false);
            this.ProductsGroupBox.ResumeLayout(false);
            this.BillGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;
        private System.Windows.Forms.GroupBox CategoryGroupBox;
        private System.Windows.Forms.FlowLayoutPanel CategoriesFlowPanel;
        private System.Windows.Forms.GroupBox ProductsGroupBox;
        private System.Windows.Forms.FlowLayoutPanel ProductsFlowPanel;
        private System.Windows.Forms.GroupBox BillGroupBox;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.ToolStripMenuItem UserNameIDMenuLabel;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}

