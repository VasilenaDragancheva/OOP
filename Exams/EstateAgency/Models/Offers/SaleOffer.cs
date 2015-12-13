using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Models.Offers
{
    public class SaleOffer:Offer
    {
        public SaleOffer(IEstate estate, decimal price):base(estate,price)
        {
        }
    }
}
