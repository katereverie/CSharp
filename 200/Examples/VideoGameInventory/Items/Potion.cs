using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameInventory.Items
{
    public class Potion : ItemBase
    {
        public Potion()
        {
            Type = ItemType.Potion;
            Name = "Health Potion";
            Description = "Restores a small amount of health.";
            Weight = 1.0;
            Value = 25m;
        }
    }
}
