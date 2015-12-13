using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine
{
    public class ExtendedEngine : Engine
    {
        public ExtendedEngine():base()
        {
        }
        protected override void CreateCharacter(string[] inputParams)
        {
           Character createdCharacter=CharacterFactory.CreateCharacter(inputParams);
           this.characterList.Add(createdCharacter);   
        }
        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch(inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItemToCharachet(inputParams);
                    break;
                default:
                    throw new ArgumentException("Invalid command!");

            }
        }
        protected void AddItemToCharachet(string[] input)
        {
            string characterID = input[1];
            Item item = ItemFactory.CreateItem(input);
            Character character = this.characterList.FirstOrDefault(c => c.Id == characterID);
            character.AddToInventory(item);


        }
    }
}
