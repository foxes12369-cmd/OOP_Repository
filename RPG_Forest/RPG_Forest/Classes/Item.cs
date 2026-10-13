using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Forest.Classes
{
    public class Item
    {
        private string name;
        private int priceGp;

        public string Name { get => name; set => name = value; }
        public int PriceGp { get => priceGp; set => priceGp = value; }

        public Item()
        {
            this.name = "N/A";
            this.priceGp = 0;
        }
        public Item(string name, int priceGp)
        {
            this.name = name;
            this.priceGp = priceGp;
        }

        public Item(Item i)
        {
            this.name = i.name;
            this.priceGp = i.priceGp;
        }

        public override string ToString()
        {
            return $"{this.name} : {this.priceGp} Gold";
        }
    }
}
