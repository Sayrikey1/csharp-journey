using System.Text.RegularExpressions; // Regex

Write("Enter your age: ");
string input = ReadLine()!; // null-forgiving
// Regex ageChecker = new(@"\d");  // Accepts any input that contains a number
// Regex ageChecker = new(@"^\d$"); // Accepts only a single number
// Regex ageChecker = new(@"^\d+$");    // Positive numbers of any length

// Regex ageChecker = new(digitsOnlyText, RegexOptions.Compiled);

Regex ageChecker = DigitsOnly();

if (ageChecker.IsMatch(input))
{
 WriteLine("Thank you!");
}
else
{
 WriteLine($"This is not a valid age: {input}");
}

// C# 1 to 10: Use escaped double-quote characters \"
// string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two
Smoking Barrels\"";
// C# 11 or later: Use """ to start and end a raw string literal
string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
WriteLine($"Films to split: {films}");
string[] filmsDumb = films.Split(',');
WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
 WriteLine(film);
}


// Regex csv = new(
//  "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

// Regex csv = new(commaSeparatorText);

Regex csv = CommaSeparator();

MatchCollection filmsSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
 WriteLine(film.Groups[2].Value);
}



// All collections implement the ICollection interface; this means that they must have a Count property
// to tell you how many objects are in them, as shown in the following code:

namespace System.Collections;
public interface ICollection : IEnumerable
{
 int Count { get; }
 bool IsSynchronized { get; }
 object SyncRoot { get; }
 void CopyTo(Array array, int index);
}

// PAGE 375

namespace System.Collections.Generic;
public interface ICollection<T> : IEnumerable<T>, IEnumerable
{
 int Count { get; }
 bool IsReadOnly { get; }
 void Add(T item);
 void Clear();
 bool Contains(T item);
 void CopyTo(T[] array, int index);
 bool Remove(T item);
}


// Improving performance by ensuring the capacity of a collection

List<string> names = new();
names.EnsureCapacity(10_000);
// load ten thousand names into the list


//---------------------------------------------------------------------------------------------------//

// Understanding collection choices

// There are several different choices of collection that you can use for different purposes: lists, dictionaries, 
// stacks, queues, sets, and many other more specialized collections

//-----LIST---------------

namespace System.Collections.Generic;
[DefaultMember("Item")] // aka this indexer
public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
 T this[int index] { get; set; }
 int IndexOf(T item);
 void Insert(int index, T item);
 void RemoveAt(int index);
}


//---------Dictionaries-----------


namespace System.Collections.Generic;
[DefaultMember("Item")] // aka this indexer
public interface IDictionary<TKey, TValue>
 : ICollection<KeyValuePair<TKey, TValue>>,
 IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
 TValue this[TKey key] { get; set; }
 ICollection<TKey> Keys { get; }
 ICollection<TValue> Values { get; }
  void Add(TKey key, TValue value);
 bool ContainsKey(TKey key);
 bool Remove(TKey key);
 bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);
}

namespace System.Collections.Generic;
public readonly struct KeyValuePair<TKey, TValue>
{
 public KeyValuePair(TKey key, TValue value);
 public TKey Key { get; }
 public TValue Value { get; }
 [EditorBrowsable(EditorBrowsableState.Never)]
 public void Deconstruct(out TKey key, out TValue value);
 public override string ToString();
}