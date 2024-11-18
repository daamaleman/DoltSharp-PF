using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoltSharp.Dao
{
    internal class TaskDao
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
            return tasks.Find(task => task.ID == id);
        }

        // Busca tareas por ID de proyecto
        public List<Task> FindTasksByProjectId(int projectId)
        {
            return tasks.FindAll(task => task.projectID == projectId);
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
            int index = tasks.FindIndex(task => task.ID == id);

            if (index != -1)
            {
                tasks[index] = updatedTask;
            }
        }
}
