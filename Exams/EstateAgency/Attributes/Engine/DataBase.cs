using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstateAgency.Models.Interfaces;

namespace EstateAgency.Engine
{
    public class DataBase
    {
        private List<IOffer> offers;
        private List<IEstate> estates;

        public DataBase()
        {
            this.offers = new List<IOffer>();
            this.estates = new List<IEstate>();
        }

        public IEnumerable<IOffer> Offers { get { return this.offers; } }
        public IEnumerable<IEstate> Estates { get { return this.estates; } }

        public void AddOffer(IOffer offer)
        {
            if (offer == null)
            {
                throw new ArgumentNullException();
            }
            this.offers.Add(offer);
        }
        public void AddEstate(IEstate estate)
        {
            if (estate == null)
            {
                throw new ArgumentNullException();
            }
            this.estates.Add(estate);
        }
    }
}
