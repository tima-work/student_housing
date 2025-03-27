using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class Task
    {
        [JsonProperty("TaskName")]
        public string TaskName { get; set; }
        [JsonProperty("Deadline")]
        public DateTime Deadline { get; set; }
        [JsonProperty("Assignedattendee")]
        public string Assignedattendee { get; set; }
        [JsonProperty("IsFinished")]
        public bool IsFinished { get; internal set; }

        public Task(string taskName, DateTime deadline, string assignedAttendee)
        {
            TaskName = taskName;
            Deadline = deadline;
            Assignedattendee = assignedAttendee;
            IsFinished = false;
        }

        public string GetFullTask()
        {
            string var = "done";
            if (!IsFinished)
                var = "not " + var;
            if (MainPageForm.studentManager.SearchByEmail(Assignedattendee) != null)
                return $"{MainPageForm.studentManager.SearchByEmail(Assignedattendee).Name} - {TaskName} (till {Deadline.ToString("dd.MM.yyyy")}): {var}";
            return "hello";
        }
    }
}
