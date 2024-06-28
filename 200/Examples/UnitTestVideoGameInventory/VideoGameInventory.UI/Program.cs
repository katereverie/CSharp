using VideoGameInventory.UI.Containers;
using VideoGameInventory.UI.Items.Armors;
using VideoGameInventory.UI.Items.Potions;
using VideoGameInventory.UI.Items.Weapons;

ClothBag clothBag = new ClothBag();
Chest chest = new Chest();
PotionBandoleer band = new PotionBandoleer();

Sword sword1 = new Sword();
Sword sword2 = new Sword();
Sword sword3 = new Sword();

HealthPotion potion1 = new HealthPotion();
HealthPotion potion2 = new HealthPotion();
HealthPotion potion3 = new HealthPotion();

Helm helm1 = new Helm();
Helm helm2 = new Helm();
Helm helm3 = new Helm();


Console.WriteLine($"Adding a sword...{clothBag.AddItem(sword1)}");
Console.WriteLine($"Adding another sword...{clothBag.AddItem(sword2)}\n\n");


Console.WriteLine($"What about adding these swords to the Chest inventory? {chest.AddItem(sword1)}. You just added {sword1.Name}, it weighs {sword1.Weight}kg.");
Console.WriteLine($"Another sword to the Chest? {chest.AddItem(sword2)}. You just added {sword2.Name}, it weighs {sword2.Weight}kg.");
Console.WriteLine($"Adding a potion to the Chest...{chest.AddItem(potion1)}.");
Console.WriteLine($"Yet another potion to the Chest...{chest.AddItem(potion2)}.");
Console.WriteLine($"Adding a helmet to the Chest...{chest.AddItem(helm1)}.");
Console.WriteLine($"Can I add one more item?...{chest.AddItem(helm2)}.\n\n");

Console.WriteLine($"I'm adding a potion to the Potion Bandoleer...{band.AddItem(potion1)}.");
Console.WriteLine($"I'm adding a potion to the Potion Bandoleer...{band.AddItem(potion1)}.");
Console.WriteLine($"I'm adding a potion to the Potion Bandoleer...{band.AddItem(potion1)}.");
Console.WriteLine($"I'm adding a potion to the Potion Bandoleer...{band.AddItem(potion1)}.");
Console.WriteLine($"I'm adding a potion to the Potion Bandoleer...{band.AddItem(potion1)}.");
Console.WriteLine($"I'm adding a potion to the Potion Bandoleer...{band.AddItem(potion1)}.");
Console.WriteLine($"I'm adding a sword to the Potion Bandoleer...{band.AddItem(sword3)}.");



// list out contents
Console.WriteLine("Contents in the Clothbag");
clothBag.ListContents();
Console.WriteLine("\n\nContents in the Chest");
chest.ListContents();
Console.WriteLine("\n\nContents in the Potion Bandoleer");
band.ListContents();
