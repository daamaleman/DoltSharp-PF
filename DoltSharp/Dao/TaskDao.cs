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

        // Devuelve todas las tareas
        public List<Task> GetTasks()
        {
            return tasks;
        }

        // Agrega una nueva tarea a la lista
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        // Busca una tarea por ID
        public Task FindTaskById(int id)
        {
            return tasks.Find(task => task.TaskId == id);
        }

        // Busca tareas por ID de proyecto
        public List<Task> FindTasksByProjectId(int taskId)
        {
            return tasks.FindAll(task => task.TaskId == taskId);
        }

        // Elimina una tarea por ID
        public void DeleteTaskById(int id)
        {
            var task = FindTaskById(id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }

        // Actualiza una tarea
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
