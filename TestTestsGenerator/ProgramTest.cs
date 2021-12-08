using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTestClass
{
    [TestClass]
    public class TestClass
    {
        private int _age;

        [TestInitialize]
        public void SetUp()
        {
            _age = 32;
        }


        [TestMethod]
        public void getAgeTest()
        {
            Assert.AreEqual(_age, 32);
            Assert.Fail("autogenerated");
        }
    }
}