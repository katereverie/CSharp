using UsingProperties;

Contact c1 = new Contact();

c1.FirstName = "Jiantao";
c1.LastName = "Zhang";
c1.Birthdate = new DateTime(1992, 1, 23);

Console.WriteLine($"{c1.NameLastFirst} | Age: {c1.AgeYears}");

// Object Initialization Syntax
Contact c2 = new Contact()
{
    FirstName = "Tom",
    LastName = "Mini",
    Birthdate = new DateTime(1990, 6, 29)
};

Console.WriteLine($"{c2.NameLastFirst} | Age: {c2.AgeYears}");