using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forest.Classes
{
    public class Power : Item
    {
        private PowerType type;
        private int minXp;

        public Power()
        {

        }

        public Power(string name, int priceGp, PowerType type, int minXp) : base(name, priceGp)
        {
            this.Type = type;
            this.MinXp = minXp;
        }

        public PowerType Type { get => type; set => type = value; }
        public int MinXp { get => minXp; set => minXp = value; }


    }
}
