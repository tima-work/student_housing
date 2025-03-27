using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace StudentHousing
{
    public class AnnouncementManager
    {
        private List<Announcement> announcements = new List<Announcement>();

        public AnnouncementManager() 
        {
            announcements = MainPageForm.LoadSmthFromFile<Announcement>("announcements.json");
        }

        public Announcement AddAnnouncement(string title, string description, string studentEmail)
        {   
            Announcement newAnnouncement = new Announcement(title, description, DateTime.Now, studentEmail);
            announcements.Add(newAnnouncement);
            MainPageForm.SaveSmthToFile<Announcement>("announcements.json", announcements);
            return newAnnouncement;
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
