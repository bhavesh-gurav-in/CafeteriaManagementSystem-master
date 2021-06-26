namespace CafeteriaSystem
{
    partial class CashForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.CashGivenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CashReturnBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmCheckoutButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Bill";
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillBox.Location = new System.Drawing.Point(243, 74);
            this.TotalBillBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(239, 27);
            this.TotalBillBox.TabIndex = 1;
            // 
            // CashGivenBox
            // 
            this.CashGivenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashGivenBox.Location = new System.Drawing.Point(243, 114);
            this.CashGivenBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CashGivenBox.Name = "CashGivenBox";
            this.CashGivenBox.Size = new System.Drawing.Size(239, 27);
            this.CashGivenBox.TabIndex = 3;
            this.CashGivenBox.TextChanged += new System.EventHandler(this.CashGivenBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cash Given";
            // 
            // CashReturnBox
            // 
            this.CashReturnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashReturnBox.Location = new System.Drawing.Point(243, 154);
            this.CashReturnBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CashReturnBox.Name = "CashReturnBox";
            this.CashReturnBox.Size = new System.Drawing.Size(239, 27);
            this.CashReturnBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cash Return";
            // 
            // ConfirmCheckoutButton
            // 
            this.ConfirmCheckoutButton.BackColor = System.Drawing.Color.Gold;
            this.ConfirmCheckoutButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConfirmCheckoutButton.Location = new System.Drawing.Point(139, 214);
            this.ConfirmCheckoutButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ConfirmCheckoutButton.Name = "ConfirmCheckoutButton";
            this.ConfirmCheckoutButton.Size = new System.Drawing.Size(264, 35);
            this.ConfirmCheckoutButton.TabIndex = 6;
            this.ConfirmCheckoutButton.Text = "Confirm Checkout";
            this.ConfirmCheckoutButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cash Form";
            // 
            // CashForm
            // 
            this.AcceptButton = this.ConfirmCheckoutButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(557, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmCheckoutButton);
            this.Controls.Add(this.CashReturnBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashGivenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmCheckoutButton;
        public System.Windows.Forms.TextBox TotalBillBox;
        public System.Windows.Forms.TextBox CashGivenBox;
        public System.Windows.Forms.TextBox CashReturnBox;
        private System.Windows.Forms.Label label4;
    }
}