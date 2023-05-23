// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// postfix operator

// int a = 3;
// int b = a++;
// WriteLine($"a is {a}, b is {b}");

// // prefix operator.

// int c = 3;
// int d = ++c; // increment c before assigning it
// WriteLine($"c is {c}, d is {d}");

// int f = 3;
// double g = 11.0;
// WriteLine($"g is {g:N0}, f is {f}");
// WriteLine($"g is {g:N1}, f is {f}");
// WriteLine($"g / f = {g / f}");



/// -------------------------------

// bool a = true;
// bool b = false;
// WriteLine($"AND | a | b ");
// WriteLine($"a | {a & a,-5} | {a & b,-5} ");
// WriteLine($"b | {b & a,-5} | {b & b,-5} ");
// WriteLine();
// WriteLine($"OR | a | b ");
// WriteLine($"a | {a | a,-5} | {a | b,-5} ");
// WriteLine($"b | {b | a,-5} | {b | b,-5} ");
// WriteLine();
// WriteLine($"XOR | a | b ");
// WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
// WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");


// static bool DoStuff()
// {
//  WriteLine("I am doing some stuff.");
//  return true;
// }

// WriteLine();
// WriteLine($"a & DoStuff() = {a & DoStuff()}");
// WriteLine($"b & DoStuff() = {b & DoStuff()}");

// WriteLine();
// WriteLine($"a && DoStuff() = {a && DoStuff()}");
// WriteLine($"b && DoStuff() = {b && DoStuff()}");


/// ------------------------------- BitwiseAndShiftOperators

// int a = 10; // 00001010
// int b = 6; // 00000110
// WriteLine($"a = {a}");
// WriteLine($"b = {b}");
// WriteLine($"a & b = {a & b}"); // 2-bit column only e.g. 00000010
// WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns e.g. 00001110
// WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns e.g. 00001100



// // 01010000 left-shift a by three bit columns
// WriteLine($"a << 3 = {a << 3}");
// // multiply a by 8
// WriteLine($"a * 8 = {a * 8}");
// // 00000011 right-shift b by one bit column
// WriteLine($"b >> 1 = {b >> 1}");


// add and remove the "" from o to change the behavior
// object o = 3;
// int j = 4;
// if (o is int i)
// {
//  WriteLine($"{i} x {j} = {i * j}");
//  }
// else
// {
//  WriteLine("o is not an int so it cannot multiply!");
// }




///------------------------- Pattern matching with the switch statement

Animal?[] animals = new Animal?[]
{
    new Cat { Name = "karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true},
    null,
    new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12)},
    new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true},
    new Spider { Name = "Captain Furry", Born = DateTime.Today }
};

// foreach (Animal? animal in animals)
// {
//     string message;
//     switch (animal)
//     {
//         case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
//             message = $"The cat named {fourLeggedCat.Name} has four legs.";
//             break;
//         case Cat wildCat when wildCat.IsDomestic == false:
//             message = $"The non-domestic cat is named {wildCat.Name}.";
//             break;
//         case Cat cat:
//             message = $"The cat is named {cat.Name}.";
//             break;
//         default: // default is always evaluated last
//             message = $"The animal named {animal.Name} is a {animal.GetType().
//             Name}.";
//             break;
//         case Spider spider when spider.IsPoisonous:
//             message = $"The {spider.Name} spider is poisonous. Run!";
//             break;
//         case null:
//             message = "The animal is null.";
//             break;
//     }
//     WriteLine($"switch statement: {message}");
// }


foreach (Animal? animal in animals)
{
    string message = animal switch
    {
        Cat fourLeggedCat when fourLeggedCat.Legs == 4
        => $"The cat {fourLeggedCat.Name} has four legs.",
        Cat wildCat when wildCat.IsDomestic == false
        => $"The non-domestic cat is named {wildCat.Name}.",
        Cat cat
        => $"The cat is named {cat.Name}.",
        Spider spider when spider.IsPoisonous
        => $"The {spider.Name} spider is poisonous. Run!",
        null
        => "The animal is null.",
        _
        => $"The animal named {animal.Name} is a {animal.GetType().Name}."
    };
    WriteLine($"switch expression: {message}");
}
