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
    public partial class Form_M19_array : Form
    {
        public Form_M19_array()
        {
            InitializeComponent();
        }

        private void button_trigArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int[6];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 4;
            arr[3] = 5;
            arr[4] = 1;
            arr[5] = 4;

            int index = 0;
            string msgResult = string.Empty;
            foreach (int i in arr)
            {
                msgResult += $"arr[{index}] => {i}\n";
                index++;
            }
            MessageBox.Show(msgResult);

            string msgResult2 = string.Empty;
            for (int i=0; i<arr.Length; i++)
            {
                msgResult2 += $"arr[{i}] => {arr[i]}\n";
            }
            MessageBox.Show(msgResult2);

            string msgResult3 = string.Empty;
            
            int[,] arr2d = new int[2,3] { { 1,1,4 },{ 5,1,4 } };
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    msgResult += $"{arr2d[i,j]}";
                }
            }
            MessageBox.Show("!!\n" + msgResult2);
        }

        private void button_testArray2_Click(object sender, EventArgs e)
        {
            Member[] members = new Member[2]
            { 
                new Member() { id = 0, Name = "John", Phone = "0987654321" },
                new Member() { id = 1, Name = "Cena", Phone = "0987654567" },
            };
            //members[0].id = 0;
            //members[0].Name = "John";
            //members[0].Phone = "0912345678";
            //members[1].id = 1;
            //members[1].Name = "Wick";
            //members[1].Phone = "026666666";

            string result = "";

            for (int i = 0; i < members.Length; ++i)
            {
                result += $"{members[i].id}, {members[i].Name}, {members[i].Phone}\n";
            }

            MessageBox.Show(result);
        }

        private void button_arrayRandom_Click(object sender, EventArgs e)
        {
            int[] resultArr = randArrayMethod(38);

            string result = "";
            foreach (int loop_item in resultArr)
            {
                result += loop_item + "\n";
            }
            MessageBox.Show(result);
        }

        int[] randArrayMethod(int array_length)
        {
            int[] arr = new int[array_length];

            Random r = new Random();
            for (int i = 0; i < array_length; i++)
            {
                arr[i] = r.Next(48763);
            }
            return arr;
        }
    }
}
