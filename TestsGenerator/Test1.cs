using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace MyTestClass
{
    [TestClass]
    public class PersonTest
    {
        Person testObject;
        [TestMethod]
        public void getAgeTest()
        {
            var actual = testObject.getAge();
            var expected = 0;
            Assert.AreEqual(actual, expected);
            Assert.Fail("autogenerated");
        }
    }
}