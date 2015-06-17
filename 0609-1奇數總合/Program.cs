using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4_odd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數, 計算奇數累加總合:");
            int i = 1;
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("奇數有 :");
            int total = 0;
            for (i = 1; i <= j; i = i + 2)
            {
                Console.Write("  {0}", i);
                total = total + i;
            }
            Console.WriteLine();
            Console.WriteLine("奇數累加為{0}", total);
        }
    }
}