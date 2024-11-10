using System.Security.Cryptography;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TodikovDE.Sprint4.Task0.V19.Lib
{
    public class DataService : ISprint4Task0V19
    {
        public int GetMultOddArrEl(int[] array)
        {
            int mult = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    mult = mult * array[i];
                }
            }
            return mult;
        }
    }
}
