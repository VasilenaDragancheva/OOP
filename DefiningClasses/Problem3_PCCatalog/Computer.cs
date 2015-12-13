using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_PCCatalog
{
   public class Computer
    {
        private string name;
        private List<Component> components;
        

        public Computer(string name,params Component[] components)
        {
            this.Name = name;
            this.components = new List<Component>();
            this.AddCompoments(components); 
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
                    throw new ArgumentNullException("PC name can not be null");
                }
                this.name = value;
            }
        }
   
        public IEnumerable<Component> Components
        {
            get
            {
                return this.components;  
            }
        }
        public decimal Price
        {
            get
            {
                decimal price = components.Sum(comp => comp.Price);
                return price;
            }
        }
        private void AddCompoments(params  Component[] components)
        {
            if (components.Length == 0)
            {
                throw new ArgumentException("Every computer should have parameters");
            }
            this.components.AddRange(components);
        }
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("PC name\n", this.Name);
            foreach (Component component in this.Components)
            {
                toString.AppendFormat("{0,10}|{1}\n", component.Name, component.Price);
            }
            toString.AppendFormat("PC configuration costs {0} BGN", this.Price);
            return toString.ToString();
        }
    }
}
