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
            Console.WriteLine("Введите два числа через enter. ");
            byte num1, num2;
            int otvetAND, otvetOR, otvetXOR;
            if ((byte.TryParse(Console.ReadLine(), out num1)) && (byte.TryParse(Console.ReadLine(), out num2)))
            {

                otvetAND = num1 & num2;
                Console.WriteLine("Побитовое И: {0}", otvetAND);
                otvetOR = num1 | num2;
                Console.WriteLine("Побитовое ИЛИ: {0}", otvetOR);
                otvetXOR = num1 ^ num2;
                Console.WriteLine("Побитовое исключающие ИЛИ: {0}", otvetXOR);
            }
            else { Console.WriteLine("Неверно введены данные."); }
            Console.ReadLine();

        }
    }
}
