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
    public partial class Form_M23_String : Form
    {
        public Form_M23_String()
        {
            InitializeComponent();
        }

        private void button_demoString_Click(object sender, EventArgs e)
        {
            string A = "AAAA", B;
            B = A;
            B = "BBBBBBBB";
            MessageBox.Show($"A:{A}, B:{B}");
        }

        private void button_demoStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb_A = new StringBuilder(), sb_B;
            sb_A.Append("AAAAAAAAAAAA");
            sb_B = sb_A;
            sb_B.Append("\nBBBBBBBBBBBB");
            MessageBox.Show($"sb_A:{sb_A}, sb_B:{sb_B}");
        }
    }
}
