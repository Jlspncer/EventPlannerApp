using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Scheduler
{
    public class Activity
    {
        string name;
        double startTime;
        double duration;
        public Activity(string name, double startTime, double duration)
        {
            this.name = name;
            this.startTime = startTime;
            this.duration = duration;
        }
        public string getName() { return name; }
        public double getStartTime() { return startTime; }
        public double getDuration() { return duration; }
        public double getEndTime()
        {
            return 0;
        }
    }
}
