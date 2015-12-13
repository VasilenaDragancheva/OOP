using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Models.Offers;

namespace EstateAgency.Engine.Commands
{
    public class FindRentsByPrice:Command
    {
        public FindRentsByPrice(DataBase dataBase):base(dataBase)
        {
            
        }

        public override string Execute(params string[] commandParams)
        {
            decimal minPrice = decimal.Parse(commandParams[0]);
            decimal maxPrice = decimal.Parse(commandParams[1]);

            var query = this.DataBase.Offers
                .Where(offer => offer.Price >= minPrice && offer.Price <= maxPrice)
                .Select(off=> off is RentalOffer)
                .Cast<RentalOffer>()
                .ToList();

            StringBuilder result=new StringBuilder();

            result.AppendFormat("Query results{0}", Environment.NewLine);
            if (query.Count == 0)
            {
                result.Append("No results");
            }

            foreach (var offer in query)
            {

                result.AppendFormat("[Estate: {0}, Location: {1}, Price: {2}{3}]",
                    offer.Estate.Name,
                    offer.Estate.Location,
                    offer.Price,
                    Environment.NewLine);
            }
            return result.ToString();
        }
    }
}
