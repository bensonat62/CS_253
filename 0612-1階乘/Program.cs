using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example03_階乘01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 1;
            long sum = 1;
            Console.Write("請輸入階乘(Factorial)數字,不大於20: ");
            int j = int.Parse(Console.ReadLine());
            do
            {
                if (j > 20)
                {
                    Console.Write("重新輸入數字不大於20 ");
                    j = int.Parse(Console.ReadLine());
                }
            } while (j > 20);

            for (i = 1; i <= j; i++)
            {
                Console.Write("{0}!=", i);
                sum = sum * i;
                Console.WriteLine(sum);
            }
        }
    }
}