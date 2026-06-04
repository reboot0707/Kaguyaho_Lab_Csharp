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
    }
}
