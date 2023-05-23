// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// WriteLine("Before parsing");
// Write("What is your age? ");
// string? input = ReadLine(); // or use "49" in a notebook
// try
// {
//     int age = int.Parse(input);
//     WriteLine($"You are {age} years old.");
// }
// catch
// {
// }
// catch (FormatException)
// {
//  WriteLine("The age you entered is not a valid number format.");
// }
// catch (Exception ex)
// {
//  WriteLine($"{ex.GetType()} says {ex.Message}");
// }
// WriteLine("After parsing");


// To disable the compiler warning, change input to input!. An exclamation mark ! after an
// expression is called the null-forgiving operator and it disables the compiler warning. The
// null-forgiving operator has no effect at runtime. If the expression could evaluate to null at
// runtime, perhaps because we assigned it in another way, then an exception would be thrown.


int x = 3;
int y = 2 + ++x;
int z = 2 + x++;

WriteLine(y);
WriteLine(z);