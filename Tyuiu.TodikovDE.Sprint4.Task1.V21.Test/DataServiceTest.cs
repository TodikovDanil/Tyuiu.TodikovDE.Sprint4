using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TodikovDE.Sprint4.Task1.V21.Lib;
namespace Tyuiu.TodikovDE.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numArray = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };
            int res = ds.Calculate(numArray);
            int wait = 1769472;
            Assert.AreEqual(wait, res);
        }
    }
}