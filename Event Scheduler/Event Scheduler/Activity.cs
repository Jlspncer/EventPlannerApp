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
        public string toString()
        {
            int endTime = getEndTime();
            int startHour = startTime / 60;
            int startMinute = startTime % 60;
            int endHour = endTime / 60;
            int endMinute = endTime % 60;
            string output = "";

            output += name + ": " + startHour +":";
            if (startMinute < 10)
                output += "0";
            output += startMinute + " to " + endHour + ":";
            if (endMinute < 10)
                output += "0";
            output += endMinute;

            return output;
        }
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
