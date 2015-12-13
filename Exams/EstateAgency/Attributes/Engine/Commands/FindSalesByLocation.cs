using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Models.Offers;

namespace EstateAgency.Engine.Commands
{
    class FindSalesByLocation : Command
    {
        public FindSalesByLocation(DataBase dataBase)
            : base(dataBase)
        {

        }
        public override string Execute(params string[] commandParams)
        {
            string location = commandParams[0];
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Query results{0}", Environment.NewLine);

            var query = this.DataBase.Offers
                .Where(offer => offer.Estate.Location == location)
                .Select(offer => offer is SaleOffer)
                .Cast<SaleOffer>()
                .ToList();
            if(query.Count==0)
            {
                result.Append("No results");
            }
            foreach (var offer1 in query)
            {
                result.AppendFormat("[Estate: {0}, Location: {1}, Price: {2}{3}]",
                    offer1.Estate.Name,
                    offer1.Estate.Location,
                    offer1.Price,
                    Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
