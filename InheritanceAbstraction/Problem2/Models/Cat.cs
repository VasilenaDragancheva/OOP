﻿using System;
using Problem2.Enum;

namespace Problem2.Models
{
   abstract class Cat:Animal
    {
       protected Cat(string name,int age,Gender gender)
           :base(name,age,gender)
       {

       }
    }
}
