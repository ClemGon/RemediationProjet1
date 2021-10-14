using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemediationProjet1;

namespace TestRemediationProjet1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var singleton1 = Singleton.GetInstance();
            
            var singleton2 = Singleton.GetInstance();

            Assert.AreEqual(singleton1, singleton2);
        }
    }
}
