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

        private void button_ageCalc_Click(object sender, EventArgs e)
        {
            string resultmsg_ageCalc = ageCalc(1996);
            MessageBox.Show(resultmsg_ageCalc);
        }

        void call168()
        {
            string IrohaName = "Iroha";
            MessageBox.Show( IrohaName + "... Onegai~ QAQ");
        }

        string ageCalc(int birthYear)
        {
            int Age = DateTime.Now.Year - birthYear;
            return "你的年齡是.... " + Age + "歲!";
        }

        private void button_yaoyaro_Click(object sender, EventArgs e)
        {
            Class_Tsukiyomi tsuki = new Class_Tsukiyomi();
            tsuki.Method_Tsukiyomi_03_2();
        }

        private void button_encaps_yaoyaro_Click(object sender, EventArgs e)
        {
            Class_Tsukiyomi tsuki = new Class_Tsukiyomi();
            tsuki.Method_Tsukiyomi_06();
        }

        private void button_partialclass_Click(object sender, EventArgs e)
        {
            Class_Tsukiyomi tsuki = new Class_Tsukiyomi();
            tsuki.Method_Tsukiyomi_09();
        }
    }
}
