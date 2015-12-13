using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerCreed.Engine
{
    public class UserInterface
    {
        public void ReadInput()
        {
          Console.ReadLine();
        }

        public void WriteOutput(string output)
        {
            Console.WriteLine(output); 
        }
}
}
