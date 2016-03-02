using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestMethod2()
        {
            throw new Exception("möööp");
        }
    }
}
