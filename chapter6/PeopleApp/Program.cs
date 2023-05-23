using Packt.Shared;
Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};
harry.WriteToConsole();


// non-generic lookup collection
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; // look up the value that has 2 as its key
WriteLine(format: "Key {0} has value: {1}",
 arg0: key,
 arg1: lookupObject[key]);

// look up the value that has harry as its key
WriteLine(format: "Key {0} has value: {1}",
 arg0: harry,
 arg1: lookupObject[harry]);

// Good Practice: Avoid types imported into the System.Collections namespace. Use types
// imported in System.Collections.Generics and other namespaces instead.

// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
// lookupIntString.Add(key: harry, value: "Delta"); // Gives type eror
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}",
 arg0: key,
 arg1: lookupIntString[key]);




// // calling th method
// Person p1 = new();
// int answer = p1.MethodIWantToCall("Frog");

// // calling alkternatively with delegates

// delegate int DelegateWithMatchingSignature(string s);

// // create a delegate instance that points to the method
// DelegateWithMatchingSignature d = new(p1.MethodIWantToCall);
// // call the delegate, who then calls the method
// int answer2 = d("Frog");

// You are probably thinking, “What’s the point of that?” Well, it provides flexibility.
// For example, we could use delegates to create a queue of methods that need to be called in order.
// Queuing actions that need to be performed is common in services to provide improved scalability.
// Another example is to allow multiple actions to perform in parallel. Delegates have built-in support for
// asynchronous operations that run on a different thread, and that can provide improved responsiveness.


// // assign a method to the Shout delegate
// harry.Shout = Harry_Shout;

// assign event handler methods to Shout event
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout2;

// call the Poke method that raises the Shout event
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

// If a type implements an interface, then it is making a promise to the rest of .NET that it supports
// specific functionality. Therefore, they are sometimes described as contracts.

Person?[] people =
{
 null,
 new() { Name = "Simon" },
 new() { Name = "Jenny" },
 new() { Name = "Adam" },
 new() { Name = null },
 new() { Name = "Richard" }
};
OutputPeopleNames(people, "Initial list of people:");
Array.Sort(people);
OutputPeopleNames(people,
 "After sorting using Person's IComparable implementation:");

Array.Sort(people, new PersonComparer());
OutputPeopleNames(people,
 "After sorting using PersonComparer's IComparer implementation:");

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{dv3.Y})");

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};

john.WriteToConsole();

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

WriteLine(john.ToString());

Employee aliceInEmployee = new() { Name = "Alice", EmployeeCode = "AA123" };
Person aliceInPerson = aliceInEmployee; //Implicit casting
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
WriteLine(aliceInEmployee.ToString());
WriteLine(aliceInPerson.ToString());

// Explicit casting                                                                                                   
// Employee explicitAlice = aliceInPerson;
Employee explicitAlice = (Employee)aliceInPerson;


if (aliceInPerson is Employee)
{
    WriteLine($"{nameof(aliceInPerson)} IS an Employee");
    Employee explicitAlice = (Employee)aliceInPerson;
    // safely do something with explicitAlice
}


try
{
    john.TimeTravel(when: new(1999, 12, 31));
    john.TimeTravel(when: new(1950, 12, 25));
}
catch (PersonException ex)
{
    WriteLine(ex.Message);
}

string email1 = "pamela@test.com";
string email2 = "ian&test.com";
WriteLine("{0} is a valid e-mail address: {1}",
 arg0: email1,
 arg1: StringExtensions.IsValidEmail(email1));
WriteLine("{0} is a valid e-mail address: {1}",
 arg0: email2,
 arg1: StringExtensions.IsValidEmail(email2));