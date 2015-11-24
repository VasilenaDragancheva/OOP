using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class NotPossibleToCompleteException:SystemException
    {
        public NotPossibleToCompleteException(string message)
            : base("There are not enough left numbers")
        {
              
        }
    }
}
