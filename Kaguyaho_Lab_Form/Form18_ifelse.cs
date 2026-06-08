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
    public partial class Form18_ifelse : Form
    {
        public Form18_ifelse()
        {
            InitializeComponent();
        }
        bool flag = false;
        private void button_reverse_Click(object sender, EventArgs e)
        {
            flag = !flag;
            if (flag)
            {
                button_reverse.BackColor = Color.Black;
                button_reverse.ForeColor = Color.White;
            }
            else
            {
                button_reverse.BackColor = Color.White;
                button_reverse.ForeColor = Color.Black;
            }
        }
    }
}
