using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameInventory.Items
{
    public class Helm : ItemBase
    {
        public Helm() 
        {
            Type = ItemType.Armor;
            Name = "Steel Helmet";
            Description = "Protective metal armor.";
            Weight = 30.0;
            Value = 200m;
        }
    }
}
