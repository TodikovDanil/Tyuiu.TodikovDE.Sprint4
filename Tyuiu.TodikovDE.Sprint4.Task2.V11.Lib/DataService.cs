﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.TodikovDE.Sprint4.Task2.V11.Lib
{
    public class DataService : ISprint4Task2V11
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0 && array[i] >= 3 && array[i] <= 8)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
