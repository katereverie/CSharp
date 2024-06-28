using AboutMe.IO;

string fistName = Prompter.GetRequiredString("Enter First Name: ");
string lastName = Prompter.GetRequiredString("Enter Last Name: ");
DateTime dateOfBirth = Prompter.GetPastDate("Enter Date of Birth: ");
int age = Prompter.GetAgeInRange("Enter Age: ", 1, 120);
string maritalStatus = Prompter.GetMaritalStatus();

Printer.PrintHeader();
Printer.PrintAboutMe(fistName, lastName, dateOfBirth, age, maritalStatus);
