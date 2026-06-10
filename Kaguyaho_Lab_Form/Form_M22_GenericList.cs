using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaguyaho_Lab_Form
{
    public partial class Form_M22_GenericList : Form
    {
        public Form_M22_GenericList()
        {
            InitializeComponent();
        }

        List<Product> lsProduct = new List<Product>();

        void ShowProductList()
        {
            labShow.Text = "產品\n";
            listBox_Products.Items.Clear();
            for (int i = 0; i < lsProduct.Count; i++)
            {
                labShow.Text += $"名稱: {((Product)lsProduct[i]).Name}, 單價: {((Product)lsProduct[i]).Price}\n";
                listBox_Products.Items.Add($"名稱: {((Product)lsProduct[i]).Name}, 單價: {((Product)lsProduct[i]).Price}");
            }

            //listBox_Products.DataSource = lsProduct;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Product pro = new Product(textBox_productName.Text, decimal.Parse(textBox_productPrice.Text));
            lsProduct.Add(pro);
            ShowProductList();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Product pro = new Product(textBox_productName.Text, decimal.Parse(textBox_productPrice.Text));
            lsProduct.Insert(0, pro);
            ShowProductList();
        }

        private void button_removeAt_Click(object sender, EventArgs e)
        {
            lsProduct.RemoveAt(0);
            ShowProductList();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            lsProduct.Clear();
            ShowProductList();
        }

        private void button_addDiffType_Click(object sender, EventArgs e)
        {
            //lsProduct.Add(100);
            //lsProduct.Add("string");

            ShowProductList();
        }
    }
}
