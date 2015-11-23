using System;
using Problem2.Enum;

namespace Problem2.Interfaces
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        Gender Gender { get; set; }
    }
}
