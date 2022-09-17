using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника через enter. ");
            double a, b, c;
            
            if ((double.TryParse(Console.ReadLine(), out a)) && (double.TryParse(Console.ReadLine(), out b)) && (double.TryParse(Console.ReadLine(), out c)))
            {
                if ((a < b + c) && (b < a + c) && (c < b + a))
                {
                    double S, p = 0;
                    p = (a + b + c) / 2;

                    S = (p * (p - a) * (p - b) * (p - c));
                    double Otvet = Math.Sqrt(S);
                    Console.WriteLine("Площадь треугольника: {0}", Otvet);
                }
                else { Console.WriteLine("Треугольник не существует."); }
            }
            else { Console.WriteLine("Неверно введены данные."); }
            Console.ReadLine();

        }
    }
}
