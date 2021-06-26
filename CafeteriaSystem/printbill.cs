using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaSystem
{
    public partial class printbill : Form
    {
        public printbill(int SaleID)
        {
            InitializeComponent();

            this.SaleID = SaleID;
        }

        int SaleID = 0;

        private void printbill_Load(object sender, EventArgs e)
        {
           // BillGridView.AllowUserToAddRows= false;

            DataAccess _DataAccess = new DataAccess();

            foreach (Details SaleItemsDetails in _DataAccess.RetreiveSaleItems(SaleID))
            {
                BillGridView.Rows.Add(SaleItemsDetails.Name, SaleItemsDetails.Price, SaleItemsDetails.Quantity, SaleItemsDetails.Total);
            }

        /*    int sum = 0;
            for (int i = 0; i <= BillGridView.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(BillGridView.Rows[i].Cells[3].Value.ToString());
            }
            textBox1.Text = sum.ToString();*/



        }
        private void BillGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label1.Text , new Font("Arial", 36, FontStyle.Bold), Brushes.Black, new PointF(150, 10));
            e.Graphics.DrawString(label5.Text, new Font("Arial", 24, FontStyle.Bold), Brushes.Black, new PointF(270, 80));
            e.Graphics.DrawString("============================================================================================================================", new Font("arial" , 14 , FontStyle.Bold) ,Brushes.Black, new PointF(0, 120));

            e.Graphics.DrawString("Date:- " + DateTime.Now.ToShortDateString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(600, 160));

            e.Graphics.DrawString("Name:- " + textBox1.Text , new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new PointF(0, 160));

            e.Graphics.DrawString("============================================================================================================================", new Font("arial", 14, FontStyle.Bold), Brushes.Black, new PointF(0, 200));

            e.Graphics.DrawString("Name", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(0, 230));
            e.Graphics.DrawString("Price", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(200, 230));
            e.Graphics.DrawString("Quantity", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(400, 230));
            e.Graphics.DrawString("Total Price", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new PointF(600, 230));

            e.Graphics.DrawString("============================================================================================================================", new Font("arial", 14, FontStyle.Bold), Brushes.Black, new PointF(0, 250));

            

           // e.Graphics.DrawImage(bmp, 0, 290);
        }

        //Bitmap bmp;

        private void button1_Click_2(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

           /* int height = BillGridView.Height;
            BillGridView.Height = BillGridView.RowCount * BillGridView.RowTemplate.Height * 2;
            Bitmap bmp = new Bitmap(BillGridView.Width, BillGridView.Height);
            BillGridView.DrawToBitmap(bmp, new Rectangle(0, 0, BillGridView.Width, BillGridView.Height));
            BillGridView.Height = height;
            printPreviewDialog1.ShowDialog();

             Graphics g = this.CreateGraphics();
             bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
             Graphics ng = Graphics.FromImage(bmp);
             ng.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
             printPreviewDialog1.ShowDialog();*/
        }
    }
}
