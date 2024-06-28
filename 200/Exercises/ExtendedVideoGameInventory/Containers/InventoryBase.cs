using VideoGameInventory.Items;
using VideoGameInventory.Items.Weapons;

namespace VideoGameInventory.Containers
{
    public class InventoryBase
    {
        // changed from private to protected
        protected int _capacity;
        protected ItemBase[] _contents;

        public InventoryBase(int capacity)
        {
            _capacity = capacity;
            _contents = new ItemBase[_capacity];
        }

        public virtual AddResult AddItem(ItemBase item)
        {
            for (int i = 0; i < _capacity; i++)
            {
                if (_contents[i] == null)
                {
                    _contents[i] = item;
                    return AddResult.Success;
                }
            }
            return AddResult.ContainerFull;
        }

        public virtual ItemBase RemoveItem(int index)
        {
            if (index >= 0 && index < _capacity)
            {
                ItemBase item = _contents[index];
                if (item != null)
                {
                    _contents[index] = null;
                    return item;
                }
            }
            return null;
        }

        public virtual void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine("=====================");
            for (int i = 0; i < _capacity; i++)
            {
                if (_contents[i] != null)
                {
                    Console.WriteLine($"{_contents[i].Type} | {_contents[i].Name} | {_contents[i].Weight}kg | ${_contents[i].Value}");
                }
            }
        }
    }
}
