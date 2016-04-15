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
        int startTime;
        int duration;
        public Activity(string name, int startTime, int duration)
        {
            this.name = name;
            this.startTime = startTime;
            this.duration = duration;
        }
        public string getName() { return name; }
        public int getStartTime() { return startTime; }
        public int getDuration() { return duration; }
        public int getEndTime()
        {
            return startTime + duration;
        }
    }
}
