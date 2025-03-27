using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();

        public TaskManager() 
        {
            tasks = Tasks.LoadSmthFromFile<Task>("tasks.json");
        }

        public void AddTask(string taskName, DateTime deadline, string assignedAttendee)
        {
            Task task = new Task(taskName, deadline, assignedAttendee);
            tasks.Add(task);
            Tasks.SaveSmthToFile("tasks.json", tasks);
        }

        public Task[] GetAllTasks()
        {
            return tasks.ToArray();
        }

        public Task[] GetMineTasks(string student)
        {
            //string currentUser = "current_user@example.com";
            List<Task> found_tasks = new List<Task>();

            foreach (Task task in tasks)
            {
                if (task.Assignedattendee == student)
                    found_tasks.Add(task);
            }

            return found_tasks.Where(task => !task.IsFinished).ToArray();
        }

        public void FinishTask(string fullTask)
        {
            Task task = tasks.FirstOrDefault(t => t.GetFullTask() == fullTask);

            if (task != null)
            {
                task.IsFinished = true;
            }
            Tasks.SaveSmthToFile("tasks.json", tasks);
        }

        public bool SameNameTasks(string name)
        {
            foreach (Task task in tasks)
            {
                if (task.TaskName == name)
                    return true;
            }
            return false;
        }
    }
}
