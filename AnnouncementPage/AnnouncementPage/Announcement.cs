using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementPage
{
    internal class Announcement
    {
        private string title;
        private string description;
        private DateTime date;

        public Announcement(string title, string description)
        {
            this.title = title;
            this.description = description;
            this.date = DateTime.Now;
        }

        public string GetInfo()
        {
            return $"{title} - {date}";
        }

        public string GetAllInfo()
        {
            return $"{title} - {date} \n{description}";
        }
    }
}
