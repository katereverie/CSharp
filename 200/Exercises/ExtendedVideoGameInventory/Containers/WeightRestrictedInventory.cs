using VideoGameInventory.Items;

namespace VideoGameInventory.Containers
{
    public abstract class WeightRestrictedInventory : InventoryBase
    {
        protected double _currentWeight = 0; 
        protected double _maxWeight;

        public WeightRestrictedInventory(int capacity, double maxWeight) : base(capacity)
        {
            _maxWeight = maxWeight;
        }

        public override AddResult AddItem(ItemBase item)
        {
            if ((double)item.Weight + _currentWeight > _maxWeight)
            {
                return AddResult.Overweight;
            }

            if (base.AddItem(item) == AddResult.Success)
            {
                _currentWeight += item.Weight;
            }

            return AddResult.Success;
            
        }

        public override ItemBase RemoveItem(int index)
        {
            
            ItemBase item = base.RemoveItem(index);

            if (item != null)
            {
                _currentWeight -= item.Weight;
            }
            
            return item;

        }
    }
}
