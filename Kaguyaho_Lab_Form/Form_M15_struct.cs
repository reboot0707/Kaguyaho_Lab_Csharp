using System;
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
    public partial class Form_M15_struct : Form
    {
        public Form_M15_struct()
        {
            InitializeComponent();
        }

        private string _result = "產品\n";
        private int _count = 0;
        private decimal _total = 0;

        private void button_save_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            bool isSuccess = decimal.TryParse(textBox_price.Text, out price);

            if (!isSuccess)
            {
                MessageBox.Show("請以數字輸入正確的金額!!!");
                textBox_price.Text = "";
                //textBox_price.Clear();
                textBox_price.Focus();
                return;
            }
            
            Product pro = new Product(textBox_productName.Text, decimal.Parse(textBox_price.Text));
            //pro.Name = textBox_productName.Text;
            //pro.Price = decimal.Parse(textBox_price.Text);

            _count ++;
            _total += pro.Price;
            _result += $"名稱: {pro.Name}, 單價: {pro.Price}\n";
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            // 產品數量 平均單價
            label_productList.Text = $"{_result}------------------" +
                $"\n產品數量: {_count}, 平均單價: {_total / _count}";
        }
    }
}
