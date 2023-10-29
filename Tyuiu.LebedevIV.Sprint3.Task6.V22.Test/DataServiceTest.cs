using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint3.Task6.V22.Lib;

namespace Tyuiu.LebedevIV.Sprint3.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 31;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 55;

            Assert.AreEqual(wait, res);
        }
    }
}
