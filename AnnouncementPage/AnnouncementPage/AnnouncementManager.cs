using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnouncementPage
{
    internal class AnnouncementManager
    {
        private List<Announcement> announcements = new List<Announcement>();

        public void AddAnnouncement(string title, string description)
        {
            Announcement newAnnouncement = new Announcement(title, description);
            announcements.Add(newAnnouncement);
        }

        public Announcement[] GetAnnouncements()
        {
            return announcements.ToArray();
        }

        public Announcement this[int index]
        {
            get
            {
                if (index >= 0 && index < announcements.Count)
                {
                    return announcements[index];
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
