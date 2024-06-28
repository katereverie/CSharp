using UsingMethods;

Account a1 = new Account();

a1.SetName("Acme, Inc.");
a1.Deposit(500M);

if (a1.Withdraw(300M))
{
    Console.WriteLine($"The new balance for {a1.GetName()} is {a1.GetBalance()}");
}

if (a1.Withdraw(400M, true))
{
    Console.WriteLine($"The new balance for {a1.GetName()} is {a1.GetBalance()}");
}

if (a1.Withdraw(1000M))
{
    Console.WriteLine($"The new balance for {a1.GetName()} is {a1.GetBalance()}");
}
else
{
    Console.WriteLine("Overdraft!");
}