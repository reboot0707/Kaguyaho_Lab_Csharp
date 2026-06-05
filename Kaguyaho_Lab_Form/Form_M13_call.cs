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
    public partial class Form_M13_call : Form
    {
        public Form_M13_call()
        {
            InitializeComponent();
        }

        private void button_callByValue_Click(object sender, EventArgs e)
        {
            Decimal resuleRate = 1m;
            method_callByValue(resuleRate);
            MessageBox.Show($"resultRate: {resuleRate}");
        }

        public void method_callByValue(Decimal theRate)
        {
            theRate += 3.1415926535m;
        }
    }
}
