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
    public partial class Form_Kaguyaho : Form
    {
        public Form_Kaguyaho()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string result_yourName = text_yourName.Text;
            MessageBox.Show(result_yourName + " Daisuki! <3");
            //this.Close();
        }
    }
}
