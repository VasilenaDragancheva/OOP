using System;
using System.Linq;
using System.Reflection;
using Empires.Models.Interfaces;

namespace Empires.Engine.Factories
{
    public static class BuildingFactory
    {
        public static IBuilding CreateBuilding(string name)
        {
            var buildingType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(type => type.Name == name);
            if (buildingType == null)
            {
                throw new ArgumentNullException();
            }
            var building = Activator.CreateInstance(buildingType) as IBuilding;
            return building;
        }
    }
}
