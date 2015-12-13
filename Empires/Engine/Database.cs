using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Engine.Interfaces;
using Empires.Models.Interfaces;

namespace Empires.Engine
{
   public class Database:IDatabase
   {
       private List<IBuilding> buildings; 
       private List<IUnit> units;
       private List<IResource> resources;

       public Database()
       {
           this.buildings=new List<IBuilding>();
           this.units=new List<IUnit>();
           this.resources=new List<IResource>();
       }

       public void AddBuilding(IBuilding building)
       {
           this.buildings.Add(building);
       }
       public List<IResource> Resources { get { return this.resources; } }
       public List<IBuilding> Buildings { get { return this.buildings; } }
       public List<IUnit> Units { get { return this.units; } } 
   }
}
