using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Models
{
   public class Resource:IResource
   {
       private int quantity;
       private ResourceType type;

       public Resource(int quantity, ResourceType type)
       {
           this.Quantity = quantity;
           this.Type = type;
       }
       public int Quantity
       {
           get { return this.quantity; }
           private set { this.quantity = value; }
       }

       public ResourceType Type { get; private set; }
   }
}
