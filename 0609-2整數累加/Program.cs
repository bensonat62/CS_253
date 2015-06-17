using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數, 計算累加總合:");
            int i = 1;
            int j = int.Parse(Console.ReadLine());
            int total = 0;
            for (i = 1; i <= j; i++)
            {
                total = total + i;
                Console.Write("  {0}", total);
            }
            Console.WriteLine();
        }
    }
}