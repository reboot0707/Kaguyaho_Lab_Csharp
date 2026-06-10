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
    public partial class Form_M21_advancedMethod : Form
    {
        public Form_M21_advancedMethod()
        {
            InitializeComponent();
        }

        void Swap(ref int a, ref int b)
        {
            int T = a;
            a = b;
            b = T;
        }

        void Swap(ref double a, ref double b)
        {
            double T = a;
            a = b;
            b = T;
        }

        private void button_overloadInt_Click(object sender, EventArgs e)
        {
            int intA = 114, intB = 514;
            string result = $"A: {intA}, B: {intB}";

            Swap (ref intA, ref intB);
            result += $"A: {intA}, B: {intB}";

            MessageBox.Show(result);
        }

        private void button_overloadDouble_Click(object sender, EventArgs e)
        {
            double intA = 114, intB = 514;
            string result = $"A: {intA}, B: {intB}\n";

            Swap(ref intA, ref intB);
            result += $"A: {intA}, B: {intB}\n";

            MessageBox.Show(result);
        }
    }
}
