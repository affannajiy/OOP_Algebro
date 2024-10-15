using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Algebro_HR_Management_Website
{
    internal class TimeTrackingList
    {
        public int totalHour { get; set;}
        public List<TimeTracking> timeTrackings;

        public TimeTrackingList()
        {
          timeTrackings = new List<TimeTracking>();
        }

        public void addTimeTracking(TimeTracking timeTracking)
        {
            timeTrackings.Add(timeTracking);
        }

        public void removeTimeTracking(TimeTracking timeTracking)
        {
            timeTrackings.Remove(timeTracking);
        }

        public void display()
        {
          foreach (TimeTracking timeTracking in timeTrackings)
          {
              Console.WriteLine("Start Time: " + timeTracking.startTime);
              Console.WriteLine("End Time: " + timeTracking.endTime);
          }
        }

        public void totalHourList ()
        {

        }
    }

    
}
