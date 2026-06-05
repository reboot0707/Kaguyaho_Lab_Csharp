using System;
using System.Windows.Forms;

namespace Kaguyaho_Lab_Form //命名空間，可以跨越多個檔案
{
    public partial class Form_Kaguyaho : Form //冒號帶有「繼承」的概念, class 是類別
    {
        public Form_Kaguyaho() // 這個也是類別
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string result_yourName = text_yourName.Text;
            MessageBox.Show(result_yourName + " Daisuki! <3");
            //this.Close();
        }

        private void button_countStaticVar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Static Var. : " + LabStaticClass.StaticVar);
        }
    }
}
