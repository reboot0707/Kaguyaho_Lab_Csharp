using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaguyaho_Lab_Form;

namespace Kaguyaho_Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name:");
            string your_name = Console.ReadLine();
            Console.WriteLine("Kaguyaho!!! " + your_name + " dayo~");

            Class_Tsukiyomi tsuki = new Class_Tsukiyomi();
            //tsuki.Method_Tsukiyomi_05();
            tsuki.Method_Tsukiyomi_06();
        }
    }
}
