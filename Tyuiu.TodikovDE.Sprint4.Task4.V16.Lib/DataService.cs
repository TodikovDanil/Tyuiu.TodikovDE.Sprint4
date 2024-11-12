using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TodikovDE.Sprint4.Task4.V16.Lib
{
    public class DataService : ISprint4Task4V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int count;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            return matrix;


        }
    }
}
