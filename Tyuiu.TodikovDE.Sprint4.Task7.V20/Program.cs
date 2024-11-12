using System;
using Tyuiu.TodikovDE.Sprint4.Task7.V20.Lib;
namespace Tyuiu.TodikovDE.Sprint4.Task7.V20
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 3;
            int m = 5;
            int[,] mtrx = new int[n, m];

            string str = "357951248632587";

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Федрова Д. А. | АСОиУб-24-1";

            Console.Title = "Спринт #4 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #4                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #20                                                            *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Произвидение четных чисел: " + res);


        }
    }
}