using System.Reflection;


// // See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// // Outputs the current line terminator string.
// // By default, this is a carriage-return and line feed.
// Console.WriteLine();
// // Outputs the greeting and the current line terminator string.
// Console.WriteLine("Hello Ahmed");
// // Outputs a formatted number and date and the current line terminator string.
// Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

// // #error version

// declare some unused variables using types
// in additional assemblies

// System.Data.DataSet ds;
// HttpClient client;

// Assembly? myApp = Assembly.GetEntryAssembly();
// if (myApp == null) return; // quit the app
// // loop through the assemblies that my app references
// foreach (AssemblyName name in myApp.GetReferencedAssemblies())
// {
//  // load the assembly so we can read its details
//  Assembly a = Assembly.Load(name);
//  // declare a variable to count the number of methods
//  int methodCount = 0;
//  // loop through all the types in the assembly
//  foreach (TypeInfo t in a.DefinedTypes)
//  {
//  // add up the counts of methods
//  methodCount += t.GetMethods().Count();
//  }
//  // output the count of types and their methods
//  Console.WriteLine(
//  "{0:N0} types with {1:N0} methods in {2} assembly.",
//  arg0: a.DefinedTypes.Count(),
//  arg1: methodCount,
//  arg2: name.Name);
// }
// // let the heightInMetres variable become equal to the value 1.88
// double heightInMetres = 1.88;
// Console.WriteLine($"The variable {nameof(heightInMetres)} has the value{heightInMetres}.");


// char userChoice = GetSomeKeystroke(); // assigning from a fictitious function

// char GetSomeKeystroke()
// {
//     throw new NotImplementedException();
// }

// string firstName = "Bob"; // assigning literal strings
// string lastName = "Smith";
// string phoneNumber = "(215) 555-4256";
// // assigning a string returned from the string class constructor
string horizontalLine = new('-', count: 74); // 74 hyphens
// // assigning a string returned from a fictitious function

// string address = GetAddressFromDatabase(id: 563);

// string GetAddressFromDatabase(int id)
// {
//     throw new NotImplementedException();
// }

string fullNameWithTabSeparator = "Bob\tSmith";

// assigning an emoji by converting from Unicode
Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

// Console.WriteLine(address);

Console.WriteLine(horizontalLine);
Console.WriteLine(fullNameWithTabSeparator);