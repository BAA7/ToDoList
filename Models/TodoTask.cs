using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Data.TaskPriority Priority { get; set; }
        public DateTime Deadline { get; set; }
        public Data.TaskState State { get; set; }
        public TodoTask(string name, Data.TaskPriority priority, DateTime deadline)
        {
            Name = name;
            Priority = priority;
            Deadline = deadline;
            State = Data.TaskState.Todo;
        }
    }
}
