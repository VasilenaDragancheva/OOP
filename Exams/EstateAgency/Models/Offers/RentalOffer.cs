using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Models.Offers
{
    class RentalOffer:Offer
    {
        public RentalOffer(IEstate estate, decimal price):base(estate,price)
        {
            
        }
    }
}
