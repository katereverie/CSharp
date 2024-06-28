using NUnit.Framework;
using VideoGameInventory.UI.Containers;
using VideoGameInventory.UI.Items.Weapons;
using VideoGameInventory.UI.Items.Armors;

namespace VideoGameInventory.Tests
{
    [TestFixture] // Ctr + Period
    public class InventoryBaseTests
    {
        [Test] // Be SPECIFIC when naming tests/test suits.
        public void AddItem_Success()
        {
            // Reference Classes if those are in another project folder.
            // To reference classes in another folder, right click "Dependencies" of this folder and click "Add Project Reference"
            var chest = new Chest(2);
            var item = new Sword();

            var result = chest.AddItem(item);

            Assert.That(AddResult.Success, Is.EqualTo(result));

        }

        [Test]
        public void addItem_ContainerFull()
        {
            var chest = new Chest (1);

            var item1 = new Sword();
            var item2 = new Helm(); 

            chest.AddItem(item1);
            var result = chest.AddItem(item2);

            Assert.That(AddResult.ContainerFull, Is.EqualTo(result));

        }

    }
}
