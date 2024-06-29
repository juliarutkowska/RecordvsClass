namespace RecordvsClass;

public class RecordvsClass
{
    //In C#, a record is a special type of class that is defined by its contents rather than its identity.
    //This means that two records with identical contents are equal.

    // The benefits of using records include:
    // - Value-based equality: Two instances of a record type are equal if their types are identical and all their members are equal.
    // - Nondestructive mutation: Records are immutable by default which means once a record is created, it cannot be changed.
    // Instead, you can create a copy of the record with modifications using with keyword.
    // - Conciseness: Records can be very concise as shown in the example above.


    //In C#, a class is a construct that is used to create more complex data types.
    //A class can contain data (in the form of fields) and functions (in the form of methods).

    //Unlike record types, classes in C# are reference types and two separate instances of same class with identical values are not considered equal
    //unless compared by reference or the equality comparison is overridden in the class.
    
    
    //In C#, both class and record are ways to encapsulate data and behavior, but there are key differences between them.
    // 1. Immutability: By default, the class type in C# is mutable, meaning you can change its properties after creation.
    // On the other hand, record types are immutable by default, so once a record is created, its state cannot be changed.
    // However, you can create a new record by copying an existing record and changing some values, which is known as non-destructive mutation.
    // 2. Equality: In a class, two objects are considered equal if they refer to the same memory location, which is known as reference equality.
    // In a record, two objects are considered equal if both the records have the same values for all properties. This is called value equality.
    // 3. Structural Sharing: Records have built-in support for copying by value and are capable of structural sharing
    // (i.e., if you copy a record and change a value, the unchanged data is shared between the two records).
    // 4. Syntax: record types have a more concise syntax for declaring minimal objects, focusing on properties rather than behavior.

    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public record PersonRecord(string Name, int Age);

}