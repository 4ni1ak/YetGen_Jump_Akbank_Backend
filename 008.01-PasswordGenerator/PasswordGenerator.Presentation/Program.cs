using Yetgen.PWGenerator;

var passwordGenerator = new PasswordsGenerator();

Console.WriteLine("Please enter the desired length for your password.");

var passwordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Should your password include numbers?");

var includeNumbers = Console.ReadLine() == "yes";

Console.WriteLine("Should your password include lowercase characters?");

var includeLowerCase = Console.ReadLine() == "yes";

Console.WriteLine("Should your password include uppercase characters?");

var includeUpperCase = Console.ReadLine() == "yes";

Console.WriteLine("Should your password include special characters?");

var includeSpecialChars = Console.ReadLine() == "yes";

var password = passwordGenerator.Generate(passwordLength, includeNumbers, includeLowerCase, includeUpperCase, includeSpecialChars);

Console.WriteLine($"Your password: {password}");

Console.ReadLine();