using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KasenovAE.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            var res = DataService.Calc(10, 10, 10);
            Assert.AreEqual(150, res);
        }
    }
}
