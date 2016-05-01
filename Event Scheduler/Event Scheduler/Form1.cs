using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Scheduler
{
    public partial class Form1 : Form
    {
        Scheduler Concierge;
        public Form1()
        {
            InitializeComponent();
            Concierge = new Scheduler();
        }

        private void addEventBTN_Click(object sender, EventArgs e)
        {
            string name = eventNameTXT.Text;
            DateTime startDate = startDatePicker.Value.Date;
            int start = (int)(startTimeNUD.Value*60 + startTimeMinuteNUD.Value);
            startDate = startDate.AddMinutes(start);

            //int duration = (int)(durationNUD.Value * 60 + durationMinuteNUD.Value);
            TimeSpan dur = new TimeSpan((int)durationNUD.Value, (int)durationMinuteNUD.Value, 0);
            //Activity newActivity = new Activity(name, start, duration);
            Activity newActivity = new Activity(name, startDate, dur);
            Concierge.addActivity(newActivity);
            activityTXT.AppendText(newActivity.toString()+ "\n");
            List<Activity> schedule = Concierge.createSchedule();
            scheduleTXT.Clear();
            for (int i = 0; i < schedule.Count; i++)
            {
                scheduleTXT.AppendText(schedule[i].toString() + "\n");
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            scheduleTXT.Clear();
            activityTXT.Clear();
            Concierge.clearActivities();
        }

    }
}
