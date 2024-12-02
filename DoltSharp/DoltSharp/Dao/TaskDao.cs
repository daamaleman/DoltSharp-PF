using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DoltSharp.Models;

namespace DoltSharp.Dao
{
    public class TaskDao
    {
        private List<Task> tasks;

        public TaskDao()
        {
            tasks = new List<Task>();
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public Task FindTaskById(int id)
        {
            return tasks.Find(task => task.TaskId == id);
        }

        public List<Task> FindTasksByProjectId(int taskId)
        {
            return tasks.FindAll(task => task.TaskId == taskId);
        }
        public void DeleteTaskById(int id)
        {
            var task = FindTaskById(id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }
        public void UpdateTask(int id, Task updatedTask)
        {
            int index = tasks.FindIndex(task => task.TaskId == id);

            if (index != -1)
            {
                tasks[index] = updatedTask;
            }
        }
    }

}
