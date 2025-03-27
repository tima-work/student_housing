using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace StudentHousing
{
    public class Announcement
    {
        [JsonProperty("Title")]
        public string Title { get; private set; }
        [JsonProperty("Description")]
        public string Description { get; private set; }
        [JsonProperty("Date")]
        public DateTime Date { get; private set; }
        [JsonProperty("StudentEmail")]
        public string StudentEmail { get; private set; }

        public Announcement(string title, string description, DateTime creation_date, string studentEmail)
        {
            this.Title = title;
            this.Description = description;
            this.Date = creation_date;
            this.StudentEmail = studentEmail;
        }
        public string GetInfo()
        {
            if (this.StudentEmail != null) 
            {
                if (StudentEmail == "admin")
                    return $"Admin - {Title}";
                Student var = MainPageForm.studentManager.SearchByEmail(StudentEmail);
                return $"{var.Name}({var.RoomNumber}) - {Title}";
            }
            return "Hello";
        }

        public string GetAllInfo()
        {
            return $"{Title} - {Date} \n{Description}";
        }
    }
}
