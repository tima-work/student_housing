using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;

namespace StudentHousing
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public StudentManager()
        {
            //LoadStudentsFromFile();
            students = MainPageForm.LoadSmthFromFile<Student>("students.json");
        }

        public void RegisterStudent(string name, int roomNumber, string email, string password)
        {
            if (name == string.Empty)
                throw new Exception("Please, enter your name");
            if (roomNumber <= 0)
                throw new Exception("Roomnumber can not be lower than 1");
            if (email == string.Empty)
                throw new Exception("Please, enter your email");
            if (password == string.Empty)
                throw new Exception("Please, enter your password");
            if (email == "admin")
                throw new Exception("This email is already registered");
            foreach (Student student in students)
            {
                if (student.Email == email)
                {
                    throw new Exception("This email is already registered");
                }
            }
            students.Add(new Student(name, email, password, roomNumber, ""));
            MainPageForm.SaveSmthToFile<Student>("students.json", this.students);
            //SaveStudentsToFile();
        }

        public Student LoginStudent(string email, string password)
        {
            Student student_to_return = null;
            foreach (Student student in students)
            {
                if (student.Email == email && student.CheckPassword(password))
                {
                    student_to_return = student;
                    break;
                }
            }
            return student_to_return;
        }

        public Student[] GetStudents()
        {
            return students.ToArray();
        }

        public Student[] SearchByName(string name)
        {
            List<Student> searched_students = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Name.Contains(name))
                    searched_students.Add(student);
            }
            return searched_students.ToArray();
        }

        public Student[] SearchByRoom(int roomNumber)
        {
            List<Student> searched_students = new List<Student>();
            foreach (Student student in students)
            {
                if (student.RoomNumber == roomNumber)
                    searched_students.Add(student);
            }
            return searched_students.ToArray();
        }

        public Student SearchByEmail(string email)
        {
            //List<Student> searched_students = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Email.Contains(email))
                    return student;
            }
            //return searched_students.ToArray();
            return null;
        }

        public Student[] SearchManyByEmail(string email)
        {
            List<Student> searched_students = new List<Student>();
            foreach (Student student in students)
            {
                if (student.Email.Contains(email))
                    searched_students.Add(student);
            }
            return searched_students.ToArray();
        }

        public void ChangeStudentInfo(Student student, string name, string email, int roomNumber, string description)
        {
            if (email == "admin")
                throw new Exception("This email is already registered");
            foreach (Student student1 in this.students)
            {
                if (student1.Email == email && student1 != student)
                    throw new Exception("This email is already registered");
            }
            student.Initialize(name, email, roomNumber, description);
            MainPageForm.SaveSmthToFile<Student>("students.json", students);
        }

        public void LoadStudentsFromFile()
        {
            try
            {
                var jsonString = File.ReadAllText("students.json");
                students = JsonConvert.DeserializeObject<List<Student>>(jsonString);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); students = new List<Student>(); }
        }

        public void SaveStudentsToFile()
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(this.students);
            File.WriteAllText("students.json", jsonString);
        }


    }
}
