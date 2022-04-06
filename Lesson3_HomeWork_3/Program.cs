using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork_3
{
    internal class Program
    {
        //вывод результата решения задачи на консоль
        static void PrintResult(int iVariant, string inStr, string outStr)
        {
            Console.WriteLine("Строка {0} в обратном порядке по варианту решения {1}: {2}",
                               inStr, iVariant, outStr);
        }

        //вариант решения № 1
        static string GetReverseString_Variant1(string inStr)
        {
            string outStr = "";
            for (int i = inStr.Length - 1; i >= 0; i--) outStr += inStr[i];
            return outStr;
        }

        //вариант решения № 2
        static string GetReverseString_Variant2(string inStr)
        {
            char[] v = inStr.ToCharArray(); //преобразование строки в массив символов  
            Array.Reverse(v);               //реверс массива символов  
            return (new string(v));
        }

        //вариант решения № 3
        static string GetReverseString_Variant3(string inStr)
        {
            char[] v = inStr.Reverse().ToArray();
            return (new string(v));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Урок 3, домашнее задание № 3");

            //входная строка
            string inStr = "Hello";

            //строка в обратном порядке - вариант 1
            PrintResult(1, inStr, GetReverseString_Variant1(inStr));

            //строка в обратном порядке - вариант 2
            PrintResult(2, inStr, GetReverseString_Variant2(inStr));

            //строка в обратном порядке - вариант 3
            PrintResult(3, inStr, GetReverseString_Variant3(inStr));

            //
            Console.ReadLine();
        }
    }
}
