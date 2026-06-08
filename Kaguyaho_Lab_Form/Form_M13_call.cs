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

        private void button_callByRef_Click(object sender, EventArgs e)
        {
            Member memberNew = new Member()
            {
                id = 114,
                Name = "早見沙織",
                Phone = "0987654321"
            };
            method_callByRef(memberNew);
            MessageBox.Show($"{memberNew.id}, {memberNew.Name}, {memberNew.Phone}");
        }

        private void button_callbyString_Click(object sender, EventArgs e)
        {
            string myGOstring = "It's my go!  It's MyGO!! 大發現!!";
            method_callbyString(myGOstring);
            MessageBox.Show(myGOstring);
        }

        Decimal resuleRate = 1m;

        private void button_callbyRealRef_Click(object sender, EventArgs e)
        {
            
            method_callByRealRef(ref resuleRate);
            MessageBox.Show($"resultRate: {resuleRate}");
        }
        private void button_callbyOut_Click(object sender, EventArgs e)
        {
            Decimal R;
            method_callByOut(out R);
            MessageBox.Show($"R: {R}");
        }
        private void button_scoreTotal_Click(object sender, EventArgs e)
        {
            string totalResult = scoreCalcTotal("數學", 11, 41, 51, 41, 91, 98, 10);
            MessageBox.Show(totalResult);
        }

        public void method_callByValue(Decimal theRate)
        {
            theRate += 3.1415926535m;
        }

        void method_callByRef(Member member)
        {
            member.Name = "青木陽菜";
        }

        void method_callbyString(string inputstring)
        {
            inputstring = "是又怎樣";
        }
        void method_callByRealRef(ref Decimal theRate)
        {
            theRate += 3.1415926535m;
        }
        void method_callByOut(out Decimal theRate)
        {
            theRate = 1.14514191981m;
        }
        string scoreCalcTotal(string className, params Decimal[] scoreSingle)
        {
            Decimal score_total = 0;
            for (int i = 0; i < scoreSingle.Length; i++)
            {
                score_total += scoreSingle[i];
            }
            return $"{className} 的總成績: {score_total}";
        }
        string scoreCalcTotal_while(string className, params Decimal[] scoreSingle)
        {
            Decimal score_total = 0;
            int i = 0;
            while (i < scoreSingle.Length)
            {
                score_total += scoreSingle[i];
                i++;
            }
            return $"{className} 的總成績: {score_total}";
        }
    }
}
