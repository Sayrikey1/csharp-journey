int thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error!
WriteLine(thisCannotBeNull);
int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
WriteLine(thisCouldAlsoBeNull);

Address address = new()
{
    Building = null,
    // Street = null,
    Street = null!, // null-forgiving operator
    City = "London",
    Region = "UK"
};

// WriteLine(address.Building.Length);
WriteLine(address.Building?.Length);
WriteLine(address.Street.Length);