using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaguyaho_Lab_Form
{
    internal class Class_Tsukiyomi
    {
        void Method_Tsukiyomi_01()
        {
            MessageBox.Show("Yaoyaro 01!");
        }
        void Method_Tsukiyomi_01_1() 
        {
            MessageBox.Show("Yaoyaro 01!");
            Method_Tsukiyomi_02();

        }
        private void Method_Tsukiyomi_02()
        {
            MessageBox.Show("Yaoyaro 02!");
        }

        internal void Method_Tsukiyomi_03()
        {
            MessageBox.Show("Yaoyaro 03!");
        }
        internal void Method_Tsukiyomi_03_2()
        {
            MessageBox.Show("Yaoyaro 03!");
            Method_Tsukiyomi_02();
        }

        public void Method_Tsukiyomi_05()
        {
            MessageBox.Show("Yaoyaro 05!");
        }
    }
}
