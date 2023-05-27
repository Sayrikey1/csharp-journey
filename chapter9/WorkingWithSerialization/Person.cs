namespace Packt.Shared;
using System.Xml.Serialization; // [XmlAttribute]
// public class Person 
// {
//     // The constructor ( public Person() { } ) does not need to do anything, but it must exist so that the
//     // XmlSerializer can call it to instantiate new Person instances during the deserialization process.
//     public Person() { }
//     public Person(decimal initialSalary)
//     {
//         Salary = initialSalary;
//     }
//     public string? FirstName { get; set; }
//     public string? LastName { get; set; }
//     public DateTime DateOfBirth { get; set; }
//     public HashSet<Person>? Children { get; set; }
//     protected decimal Salary { get; set; }
// }




//--------- Generating compact XML ----------------

// This reduces file size from 656 to 451 bytes

public class Person
{
    // The constructor ( public Person() { } ) does not need to do anything, but it must exist so that the
    // XmlSerializer can call it to instantiate new Person instances during the deserialization process.
    public Person() { }
    public Person(decimal initialSalary)
    {
        Salary = initialSalary;
    }
    [XmlAttribute("fname")]
    public string? FirstName { get; set; }

    [XmlAttribute("lname")]
    public string? LastName { get; set; }

    [XmlAttribute("dob")]
    public DateTime DateOfBirth { get; set; }

    public HashSet<Person>? Children { get; set; }

    protected decimal Salary { get; set; }
}