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
            int[,] mas2 = new int[5, 5] {{8, 8, 3, 4, 5 },

                                        { 8, 6, 6, 4, 6 },

                                        { 3, 6, 5, 3, 4 },

                                        { 5, 6, 3, 7, 5 },

                                        { 7, 8, 5, 6, 6 }};
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] {{8, 8, 3, 4, 5 },

                                        { 8, 6, 6, 4, 6 },

                                        { 3, 6, 5, 3, 4 },

                                        { 5, 6, 3, 7, 5 },

                                        { 7, 8, 5, 6, 6 }}; ;
            Assert.AreEqual(wait, res);
        }
    }
}