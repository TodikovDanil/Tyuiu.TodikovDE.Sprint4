using Tyuiu.TodikovDE.Sprint4.Task6.V3.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Tyuiu.TodikovDE.Sprint4.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var moth = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            int res = ds.Calculate(moth);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}