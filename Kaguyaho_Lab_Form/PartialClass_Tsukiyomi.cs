using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaguyaho_Lab_Form
{
    partial class Class_Tsukiyomi
    {
        private void Method_Tsukiyomi_07()
        {
            MessageBox.Show("Yaoyaro 07!");
        }
        public void Method_Tsukiyomi_08()
        {
            MessageBox.Show("Yaoyaro 08!");
        }
        public void Method_Tsukiyomi_09()
        {
            Method_Tsukiyomi_01();
            Method_Tsukiyomi_02();
            Method_Tsukiyomi_07();
            MessageBox.Show("Yaoyaro 08!");
        }
    }
}
