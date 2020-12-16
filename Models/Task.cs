using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Task
    {

        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsDone { get; set; }
        public string ImageLogo { get; set; }

        public string Date { get; set; }

        public string dateStatus { get; set; }

        
}

    public class TaskManager {


        
            public static  List<Task> Tasks = new List<Task>() {
             new Task() { Id = 1, TaskName = "Task 1", IsDone = false, ImageLogo = "Assets/incomplete.png", Date = DateTime.Now.ToShortDateString(), dateStatus = "Due Date:"},
             new Task() { Id = 2, TaskName = "Task 2", IsDone = false, ImageLogo = "Assets/incomplete.png", Date = DateTime.Now.ToShortDateString(), dateStatus = "Due Date:" },
             new Task() { Id = 3, TaskName = "Task 3", IsDone = true, ImageLogo = "Assets/complete.png" , Date = DateTime.Now.ToShortDateString(), dateStatus = "Due Date:"},
             new Task() { Id = 4, TaskName = "Task 4", IsDone = true, ImageLogo = "Assets/complete.png", Date = DateTime.Now.ToShortDateString(), dateStatus = "Due Date:" }
            };




        public static void AddTask(string taskName, string taskDueDate) {
            Tasks.Add(new Task { Id = Tasks.Count + 1, TaskName = taskName, IsDone = false, ImageLogo = "Assets/incomplete.png", Date = taskDueDate, dateStatus = "Due Date:" });
        }

    
    }

   
}
