using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameInventory.Items.Potions
{
    public abstract class PotionBase : ItemBase
    {
        public abstract void Drink();
    }
}
