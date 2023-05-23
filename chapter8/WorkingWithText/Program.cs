string city = "London";
WriteLine($"{city} is {city.Length} characters long.");

WriteLine($"First char is {city[0]} and fourth is {city[3]}.");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} items in the array:");
foreach (string item in citiesArray)
{
 WriteLine(item);
}

string fullName = "Alan Shore";
int indexOfTheSpace = fullName.IndexOf(' ');
string firstName = fullName.Substring(
 startIndex: 0, length: indexOfTheSpace);
string lastName = fullName.Substring(
 startIndex: indexOfTheSpace + 1);
WriteLine($"Original: {fullName}");
WriteLine($"Swapped: {lastName}, {firstName}");

string company = "Microsoft";
bool startsWithM = company.StartsWith("M");
bool containsN = company.Contains("N");

string recombined = string.Join(" => ", citiesArray);
WriteLine(recombined);

string fruit = "Apples";
decimal price = 0.39M;
DateTime when = DateTime.Today;
WriteLine($"Interpolated: {fruit} cost {price:C} on {when:dddd}.");
WriteLine(string.Format("string.Format: {0} cost {1:C} on {2:dddd}.",
 arg0: fruit, arg1: price, arg2: when));

WriteLine("WriteLine: {0} cost {1:C} on {2:dddd}.",
 arg0: fruit, arg1: price, arg2: when);


using System;
using System.Text;

public sealed class App
{
    static void Main()
    {
        // Create a StringBuilder that expects to hold 50 characters.
        // Initialize the StringBuilder with "ABC".
        StringBuilder sb = new StringBuilder("ABC", 50);

        // Append three characters (D, E, and F) to the end of the StringBuilder.
        sb.Append(new char[] { 'D', 'E', 'F' });

        // Append a format string to the end of the StringBuilder.
        sb.AppendFormat("GHI{0}{1}", 'J', 'k');

        // Display the number of characters in the StringBuilder and its string.
        Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

        // Insert a string at the beginning of the StringBuilder.
        sb.Insert(0, "Alphabet: ");

        // Replace all lowercase k's with uppercase K's.
        sb.Replace('k', 'K');

        // Display the number of characters in the StringBuilder and its string.
        Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
    }
}

// This code produces the following output.
//
// 11 chars: ABCDEFGHIJk
// 21 chars: Alphabet: ABCDEFGHIJK