using ClassLibraries.Utilities;

int x = Prompter.GetPositiveInteger("Give me a number: ");
Console.WriteLine($"You entered {x}.");
Console.ReadKey();