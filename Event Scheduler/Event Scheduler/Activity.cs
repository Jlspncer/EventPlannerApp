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
        public string toString() { return name + ": " + startTime + " to " + getEndTime(); }
        public int getStartTime() { return startTime; }
        public int getDuration() { return duration; }
        public int getEndTime()
        {
            return startTime + duration;
        }
        public static int compareActivitiesByEndTime(Activity x, Activity y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    if (x.getEndTime() < y.getEndTime())
                        return -1;
                    else if (x.getEndTime() > y.getEndTime())
                        return 1;
                    else
                        return 0;
                }
            }
        }
    }
}
