using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public static class Data
    {
        public enum TaskState
        {
            Todo,
            Active,
            Completed,
            Removed
        }
        public enum TaskPriority
        {
            urgent,
            necessary,
            unnecessary
        }
        public static Dictionary<TaskPriority, Color> PriorityColors = new Dictionary<TaskPriority, Color>
        {
            {TaskPriority.urgent, Color.Red},
            {TaskPriority.necessary, Color.Yellow },
            {TaskPriority.unnecessary, Color.LightGray },
        };
    }
}
