using Microsoft.Win32.SafeHandles; // SafeFileHandle
using System.Text; // Encoding

WriteLine("Encodings");
WriteLine("[1] ASCII");
WriteLine("[2] UTF-7");
WriteLine("[3] UTF-8");
WriteLine("[4] UTF-16 (Unicode)");
WriteLine("[5] UTF-32");
WriteLine("[6] Latin1");
WriteLine("[any other key] Default encoding");
WriteLine();
// choose an encoding
Write("Press a number to choose an encoding.");
ConsoleKey number = ReadKey(intercept: true).Key;
WriteLine(); WriteLine();
Encoding encoder = number switch
{
    ConsoleKey.D1 or ConsoleKey.NumPad1 => Encoding.ASCII,
    ConsoleKey.D2 or ConsoleKey.NumPad2 => Encoding.UTF7,
    ConsoleKey.D3 or ConsoleKey.NumPad3 => Encoding.UTF8,
    ConsoleKey.D4 or ConsoleKey.NumPad4 => Encoding.Unicode,
    ConsoleKey.D5 or ConsoleKey.NumPad5 => Encoding.UTF32,
    ConsoleKey.D6 or ConsoleKey.NumPad6 => Encoding.Latin1,
    _ => Encoding.Default
};
// define a string to encode
string message = "Café £4.39";
WriteLine($"Text to encode: {message} Characters: {message.Length}");
// encode the string into a byte array
byte[] encoded = encoder.GetBytes(message);
// check how many bytes the encoding needed
WriteLine("{0} used {1:N0} bytes.", encoder.GetType().Name,
encoded.Length);
WriteLine();
// enumerate each byte
WriteLine($"BYTE | HEX | CHAR");
foreach (byte b in encoded)
{
    WriteLine($"{b,4} | {b.ToString("X"),3} | {(char)b,4}");
}
// decode the byte array back into a string and display it
string decoded = encoder.GetString(encoded);
WriteLine(decoded);


// Encoding and decoding text in files

// To specify an encoding, pass the encoding as a second parameter to the helper type’s constructor, as
// shown in the following code:
// StreamReader reader = new(stream, Encoding.UTF8);
// StreamWriter writer = new(stream, Encoding.UTF8);




//------------ Reading and writing with random access handles -----------------------

// using SafeFileHandle handle = File.OpenHandle(path: "coffee.txt", 
//                                 mode: FileMode.OpenOrCreate, 
//                                 access: FileAccess.ReadWrite);

// You can then write some text encoded as a byte array and then stored in a read-only memory buffer
// to the file, as shown in the following code:

// string message = "Café £4.39";
// ReadOnlyMemory<byte> buffer = new(Encoding.UTF8.GetBytes(message));
// await RandomAccess.WriteAsync(handle, buffer, fileOffset: 0);

// To read from the file, get the length of the file, allocate a memory buffer for the contents using that
// length, and then read the file, as shown in the following code:

// long length = RandomAccess.GetLength(handle);
// Memory<byte> contentBytes = new(new byte[length]);
// await RandomAccess.ReadAsync(handle, contentBytes, fileOffset: 0);
// string content = Encoding.UTF8.GetString(contentBytes.ToArray());
// WriteLine($"Content of file: {content}");


// Serializing object graphs

// There are dozens of formats you can specify, but the two most common ones are eXtensible Markup
// Language (XML) and JavaScript Object Notation (JSON). 