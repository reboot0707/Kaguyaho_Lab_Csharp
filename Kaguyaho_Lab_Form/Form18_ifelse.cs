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
    public partial class Form18_ifelse : Form
    {

        DateTime myPickDateTime = DateTime.Now;

        public Form18_ifelse()
        {
            InitializeComponent();
            label_dateTime.Text = $"{DateTime.Now:yyyy年MM月dd日 HH點mm分ss秒}";
        }
        bool flag = false;
        private void button_reverse_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                button_reverse.BackColor = Color.Black;
                button_reverse.ForeColor = Color.White;
            }
            else
            {
                button_reverse.BackColor = Color.White;
                button_reverse.ForeColor = Color.Black;
            }
            flag = !flag;
        }

        private void button_tri_MouseClick(object sender, MouseEventArgs e)
        {
            button_tri.BackColor = flag ? Color.Black : Color.White;
            button_tri.ForeColor = flag ? Color.White : Color.Black;
            flag = !flag;
        }

        private void button_selectDateTime_Click(object sender, EventArgs e)
        {
            myPickDateTime = dateTimePicker2.Value;
        }

        private void timer_datetime_Tick(object sender, EventArgs e)
        {
            label_dateTime.Text = $"{DateTime.Now:yyyy年MM月dd日 HH點mm分ss秒}";
        }

        private void timer_blink_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > myPickDateTime)
            {
                button_tri.BackColor = flag ? Color.Black : Color.White;
                button_tri.ForeColor = flag ? Color.White : Color.Black;
                flag = !flag;
            }
        }
    }
}
