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

        private void button_save_Click(object sender, EventArgs e)
        {
            Product pro;
            pro.Name = textBox_productName.Text;
            pro.Price = decimal.Parse(textBox_price.Text);

            _result += $"名稱: {pro.Name}, 單價: {pro.Price}\n";
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            label_productList.Text = _result;
        }
    }
}
