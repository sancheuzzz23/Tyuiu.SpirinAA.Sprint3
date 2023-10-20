using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint3.Task3.V3.Lib;

namespace Tyuiu.SpirinAA.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string input1 = "cvbmzff";
            string input2 = "orffgtrr";
            string input3 = "dkfvfffdr";


            string str = input1 + input2 + input3;
            char chr = 'f';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
