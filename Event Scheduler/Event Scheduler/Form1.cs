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
            int start = (int)startTimeNUD.Value;
            int duration = (int)durationNUD.Value;
            Activity newActivity = new Activity(name, start, duration);
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
