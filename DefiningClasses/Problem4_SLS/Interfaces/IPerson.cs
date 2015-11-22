using System;


namespace Problem4_SLS.Interfaces
{
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}
