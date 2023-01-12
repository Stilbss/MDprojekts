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
    

    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var form2 = new Form2(this);
            form2.Show();
        }

        public void AddProduct(string name, decimal price)
        {
            products.Add(new Product { Name = name, Price = price });
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            productDataGridView.DataSource = null;
            productDataGridView.DataSource = products;
            productDataGridView.AutoGenerateColumns = true;
        }
        

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
