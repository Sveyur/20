using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        delegate double MyDelegate(double r);

        static void Main(string[] args)
        {
            Console.Write("Введите значения радиуса:");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = Metod1;
            double D = myDelegate(r);
            Console.WriteLine(Math.Round(D, 3));
            myDelegate = Metod2;
            double S = myDelegate(r);
            Console.WriteLine(Math.Round(S, 3));
            myDelegate = Metod3;
            double V = myDelegate(r);
            Console.WriteLine(Math.Round(V, 3));


            Console.ReadKey();
        }
        static double Metod1(double r)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Метод №1");
            Console.ResetColor();
            Console.Write("Длина окружности равна:");
            return 2 * Math.PI * r;
        }

        static double Metod2(double r)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Метод №2");
            Console.ResetColor();
            Console.Write("Площадь круга равна:");
            return Math.PI * Math.Pow(r, 2);
        }
        static double Metod3(double r)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Метод №3");
            Console.ResetColor();
            Console.Write("Объем шара равен:");
            return (3 * Math.PI * Math.Pow(r, 3) / 4);
        }
    }
}
