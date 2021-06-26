using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;
using System.Collections.Specialized;
using System.IO;
 


namespace CafeteriaSystem
{
    public partial class forgetpassword : Form
    {
        int UserID;
        string randomnumber;
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String result;
            string apiKey = "NWQ5NGE0NDE3YzEyNWZiODU4OTdkYTM1MjY4N2YwOGU=";
            string numbers = textBox2.Text; // in a comma seperated list
           
            string send = "StarCafe";
            string name = textBox1.Text;
            Random rnd = new Random();
            randomnumber=(rnd.Next(10000000,999999999)).ToString();
             string message = "Hey Chutiye" + name + "Your OTP is =>" + randomnumber;

            String url = "https://api.textlocal.in/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + sender;
            //refer to parameters to complete correct url string

            StreamWriter myWriter = null;
            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

            objRequest.Method = "POST";
            objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
            objRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(objRequest.GetRequestStream());
                myWriter.Write(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myWriter.Close();
            }

            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
            using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                // Close and clean up the StreamReader
                sr.Close();
            }
            MessageBox.Show("OTP send successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UserID = Convert.ToInt32(textBox1.Text);
            if (textBox3.Text == randomnumber)
            {
                MessageBox.Show("Logined Successfully");
                Dashboard _dash = new Dashboard(UserID);
                this.Hide();
                _dash.Show();

            
            }
            else
            {
                MessageBox.Show("Wrong OTP");
            }
        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     }
}

