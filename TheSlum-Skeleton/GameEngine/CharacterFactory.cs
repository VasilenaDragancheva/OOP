using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Models.Characters;
using TheSlum.Models.Items;


namespace TheSlum.GameEngine
{
    public static class CharacterFactory
    {
        public static Character CreateCharacter(string[] input)
        {
             string characterType = input[1];
            string characherID = input[2];
            int x = int.Parse(input[3]);
            int y = int.Parse(input[4]);
            Team team=(Team)Enum.Parse(typeof(Team),input[5]);
            switch(characterType)
            {
                case "mage":
                    return new Mage(characherID, x, y, team);
                    
                case "warrior":
                    return new Warrior(characherID, x, y, team);
                case "healer":
                    return new Healer(characherID, x, y, team);
                default:
                    throw new ArgumentException("Invalid type of character!");

            }
        }
    }
}
