using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Engine.Interfaces
{
    public interface IDatabase
    {
        void AddBuilding(IBuilding building);
        List<IResource> Resources { get; }
        List<IBuilding> Buildings { get; }
        List<IUnit> Units { get; } 
    }
}
