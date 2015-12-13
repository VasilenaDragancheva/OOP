using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Models.Items;

namespace TheSlum.GameEngine
{
    public static class ItemFactory
    {
        public static Item CreateItem(string[] input)
        {
            string type = input[2];
            string id = input[3];
            switch (type)
            {
                case "axe":
                    return new Axe(id);
                case "pill":
                    return new Pill(id);
                case "injection":
                    return new Injection(id);
                case "shield":
                    return new Shield(id);
                default:
                    throw new ArgumentException("Invalid Item input");
            }
        }
    }
}
