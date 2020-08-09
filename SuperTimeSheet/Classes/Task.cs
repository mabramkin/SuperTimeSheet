using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTimeSheet.Classes
{
    public class TimeSheetTask
    {
        private string taskName;
        private string taskStringDate;
        private DateTime taskDate;
        private string taskPrefix;
        private string taskDuration;
        private string taskProject;

        public string TaskName { get => taskName; set => taskName = value; }
        public string TaskStringDate { get => taskStringDate; set => taskStringDate = value; }
        public string TaskDuration { get => taskDuration; set => taskDuration = value; }
        public string TaskPrefix { get => taskPrefix; set => taskPrefix = value; }
        public string TaskProject { get => taskProject; set => taskProject = value; }
        public DateTime TaskDate { get => taskDate; set => taskDate = value; }
    }
}
