using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAdventures
{
    public class Item
    {
        public string name;
        public decimal cost;

        public Item(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }
    }
}
