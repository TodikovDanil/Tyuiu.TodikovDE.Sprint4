using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint4.Task5.V16.Lib;
namespace Tyuiu.TodikovDE.Sprint4.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -6, 1, 1, 1, -3 }, { -6, -6, -4, -4, 1 }, { -3, -6, -2, -2, 1 }, { -2, -4, -4, -3, 1 }, { 1, -3, -3, -2, -1 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { -6, 1, 1, 1, -3}, { -6, -6, -4, -4, 1 }, { -3, -6, -2, -2, 1 }, { -2, -4, -4, -3, 1 }, { 1, -3, -3, -2, -1 } } ;
            Assert.AreEqual(wait, res);
        }
    }
}