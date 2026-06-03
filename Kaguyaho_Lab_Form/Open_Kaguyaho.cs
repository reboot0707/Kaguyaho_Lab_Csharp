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
    public partial class Open_Kaguyaho : Form
    {
        public Open_Kaguyaho()
        {
            InitializeComponent();
        }

        private void buttonOpenformKaguyaho_click(object sender, EventArgs e)
        {
            Form_Kaguyaho kaguYaho  = new Form_Kaguyaho();
            kaguYaho.Show();
        }

        private void button_nameis168_Click(object sender, EventArgs e)
        {
            call168();
        }

        void call168()
        {
            string IrohaName = "Joroha...";
            MessageBox.Show( IrohaName + " Onegai~ QAQ");
        }
    }
}
