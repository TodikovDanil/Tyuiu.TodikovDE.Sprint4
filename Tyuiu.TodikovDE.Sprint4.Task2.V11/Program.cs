using Tyuiu.TodikovDE.Sprint4.Task2.V11.Lib;
namespace Tyuiu.TodikovDE.Sprint4.Task2.V11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #4                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #11                                                            *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("Введите количество элемнтов массив: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numArray = new int[len];
            for (int i = 0; i <= len -1; i++)
            {
                numArray[i] = rnd.Next(3,9);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numArray[i] + "/t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(numArray));
            Console.ReadKey();
        }
    }
}