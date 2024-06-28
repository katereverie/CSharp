using NuGetPackages;
using Newtonsoft.Json;
using System.Reflection;

// NuGet GUI: Right click "Dependencies" under "NugetPackages"

// Go to "Tools" - "NuGet Packages Manager " - "Package Manager Console"
// PM> install-package packagename
// PM> uninstall-package packagename 

var m = new Movie
{
    Title = "Star Wars",
    Rating = "PG",
    Year = 1977
};

string jsonstring = JsonConvert.SerializeObject(m);
Console.WriteLine($"Serialized JSON: {jsonstring}");

var deserialized = JsonConvert.DeserializeObject<Movie>(jsonstring);
Console.WriteLine($"Deserialized Movie: Title = {deserialized.Title}, Rating = {deserialized.Rating}, Year ={deserialized.Year}");