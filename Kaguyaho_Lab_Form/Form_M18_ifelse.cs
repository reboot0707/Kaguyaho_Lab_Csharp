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
    public partial class Form_M18_ifelse : Form
    {

        DateTime myPickDateTime = new DateTime
        (
            2038, 1, 19, 3, 14, 8,
            DateTimeKind.Utc
        );

        public Form_M18_ifelse()
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
            float score_num = 0;
            if (float.TryParse(textBox_score.Text, out score_num))
            {
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
            else
            {
                DialogResult msg_result = MessageBox.Show("數字是會不會打?", "?????", MessageBoxButtons.YesNo);
                switch (msg_result)
                {
                    case DialogResult.Yes:
                        MessageBox.Show("會打? 回去給我好好重打");
                        break;
                    case DialogResult.No:
                        MessageBox.Show("不會打? 不會要問!");
                        break;
                    default:
                        MessageBox.Show("不知道自己會不會? 不管, 還是要問!");
                        break;
                }
                textBox_score.Text = "";
                textBox_score.Focus();
            }
        }

        private void button_practiceWhile_MouseClick(object sender, MouseEventArgs e)
        {
            int test_num = 10;
            string test_result = "";
            while (test_num < 10)
            {
                test_result += test_num.ToString() + "\n";
                test_num++;
            }
            MessageBox.Show(test_result);
        }

        private void button_doloop_MouseClick(object sender, MouseEventArgs e)
        {
            int test_num = 10;
            string test_result = "";
            do
            {
                test_result += test_num.ToString() + "\n";
                test_num++;
            }
            while (test_num < 10);
            MessageBox.Show(test_result);
        }

        private void button_forloop_Click(object sender, EventArgs e)
        {
            string test_for_result = "";
            for (int i = 0, j = 1; i < 100; i = j)
            {
                test_for_result += $"i: {i}, j: {j}, i+j: {i + j}\n";
                j = i + j;
            }
            MessageBox.Show(test_for_result);
        }

        private void button_foreachloop_Click(object sender, EventArgs e)
        {
            int[] score_multi = { 11, 41, 5, 14, 191, 98, 10 };
            string print_result = "";
            foreach (int score in score_multi)
            {
                print_result += score.ToString();
            }
            MessageBox.Show(print_result);
        }

        bool test_control_flag = false;

        private void button_controlloop_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                //if(  !(item is  Button))
                // {
                //     continue;
                // }

                if (item.GetType() != typeof(Button))
                {
                    continue;
                }


                if (test_control_flag == true)
                {
                    item.BackColor = Color.Black;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                //item.Left += 5;
                //item.Top -= 5;

            }
            test_control_flag = !test_control_flag;
        }

        private void timer_control_Tick(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                //if(  !(item is  Button))
                // {
                //     continue;
                // }

                if (item.GetType() != typeof(Button))
                {
                    continue;
                }


                if (test_control_flag == true)
                {
                    item.BackColor = Color.Black;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
                //item.Left += 5;
                //item.Top -= 5;

            }
            test_control_flag = !test_control_flag;
        }
    }
}
