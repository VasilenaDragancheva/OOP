using System;
using System.Collections.Generic;
using Problem3.Interfaces;
using Problem3.Enum;

namespace Problem3.Models
{
   public class Project : IProject
    {
        private string name;
     
        private List<string> details;
   
        public Project(string name,DateTime startDate,ProjectState projectState, params string[] details)
        {
            this.Name = name;
            this.ProjectState = projectState;
            this.StartDate = startDate;
            this.details = new List<string>();
            this.details.AddRange(details);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Value can not be null!");
                }
                this.name = value;
            }
        }

        public DateTime StartDate { get; set; }


        public List<string> Details { 
            get
            {
                return this.details;
            }
        }

        public ProjectState ProjectState { get; set; }
        public override string ToString()
        {
            return string.Format("Project name:{0},is {1}", this.Name,this.ProjectState);
        }
    }
}
