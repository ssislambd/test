using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double FirstPrm;
        private double SecondPrm;
        private void MyParam()
        {
            FirstPrm = Convert.ToDouble(txtFirst.Text);
            SecondPrm = Convert.ToDouble(txtSecond.Text);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            this.MyParam();
            double result = FirstPrm + SecondPrm;
            string my_value = Convert.ToString(result);
            txtResult.Text = my_value;
            MessageBox.Show("Your Sum Result:" + my_value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MyParam();
            double result = FirstPrm - SecondPrm;
            string my_value = Convert.ToString(result);
            MessageBox.Show("Your Sub Result:" + my_value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MyParam();
            double result = FirstPrm * SecondPrm;
            string my_value = Convert.ToString(result);
            MessageBox.Show("Your Multy Result:" + my_value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.MyParam();
            double result = FirstPrm / SecondPrm;
            string my_value = Convert.ToString(result);
            MessageBox.Show("Your Divide Result:" + my_value);
        }

    }
}
