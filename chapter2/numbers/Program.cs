// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // three variables that store the number 2 million
// int decimalNotation = 2_000_000;
// int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
// int hexadecimalNotation = 0x_001E_8480;
// // check the three variables have the same value
// // both statements output true
// Console.WriteLine($"{decimalNotation == binaryNotation}");
// Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
// Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
// Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

// object height = 1.88; // storing a double in an object
// object name = "Amir"; // storing a string in an object
// Console.WriteLine($"{name} is {height} metres tall.");
// // int length1 = name.Length; // gives compile error!
// int length2 = ((string)name).Length; // tell compiler it is a string
// Console.WriteLine($"{name} has {length2} characters.");


// L: Compiler infers long
// • UL: Compiler infers ulong
// • M: Compiler infers decimal
// • D: Compiler infers double
// • F: Compiler infers float


Console.WriteLine(
 format: "{0} {1} lived in {2}, {3} and worked in the {4} team at {5}.", "Roger", "Cevung", "Stockholm", "Sweden", "Education", "Optimizely");

// In Program.cs
// Person kim = new();
// kim.BirthDate = new(1967, 12, 26); // instead of: new DateTime(1967, 12, 26)



// List<Person> people = new()
// {
//   new() { FirstName = "Alice" },
//   new() { FirstName = "Bob" },
//   new() { FirstName = "Charlie" }
// };



// // In a separate Person.cs file or at the bottom of Program.cs
// class Person
// {
//  public DateTime BirthDate;
//  public string FirstName;
// }



Console.Write("Type your first name and press ENTER: ");
string firstName = Console.ReadLine();
Console.Write("Type your age and press ENTER: ");
string age = Console.ReadLine();
Console.WriteLine($"Hello {firstName}, you look good for {age}.");