using VideoGameInventory.UI.Items;

namespace VideoGameInventory.UI.Containers
{
    public class PotionBandoleer : TypeRestrictedInventory
    {
        public PotionBandoleer() : base(3, ItemType.Potion)
        {
            
        }
    }
}
