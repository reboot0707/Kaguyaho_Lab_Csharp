using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Form_Kaguyaho kaguYaho = new Form_Kaguyaho();
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
            MessageBox.Show(IrohaName + "... Onegai~ QAQ");
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

        private void button_member_Click(object sender, EventArgs e)
        {
            Member tsukiMember_168 = new Member();
            tsukiMember_168.id = 0;
            tsukiMember_168.Phone = "0987654321";
            tsukiMember_168.Name = "Iroha";
            MessageBox.Show("Yokoso! " + tsukiMember_168.Name + "\nYour Tsukiyomi Id is " + tsukiMember_168.id + "\nYour Phone Number is " + tsukiMember_168.Phone);

            Member tsukiMember_kaguya = new Member()
            {
                id = 1,
                Phone = "0987654322",
                Name = "Kaguya"
            };
            MessageBox.Show("Yokoso! " + tsukiMember_kaguya.Name + "\nYour Tsukiyomi Id is " + tsukiMember_kaguya.id + "\nYour Phone Number is " + tsukiMember_kaguya.Phone);

            Member tsukiMember_doge = new Member()
            {
                id = 2,
                Phone = "0987654322",
                Name = "Inudoge"
            };
            MessageBox.Show("Yokoso! " + tsukiMember_doge.Name + "\nYour Tsukiyomi Id is " + tsukiMember_doge.id + "\nYour Phone Number is " + tsukiMember_doge.Phone);
        }

        private void pictureBox_Iroha_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.cho-kaguyahime.com/");
        }

        private void button_registerEvent_Click(object sender, EventArgs e)
        {
            this.button_register01.Click += new System.EventHandler(this.button_register01_Click);
            this.button_register02.Click += new System.EventHandler(this.button_register02_Click);
        }

        private void button_unregisterEvent_Click(object sender, EventArgs e)
        {
            button_register01.Click -= button_register01_Click;
        }

        private void button_register01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaguyaho! Register 01");
        }
        private void button_register02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yaoyaro! Register 02");
        }

        private void button_ifReply_Click(object sender, EventArgs e)
        {
            DialogResult endType = MessageBox.Show("After Kaguya go back to the moon.  Iroha appreciates the moment with her and go back to normal life, this is the end of story.  Right?", "Happy Ending?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (endType == DialogResult.No)
            {
                MessageBox.Show("Find out Kaguya hime with Fuji right now!", "You're fighting for Happy Ending!");
            }
            else
            {
                MessageBox.Show("Well, you're right, thx for watching Netflix :)", "The End..:p");
            }
        }

        private void button_countKO_Click(object sender, EventArgs e)
        {
            Form_countKoHits countKo = new Form_countKoHits();
            countKo.Show();
        }

        private void button_callBy_Click(object sender, EventArgs e)
        {
            Form_M13_call f13 = new Form_M13_call();
            f13.Show();
        }
    }
}
