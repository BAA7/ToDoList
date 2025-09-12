using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<TodoTask> TodoTasks { get; set; }
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todolist.db");
        }

        public TodoTask UpdateTaskState(int id)
        {
            TodoTask task = Find<TodoTask>(id);
            if (task == null)
            {
                return null;
            }
            switch (task.State)
            {
                case Data.TaskState.Todo:
                    task.State = Data.TaskState.Active;
                    break;
                case Data.TaskState.Active:
                    task.State = Data.TaskState.Completed;
                    break;
                default:
                    Remove(task);
                    SaveChanges();
                    return null;
            }
            SaveChanges();
            return task;
        }
    }
}
