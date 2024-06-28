using VideoGameInventory.Items;

namespace VideoGameInventory.Containers
{
    public class PotionBandoleer : TypeRestrictedInventory
    {
        public PotionBandoleer() : base(3, ItemType.Potion)
        {
            
        }
    }
}
