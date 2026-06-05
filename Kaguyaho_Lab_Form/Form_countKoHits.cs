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
    public partial class Form_countKoHits : Form
    {
        int hitCounts = 0;



        public Form_countKoHits()
        {
            InitializeComponent();
        }

        private void button_marryMe_Click(object sender, EventArgs e)
        {
            hitCounts++;
            label_hitCount.Text = hitCounts.ToString() + " hit(s) by IroP!";
        }

        private void button_ppcount_Click(object sender, EventArgs e)
        {
            //++hitCounts;

            int pphitCounts = 0;
            pphitCounts = ++hitCounts;
            label_hitCount.Text = hitCounts.ToString() + " hit(s) by IroP!";
            label_ppcount.Text = "? = ++count -> " + pphitCounts.ToString();
        }

        private void button_countpp_Click(object sender, EventArgs e)
        {
            //hitCounts++;

            int hitCountspp = 0;
            hitCountspp = hitCounts++;
            label_hitCount.Text = hitCounts.ToString() + " hit(s) by IroP!";
            label_countpp.Text = "? = count++ -> " + hitCountspp.ToString();
        }

        int pg_x;
        LabStaticClass lc = new LabStaticClass();

        //void pgMyVoid1()
        //{
        //    int a = 1;
        //    if (true)
        //    {
        //        int x = 1;
        //        a = ++x;
        //    }
        //    pg_x = ++a;
        //}

        private void button_changeVar_Click(object sender, EventArgs e)
        {
            //pgMyVoid1();
            label_playVar1.Text = "label" + pg_x.ToString();
        }

        private void button_nonStaticVar_Click(object sender, EventArgs e)
        {
            lc.NoStaticVar++;
            label_nonStaticVar.Text = "NoStaticVar Count: " + lc.NoStaticVar;
        }

        private void button_staticVar_Click(object sender, EventArgs e)
        {
            LabStaticClass.StaticVar++;
            label_staticVar.Text = "StaticVar Count: " + LabStaticClass.StaticVar;
        }

        private void button_kaguyahoStaticVar_Click(object sender, EventArgs e)
        {
            Form_Kaguyaho frm = new Form_Kaguyaho();
            frm.Show();
        }
    }
}