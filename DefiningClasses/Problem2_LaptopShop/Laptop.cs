using System;
using System.Text;

namespace Problem2_LaptopShop
{
    public class Laptop
    {
        private string model;
        private int? ram;
        private string screen;
        private decimal price;

        public Laptop(string model, decimal price)
            : this(model, null, null, null, null, null, null, null, price)
        {

        }
        public Laptop(string model, string manifacture, string proccesor,
            int? ram, string graphic, string hdd, string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manifacture = manifacture;
            this.Proccesor = proccesor;
            this.Ram = ram;
            this.GraphicCard = graphic;
            this.Hdd = hdd;
            this.screen = screen;
            this.Battery = battery;
            this.Price = price;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannnot be null");
                }
                this.model = value;
            }
        }
        public string Manifacture { get; set; }
        public string Proccesor { get; set; }
        public int? Ram
        {
            get
            {       
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ram is not negative integer");
                }
                this.ram = value;
            }
        }
        public string GraphicCard{get;set;}
        public string Hdd { get; set; }
        public string Screen { get; set; }
        public Battery Battery { get; set; }
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price is not negative number");
                }
                this.price = value;
            }
        }
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("{0,10}\n", "Laptop description");
            toString.AppendFormat("|{0,-10}|{1} \n", "Model", this.Model);
            if (!string.IsNullOrEmpty(this.Manifacture))
            {
                toString.AppendFormat("|{0,-10}|{1} \n", "Manifacture", this.Manifacture);
            }
            if (!string.IsNullOrEmpty(this.Proccesor))
            {
                toString.AppendFormat("|{0,-10}|{1} \n", "Proccesor", this.Proccesor);
            }
            if (this.Ram != null)
            {
                toString.AppendFormat("|{0,-10}|{1} GB \n", "RAM", this.Ram);
            }
            if (!string.IsNullOrEmpty(this.GraphicCard))
            {
                toString.AppendFormat("|{0,-10}|{1} \n", "GraphicCard", this.GraphicCard);
            }
            if (!string.IsNullOrEmpty(this.Hdd))
            {
                toString.AppendFormat("|{0,-10}|{1} \n", "HDD", this.Hdd);
            }
            if (!string.IsNullOrEmpty(this.screen))
            {
                toString.AppendFormat("|{0,-10}|{1} \n", "Screen", this.Screen);
            }
            if (this.Battery != null)
            {
                toString.AppendFormat("{0}\n", this.Battery.ToString());
            }
            toString.AppendFormat("|{0,-10}|{1:F2}lv.\n", "Price", this.Price);
            return toString.ToString();
        }
    }
}
