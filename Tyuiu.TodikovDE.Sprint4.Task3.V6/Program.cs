using Tyuiu.TodikovDE.Sprint4.Task3.V6.Lib;
namespace Tyuiu.TodikovDE.Sprint4.Task3.V6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #4                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] {{8, 8, 3, 4, 5 },

                                        { 8, 6, 6, 4, 6 },

                                        { 3, 6, 5, 3, 4 },

                                        { 5, 6, 3, 7, 5 },

                                        { 7, 8, 5, 6, 6 }};
            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($" {mas2[i, j]} /t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas2);
            Console.WriteLine("Максимальное число в второй строке массива : " + res);
            Console.ReadKey();
        }
    }
}