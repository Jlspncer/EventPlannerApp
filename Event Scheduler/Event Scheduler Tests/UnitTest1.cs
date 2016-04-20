using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Event_Scheduler;

namespace Event_Scheduler_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //Activity Tests
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
        public void CompareByEndTimeTest()
        {
            Activity w = new Activity("W", 4, 5); //  9
            Activity x = new Activity("X", 3, 7); // 10
            Activity y = new Activity("Y", 2, 7); //  9
            Activity z = new Activity("Z", 5, 3); //  8
            Assert.IsTrue(Activity.compareActivitiesByEndTime(w, x) < 0);
            Assert.IsTrue(Activity.compareActivitiesByEndTime(w, y) == 0);
            Assert.IsTrue(Activity.compareActivitiesByEndTime(w, z) > 0);
        }


        //Scheduler Tests
        [TestMethod]
        public void AddActivityTest()
        {
            Scheduler test = new Scheduler();
            Assert.AreEqual(0, test.totalActivityCount());
            test.addActivity(new Activity("A", 1, 3));
            Assert.AreEqual(1, test.totalActivityCount());
        }

        [TestMethod]
        public void CreateScheduleTest()
        {
            Scheduler test = new Scheduler();
            test.addActivity(new Activity("A", 1, 3));  //  4
            test.addActivity(new Activity("B", 2, 5));  //  7
            test.addActivity(new Activity("C", 4, 2));  //  6
            test.addActivity(new Activity("D", 7, 1));  //  8
            test.addActivity(new Activity("E", 9, 3));  // 12
            test.addActivity(new Activity("F", 9, 2));  // 11
            test.addActivity(new Activity("G", 9, 1));  // 10
            test.addActivity(new Activity("H", 10, 10));// 20
            List<Activity> output = test.createSchedule();
            string result = "";
            foreach (Activity a in output)
                result += a.getName();
            Assert.AreEqual("ACDGH", result);
        }

        [TestMethod]
        public void SortActivitiesTest()
        {
            Scheduler test = new Scheduler();
            test.addActivity(new Activity("A", 1, 3));  //  4
            test.addActivity(new Activity("B", 2, 5));  //  7
            test.addActivity(new Activity("C", 4, 2));  //  6
            test.addActivity(new Activity("D", 7, 1));  //  8
            test.addActivity(new Activity("E", 9, 3));  // 12
            test.addActivity(new Activity("F", 9, 2));  // 11
            test.addActivity(new Activity("G", 9, 1));  // 10
            test.addActivity(new Activity("H", 10, 10));// 20
            List<Activity> sorted = test.sortActivities();
            string result = "";
            foreach (Activity a in sorted)
                result += a.getName();
            Assert.AreEqual("ACBDGFEH", result);
        }

        [TestMethod]
        public void ClearActivitiesTest()
        {
            Scheduler test = new Scheduler();
            test.addActivity(new Activity("A", 1, 3));  //  4
            test.addActivity(new Activity("B", 2, 5));  //  7
            test.addActivity(new Activity("C", 4, 2));  //  6
            test.addActivity(new Activity("D", 7, 1));  //  8
            test.addActivity(new Activity("E", 9, 3));  // 12
            test.addActivity(new Activity("F", 9, 2));  // 11
            test.addActivity(new Activity("G", 9, 1));  // 10
            test.addActivity(new Activity("H", 10, 10));// 20
            test.clearActivities();
            Assert.AreEqual(0, test.totalActivityCount());

        }
    }
}
