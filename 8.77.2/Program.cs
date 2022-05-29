using System;

namespace Main
{
    //Гребенюк А. 21-ИСП-2, 8-я лабораторная, 2-й вариант. 
    internal class Program
    {

        public static double a;
        public static double b; 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа вычисляет корень линейного уравнения(ax + b = 0).");
            while (a == 0)
            {
                Varuables();
            }
            Console.WriteLine(Result(a, b));
        }
        static void Varuables()
        {
            try
            {
                Console.WriteLine("Введите значение a: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение b: ");
                b = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Нет корней, введённые числа слишком большие или неверный формат ввода.");
            }
        }
        static string Result(double a, double b)
        {
            if (b != 0)
            {
                try
                {
                    if (-(b / a) < int.MaxValue && -(b / a) > int.MinValue)
                    {
                        return Convert.ToString(-(b/a));
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch
                {
                    return "Полученный корень слишком большой";
                }
            }
            else
            {
                return "Корнем является любое число";
            }
        }
    }
}