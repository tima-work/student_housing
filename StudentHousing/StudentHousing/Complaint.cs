using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class Complaint
    {
        [JsonProperty("Date")]
        public DateTime Date { get; private set; }
        [JsonProperty("complaintType")]
        public ComplaintType complaintType { get; private set; }
        [JsonProperty("Decription")]
        public string Description { get; private set; }
        //private Student student;


        public Complaint(DateTime date, ComplaintType complaintType, string description)
        {
            this.Date = date;
            this.complaintType = complaintType;            
            this.Description = description;
            //this.student = student;
        }

        public string GetInfo()
        {
            return $"{complaintType.ToString()[0] + complaintType.ToString().ToLowerInvariant().Substring(1)}(on {Date.ToString("dd.MM.yyyy")} at {Date.ToString("HH:mm")}): \"{Description}\""; 
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }


    public enum ComplaintType
    {
        HOUSE,
        ROOMMATE
    }
}
