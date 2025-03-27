using StudentHousing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class ComplaintManager
    {
        private List<Complaint> complaints = new List<Complaint>(); 
        
        public ComplaintManager()
        {
            complaints = MainPageForm.LoadSmthFromFile<Complaint>("complaints.json");
        }
        
        
        public void AddComplaint(DateTime date, ComplaintType complaint, string description)
        {
            if (description == string.Empty)
                throw new Exception("You haven't entered description");
            Complaint newComplaint = new Complaint(date, complaint, description);
            complaints.Add(newComplaint);
            MainPageForm.SaveSmthToFile<Complaint>("complaints.json", complaints);
        }

        public void RemoveComplaint(Complaint complaint)
        {
            if (complaint == null)
                throw new ArgumentNullException(nameof(complaint), "Complaint cannot be null.");

            complaints.Remove(complaint);
            MainPageForm.SaveSmthToFile<Complaint>("complaints.json", complaints);
        }


        public Complaint[] GetComplaints()
        {
            return complaints.ToArray();
        }
    }

}

