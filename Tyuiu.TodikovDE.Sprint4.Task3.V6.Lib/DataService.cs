using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TodikovDE.Sprint4.Task3.V6.Lib
{
    public class DataService : ISprint4Task3V6
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int a = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 1 )
                    {
                        a = Math.Max(a,array[i, j]);
                    }
                }
            }
            return a;


        }
    }
}
