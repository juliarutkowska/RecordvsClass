namespace RecordvsClass;

    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public record PersonRecord(string Name, int Age);

// Now, let's create instances and compare equality
    var personClass1 = new PersonClass { Name = "Jake", Age = 30 };
    var personClass2 = new PersonClass { Name = "Jake", Age = 30 };

    var personRecord1 = new PersonRecord("Jake", 30);
    var personRecord2 = new PersonRecord("Jake", 30);

    Console.WriteLine(personClass1 == personClass2);  // Outputs: False
    Console.WriteLine(personRecord1 == personRecord2); // Outputs: True
    
    
//When comparing the class instances (personClass1 and personClass2), even though they have the same property values, the equality comparison returns False.
//This is because classes in C# use reference equality by default;
//since personClass1 and personClass2 are separate objects in memory, they are not considered equal.

//In contrast, when comparing the record instances (personRecord1 and personRecord2), the equality comparison returns True.
//This is because records in C# use value equality;
//since personRecord1 and personRecord2 have the same values for their properties, they are considered equal.