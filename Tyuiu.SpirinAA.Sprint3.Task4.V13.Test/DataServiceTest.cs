using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using Tyuiu.SpirinAA.Sprint3.Task4.V13.Lib;

namespace Tyuiu.SpirinAA.Sprint3.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 1.899;
            Assert.AreEqual(wait, res);
        }
    }
}
