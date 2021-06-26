namespace CafeteriaSystem
{
    partial class UpdateProucts
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
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.UploadPictureButton = new System.Windows.Forms.Button();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.ProductDescriptionRBox = new System.Windows.Forms.RichTextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProductIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(302, 209);
            this.ProductCategoryComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(264, 28);
            this.ProductCategoryComboBox.TabIndex = 31;
            this.ProductCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Product Category";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceBox.Location = new System.Drawing.Point(302, 169);
            this.ProductPriceBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.Size = new System.Drawing.Size(264, 27);
            this.ProductPriceBox.TabIndex = 29;
            this.ProductPriceBox.TextChanged += new System.EventHandler(this.ProductPriceBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Product Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.BackColor = System.Drawing.Color.Yellow;
            this.UpdateProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProductButton.Location = new System.Drawing.Point(93, 551);
            this.UpdateProductButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(202, 35);
            this.UpdateProductButton.TabIndex = 27;
            this.UpdateProductButton.Text = "Update Product";
            this.UpdateProductButton.UseVisualStyleBackColor = false;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // UploadPictureButton
            // 
            this.UploadPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadPictureButton.Location = new System.Drawing.Point(93, 437);
            this.UploadPictureButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UploadPictureButton.Name = "UploadPictureButton";
            this.UploadPictureButton.Size = new System.Drawing.Size(155, 35);
            this.UploadPictureButton.TabIndex = 26;
            this.UploadPictureButton.Text = "Upload Picture";
            this.UploadPictureButton.UseVisualStyleBackColor = true;
            this.UploadPictureButton.Click += new System.EventHandler(this.UploadPictureButton_Click);
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Location = new System.Drawing.Point(302, 374);
            this.ProductPictureBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(268, 158);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 25;
            this.ProductPictureBox.TabStop = false;
            this.ProductPictureBox.Click += new System.EventHandler(this.ProductPictureBox_Click);
            // 
            // ProductDescriptionRBox
            // 
            this.ProductDescriptionRBox.Location = new System.Drawing.Point(302, 250);
            this.ProductDescriptionRBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductDescriptionRBox.Name = "ProductDescriptionRBox";
            this.ProductDescriptionRBox.Size = new System.Drawing.Size(264, 110);
            this.ProductDescriptionRBox.TabIndex = 24;
            this.ProductDescriptionRBox.Text = "";
            this.ProductDescriptionRBox.TextChanged += new System.EventHandler(this.ProductDescriptionRBox_TextChanged);
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameBox.Location = new System.Drawing.Point(302, 129);
            this.ProductNameBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(264, 27);
            this.ProductNameBox.TabIndex = 23;
            this.ProductNameBox.TextChanged += new System.EventHandler(this.ProductNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Product Picture";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Product Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Yellow;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(357, 551);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(213, 35);
            this.CancelButton.TabIndex = 32;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProductIDBox
            // 
            this.ProductIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDBox.Location = new System.Drawing.Point(302, 89);
            this.ProductIDBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductIDBox.Name = "ProductIDBox";
            this.ProductIDBox.Size = new System.Drawing.Size(264, 27);
            this.ProductIDBox.TabIndex = 34;
            this.ProductIDBox.TextChanged += new System.EventHandler(this.ProductIDBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Product ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(150, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(343, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Update Product";
            // 
            // UpdateProucts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(701, 638);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductIDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.UploadPictureButton);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.ProductDescriptionRBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UpdateProucts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Proucts";
            this.Load += new System.EventHandler(this.UpdateProucts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Button UploadPictureButton;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.RichTextBox ProductDescriptionRBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox ProductIDBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}