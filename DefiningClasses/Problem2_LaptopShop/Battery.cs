using System;
using System.Text;


namespace Problem2_LaptopShop
{
    class Battery
    {
        private string name;
        private double lifetime;
        public Battery(string name, double lifetime)
        {
            this.Name = name;
            this.Lifetime = lifetime;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery cann not be null!");
                }
                this.name = value;
            }
        }
        public double Lifetime 
        {
            get
            {
                return this.lifetime;
            }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentException("Live time is positive double");
                }
                this.lifetime = value;
            }
        }
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("|{0,-10}|{1:F2}\n", "Name", this.Name);
            toString.AppendFormat("|{0,-10}|{1:F2} hours \n", "Lifetime", this.Lifetime);
            return toString.ToString();
        }
    }
}
