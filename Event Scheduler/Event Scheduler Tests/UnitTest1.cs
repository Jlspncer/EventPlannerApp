using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void GetEndTimeTest()
        {
            Activity test = new Activity("test", 7, 50);
            Assert.AreEqual(57, test.getEndTime());
        }

        [TestMethod]
        public void CreateScheduleTest()
        {
            Scheduler test = new Scheduler();
            test.addActivity(new Activity("A", 1, 3));
            test.addActivity(new Activity("B", 2, 5));
            test.addActivity(new Activity("C", 4, 2));
            test.addActivity(new Activity("D", 7, 1));
            test.addActivity(new Activity("E", 9, 3));
            test.addActivity(new Activity("F", 9, 2));
            test.addActivity(new Activity("G", 9, 1));
            test.addActivity(new Activity("H", 10, 10));
            List<Activity> output = test.createSchedule();
            string result = "";
            foreach (Activity a in output)
                result += a.getName();
            Assert.AreEqual(result, "ACDGH");
        }
    }
}
