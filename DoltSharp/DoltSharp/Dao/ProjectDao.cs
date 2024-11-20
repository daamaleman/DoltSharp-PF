using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoltSharp.Models;

namespace DoltSharp.Dao
{
    internal class ProjectDao
    {
        private List<Project> projects;

        public ProjectDao()
        {
            projects = new List<Project>();
        }

        public List<Project> GetProjects()
        {
            return projects;
        }

        public void AddProject(Project project)
        {
            projects.Add(project);
        }

        public Project FindProjectById(int id)
        {
            return projects.Find(proj => proj.ProjectId == id);
        }

        public void DeleteProjectById(int id)
        {
            var project = FindProjectById(id);
            if (project != null)
            {
                projects.Remove(project);
            }
        }

        public void UpdateProject(int id, Project updatedProject)
        {
            int index = projects.FindIndex(proj => proj.ProjectId == id);

            if (index != -1)
            {
                projects[index] = updatedProject;
            }
        }
    }
}
