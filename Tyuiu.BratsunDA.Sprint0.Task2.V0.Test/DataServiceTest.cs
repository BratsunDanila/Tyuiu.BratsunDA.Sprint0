using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BratsunDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Данила";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Данила", res);
        }
    }
}
