using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0605_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShowMessage();
            string name = GetName();
            string sex = GetSex();
            Console.WriteLine(" ");
            PrintHello(name);
            PrintGender(sex);
            Console.WriteLine(" ");
        }

        public static void ShowMessage()
        {
            Console.WriteLine(" 猜猜我是帥哥或是美女  ? ");
            Console.WriteLine("=========================");
        }

        public static string GetName()
        {
            Console.Write("請輸入性名 : ");
            return Console.ReadLine();
        }

        public static string GetSex()
        {
            Console.Write("性別 (M/F) : ");
            return Console.ReadLine();
        }

        public static void PrintHello(string name)
        {
            Console.Write("{0}你好....", name);
        }

        public static void PrintGender(string sex)
        {
            if (sex == "M" || sex == "m")
            {
                Console.WriteLine(",哈~你是個帥哥", sex);
            }
            else
            {
                Console.WriteLine(",嗯~你是個美女", sex);
            }
        }
    }
}