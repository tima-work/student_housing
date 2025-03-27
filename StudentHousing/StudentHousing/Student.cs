using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StudentHousing
{
    public class Student
    {
        [JsonProperty("name")]
        public string Name { get; private set; }
        [JsonProperty("email")]
        public string Email { get; private set; }
        [JsonProperty("password")]
        public string Password { get; private set; }
        [JsonProperty("description")]
        public string Description { get; private set; }
        [JsonProperty("roomNumber")]
        public int RoomNumber { get; private set; }

        public Student(string name, string email, string password, int roomNumber, string description)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.RoomNumber = roomNumber;
            this.Description = description;
        }

        public void Initialize(string name, string email, int roomNumber, string description)
        {
            this.Name = name;
            this.Email = email;
            this.RoomNumber = roomNumber;
            this.Description = description;
        }

        public Student() { }

        public bool CheckPassword(string password)
        {
            return (password == this.Password);
        }

        public string GetListBoxDescription()
        {
            return $"Room {this.RoomNumber}: {this.Name} - {this.Email}";
        }
    }
}
