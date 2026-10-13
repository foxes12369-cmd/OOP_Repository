using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forest.Classes
{
    public class Weapon: Item
    {
        private int maxDmg;
        private int minDmg;

        public Weapon()
        {
            this.minDmg = 0;
            this.maxDmg = 0;
        }

        // what happens to the parent constructor?
        //base() is used to refer to the parent class's constructor
        public Weapon(string name, int priceGp, int min, int max) : base(name, priceGp)
        {
            this.minDmg = min;
            this.maxDmg = max;
        }

        public int MaxDmg { get => maxDmg; set => maxDmg = value; }
        public int MinDmg { get => minDmg; set => minDmg = value; }

    }
}
