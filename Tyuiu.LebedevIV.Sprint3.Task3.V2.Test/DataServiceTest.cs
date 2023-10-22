using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LebedevIV.Sprint3.Task3.V2.Lib;

namespace Tyuiu.LebedevIV.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "asdzzz vfvfzz v gthvz";
            char rpb = 'z';


            int res = ds.GetMaxCharCount(str, rpb);

            int wait = 3;

            Assert.AreEqual(wait, res);

        }
    }
}
