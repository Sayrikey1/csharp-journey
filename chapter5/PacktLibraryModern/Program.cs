using Packt.Shared;

// Book book = new()
// {
//  Isbn = "978-1803237800",
//  Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
// };

Book book = new(isbn: "978-1803237800", title: "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals")
{
 Author = "Mark J. Price",
 PageCount = 821
};


WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
 book.Isbn, book.Title, book.Author, book.PageCount);


// Implementing functionality using operators

string s1 = "Hello ";
string s2 = "World!";
// string s3 = string.Concat(s1, s2);

string s3 = s1 + s2;
WriteLine(s3); // Hello World!

ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls Deconstruct method
WriteLine($"{who} is a {what}.");