using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Attributes;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Engine
{
    public static class EstateFactory
    {
        public static IEstate CreatEstate(string estateName)
        {
            var estateType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(type => type.CustomAttributes.Any(a => a.AttributeType == typeof (EstateAttribute)) &&
                                        type.Name == estateName);

            if (estateType == null)
            {
                throw new ArgumentNullException(estateName, "Unknown estate");
            }
            var structure = Activator.CreateInstance(estateType) as IEstate;
            return structure;
        }
    }
}
