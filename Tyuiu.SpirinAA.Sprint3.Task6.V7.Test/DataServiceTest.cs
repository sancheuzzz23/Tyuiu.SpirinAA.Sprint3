using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint3.Task6.V7.Lib;

namespace Tyuiu.SpirinAA.Sprint3.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 344;

            Assert.AreEqual(wait, res);
        }
    }
}
