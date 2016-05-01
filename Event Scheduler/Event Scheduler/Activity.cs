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
        DateTime start;
        TimeSpan dur;
        public Activity(string name, int startTime, int duration)
        {
            this.name = name;
            this.startTime = startTime;
            this.duration = duration;
        }
        public Activity(string name, DateTime start, TimeSpan dur)
        {
            this.name = name;
            this.start = start;
            this.dur = dur;
        }
        public string getName() { return name; }
        public string toString()
        {
            DateTime endTime = getEndTime();
            int startHour = startTime / 60;
            int startMinute = startTime % 60;
            /*int endHour = endTime / 60;
            int endMinute = endTime % 60;*/
            string output = "";

            /*output += name + ": " + startHour +":";
            if (startMinute < 10)
                output += "0";
            output += startMinute + " to " + endHour + ":";
            if (endMinute < 10)
                output += "0";
            output += endMinute;*/
            output += name + ": " + start.ToShortDateString() + " " + start.ToShortTimeString() + 
                " to " + endTime.ToShortDateString() + " " + endTime.ToShortTimeString();

            return output;
        }
        public int getStartTime() { return startTime; }
        public int getDuration() { return duration; }
        public DateTime getStart() { return start; }
        public TimeSpan getDur() { return dur; }
        public DateTime getEndTime()
        {
            //return startTime + duration;
            return start.Add(dur);
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
                    if (x.getEndTime().CompareTo(y.getEndTime()) < 0)
                        return -1;
                    else if (x.getEndTime().CompareTo(y.getEndTime()) > 0)
                        return 1;
                    else
                        return 0;
                }
            }
        }
    }
}
