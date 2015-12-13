using CosmeticsShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmeticsShop.Models;
using CosmeticsShop.Models.Commands;
using System.Text.RegularExpressions;
using CosmeticsShop.Models.Products;

namespace CosmeticsShop.Engines
{
    public class Engine:IEngine
        
    {
        private List<ICategory> categories;
        private List<IProduct> products;
        private CommandDispatcher commandDispatcher;
        private IInputReader inputReader;
        private bool runningEngine;
        public Engine(CommandDispatcher commandDispatcher,IInputReader inputReader)
        {
            this.categories = new List<ICategory>();
            this.products = new List<IProduct>();
            this.commandDispatcher = commandDispatcher;
            this.inputReader = inputReader;
            this.runningEngine = false;
            this.products.Add(new Toothpaste("Duck","drin",12,Gender.Unisex,"soda"));
        }

        public IEnumerable<ICategory> Categories
        {
            get { return this.categories; }
        }

        public void Run()
        {
            this.runningEngine = true;
            while (runningEngine)
            {
                try
                {        
                string line = this.inputReader.ReadLine();
                string[] tokens = Regex.Replace(line, "\\s+", " ").Split(' ').ToArray();
                string commandName = tokens[0];
                string[] commandParams = tokens.Skip(1).ToArray();
                Command command = this.commandDispatcher.GetCommandByInput(commandName, this);
                string result = command.ExecuteCommand(commandParams);
                Console.WriteLine(result);
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
        public void AddCategory(string name)
        {
            ICategory category = new Category(name);
            this.categories.Add(category);
        }
        public ICategory FindCategory(string name)
        {
            ICategory category = this.Categories.FirstOrDefault(cat => cat.Name == name);
            if(category==null)
            {
                throw new ArgumentNullException();
            }
            return category;
        }
        public IProduct FindProduct(string name)
        {
            IProduct product = this.products.FirstOrDefault(prod => prod.Name == name);
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            return product;
        }

    }
}

