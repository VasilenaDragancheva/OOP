using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmeticsShop.Models.Products
{
   public class Toothpaste:Product
    {

        private List<string> ingridients;
        public Toothpaste(string name,string brand,decimal price,Gender gender ,params string[] ingridients):base(name,brand,price,gender)
        {
            this.ingridients=new List<string>();
        }
        public IEnumerable<string> Ingridients { get; set; }
       

        private void AddIngridientsToList(string[] ingridients)
        {
            if (ingridients.Length == 0)
            {
                throw new ArgumentOutOfRangeException("No ingridients supplied");
            }
            if(!ingridients.Any(elem=>!string.IsNullOrEmpty(elem)))
                 {
                     throw new ArgumentOutOfRangeException("No ingridients supplied");
            }
            for (int i = 0; i <ingridients.Length; i++)
            {
                string ingridient = ingridients[0];
                if(ingridient!=null)
                {
                    this.ingridients.Add(ingridient);
                }
            }
        }

    }
}
