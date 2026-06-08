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

        private void button_calcGrade_Click(object sender, EventArgs e)
        {
            float score_num = float.Parse(textBox_score.Text);
            if (score_num <= 100 && score_num >= 90)
            {
                label_scoreGrade.Text = "ㄅ級分";
            }
            else if (score_num < 90 && score_num >= 80)
            {
                label_scoreGrade.Text = "ㄆ級分";
            }
            else if (score_num < 80 && score_num >= 70)
            {
                label_scoreGrade.Text = "ㄇ級分";
            }
            else if (score_num < 70 && score_num >= 60)
            {
                label_scoreGrade.Text = "ㄈ級分";
            }
            else if (score_num < 60 && score_num >= 0)
            {
                label_scoreGrade.Text = "ㄦ級分/拉完了";
            }
            else
            {
                label_scoreGrade.Text = "Please Try Again";
            }
        }
    }
}
