using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DependencyGraph dg = new DependencyGraph();
            dg.AddDependency("a", "b");
            Assert.IsTrue(dg.HasDependents("b"));
        }
    }
}
