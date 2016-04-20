using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Scheduler
{
    public class Scheduler
    {
        List<Activity> allActivities;

        public Scheduler()
        {
            allActivities = new List<Activity>();
        }

        public void addActivity(Activity a)
        {
            allActivities.Add(a);
        }

        public List<Activity> createSchedule()
        {
            if (totalActivityCount() == 0)
                return null;

            List<Activity> input = sortActivities();
            List<Activity> output = new List<Activity>();
            output.Add(input[0]);
            int endTime = input[0].getEndTime();
            for(int i = 1; i < input.Count; i++)
            {
                if(input[i].getStartTime() >= endTime)
                {
                    output.Add(input[i]);
                    endTime = input[i].getEndTime();
                }
            }
            return output;
        }
        public List<Activity> sortActivities()
        {
            List<Activity> output = new List<Activity>();
            foreach (Activity a in allActivities)
                output.Add(a);
            output.Sort(Activity.compareActivitiesByEndTime);
            return output;
        }

        public int totalActivityCount()
        {
            return allActivities.Count;
        }

        public void clearActivities()
        {
            allActivities.Clear();
        }
    }
}
