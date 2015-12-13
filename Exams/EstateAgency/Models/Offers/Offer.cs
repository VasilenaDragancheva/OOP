using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Models.Offers
{
    public abstract class Offer:IOffer
    {
        private IEstate estate;
        private decimal price;
        protected Offer(IEstate estate,decimal price)
        {
            this.Estate = estate;
            this.Price = price;
        }

        public IEstate Estate
        {
            get { return this.estate; }
            private set
            {
                if (estate == null)
                {
                    throw new ArgumentNullException();
                }
                this.estate = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();         
                }
                this.price = value;
            }
        }
    }
}
