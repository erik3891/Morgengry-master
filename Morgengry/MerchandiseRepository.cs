using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddAmulet(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public void AddBook(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise Getamulet(string itemId)
        {
            for (int i = 0; i < merchandises.Count; i++)
            {
                if (merchandises[i].ItemId == itemId)
                {
                    return merchandises[i];
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double value = 0;
            for (int i = 0; i < merchandises.Count; i++)
            {
                value += Utility.GetValueOfMerchandise(merchandises[i]);
            }
            return value;
        }
    }
}
