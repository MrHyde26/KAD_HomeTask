using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAD_HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            int xl;
            xl = 2;
            Console.WriteLine(xl);

            //Задание 2

            string str1;
            Console.WriteLine("Ваше имя?");
            str1 = Console.ReadLine();
            string str2="Привет " + str1;
            Console.WriteLine(str2);
        }
    }
}
