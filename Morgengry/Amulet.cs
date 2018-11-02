using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{

    public enum Level
    { // =0 er dobbeltkonfekt. det forklarer bare at de får int-værdier. og ikke index.
        low,
        medium,
        high,
    };
    public class Amulet : Merchandise
    {

        public string Design
        {
            get;
            set;
        }
        private Level _quality;
        public Level Quality
        {
            get
            {
                return _quality;
            }
            set
            {
                _quality = value;
            }
        }
        public Amulet (string itemId, Level quality, string design) : base(itemId)
        {
            Quality = quality;
            Design = design;
        }
        public Amulet (string itemId, Level Quality) : this(itemId , Quality, "")
        {
        }
        public Amulet (string itemId) : this(itemId, Level.medium, "") // i stedet for (Level)1 kan man skrive Level.medium. Man kan "caste" level, så det bliver til en int eller sånnåååå
        {
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}
