using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Event_Scheduler;

namespace Event_Scheduler_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActivityConstructorTest()
        {
            Activity test = new Activity("test", 0, 50);
            Assert.AreEqual("test", test.getName());
            Assert.AreEqual(0, test.getStartTime());
            Assert.AreEqual(50, test.getDuration());
        }
        public void GetEndTimeTest()
        {
            Activity test = new Activity("test", 7, 50);
            Assert.AreEqual(57, test.getEndTime());
        }

    }
}
