using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem3.Enum;
using Problem3.Interfaces;

namespace Problem3.Models
{
   public class Developer:Employee,IDeveloper

    {
        private List<Project> projects;
        public Developer(string firstName, string lastName,int id, decimal salary,Department department, params Project[] projects)
            :base(firstName,lastName,id,salary,department)
        {
            this.projects = new List<Project>();
            this.projects.AddRange(projects);
        }

        public IEnumerable<Project> Projects
        {
            get { return this.projects; }
        }

        public void CloseProject(Project project)
        {
            project.ProjectState = ProjectState.Closed;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} works on:",base.ToString());
            if (this.Projects.Count() == 0)
            {
                result.Append("No projects!");
            }
            else
            {
                foreach (Project proj in this.Projects)
                {
                    result.AppendFormat("{0}\n", proj.Name);
                }
            }
            return result.ToString();
        }
    }
}
