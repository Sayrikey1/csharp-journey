using static System.Convert;

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
// int d = c; // compiler gives an error for this line
// WriteLine(d);

int d = (int)c;
WriteLine(d); // d is 9 losing the .8 part

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");


double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());


///------------ Parsing from strings to numbers or dates and times

int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");


/// ----------- Avoiding exceptions using the TryParse method

Write("How many eggs are there? ");
string? input = ReadLine(); // use "12" AND "TWELVE"
if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}