using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Разработать структуру для решения линейного уравнения 0=kx+b. 
 * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
 * Для решения уравнения предусмотреть метод Root. 
 * Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.
 */


namespace Zadanie_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения 0=kx+b");
            Console.WriteLine("----------------------------------");
            try
            {
            Console.Write("Введите значение k: ");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");

                Urav urav = new Urav {k=k1,b=b1};
                Console.WriteLine();
                Console.WriteLine("Решение уравнения: Х={0}", urav.Root());
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка при вводе исходных данных.");
                Console.ReadKey();
            }

        }
    }

    struct Urav
    {
        public double k;
        public double b;
        public double Root()
        {
            double x = this.b / this.k;
            return x;
        }
    }
}
