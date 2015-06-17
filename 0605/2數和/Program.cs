using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0605_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShowMessage();
            String num1 = GetNum1();
            String num2 = GetNum2();
            String num3 = GetNum3();
            String num4 = GetNum4();

            int a = int.Parse(num1);
            int b = int.Parse(num2);
            Console.Write("前2位數合計 : ");
            Console.WriteLine(a + b);

            int c = int.Parse(num3);
            int d = int.Parse(num4);
            Console.Write("後2位數合計 : ");
            Console.WriteLine(c + d);

            Console.Write("全部合計 : ");
            Console.WriteLine(a + b + c + d);
        }

        public static void ShowMessage()
        {
            Console.WriteLine("    請輸入4個數字  ?  ");
            Console.WriteLine("======================");
        }

        public static string GetNum1()
        {
            Console.Write("請輸入數字1 : ");
            return Console.ReadLine();
        }

        public static string GetNum2()
        {
            Console.Write("請輸入數字2 : ");
            return Console.ReadLine();
        }

        public static string GetNum3()
        {
            Console.Write("請輸入數字3 : ");
            return Console.ReadLine();
        }

        public static string GetNum4()
        {
            Console.Write("請輸入數字4 : ");
            return Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            //a = int.Parse(num1);
            //b = int.Parse(num2);
            return a + b;
        }
    }
}