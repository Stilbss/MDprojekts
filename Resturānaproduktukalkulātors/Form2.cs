using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturānaproduktukalkulātors
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public Form2()
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            string name = this.name.Text;
            decimal price = decimal.Parse(this.price.Text);
            form1.AddProduct(name, price);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
