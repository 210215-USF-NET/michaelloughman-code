## Data Types ##

- A typical C# program uses types from the class library and user-defined typed that model the concepts to the program's problem domain

- You use data types to structure the data that you process in your program

- Setting a data type is also a form of validation that leverages the strong typing of C#

- Fun Fact! All types ingerit from System.Object base class. This is a fancy way of saying that all data types are objects

- Two major data types
- 1. Value Types
- 2. Reference Types

## Common Type System ##

- The CTS is a standard definition of the types in .NET compliant languages

- Language Interoperability
    -- Basically, in one  solution, your projects can be written in multiple .NET compliant langauges
    -- You can have a project written in VB.NET and reference that same project in a project written in C#

## Value Type ##
- Analogous to java's primitives
- derived from System.Value
- Stored in the stack and not the heap
-   Stored in heap means that when accessing the value of a variable set to value type, you get the value directly and not a reference to where the value is stored in the heap. (Because variables are stored in stack and the actual objects they reference are stored in the heap)
-  There's no separate heap allocation or garbage collection overhead for value-type variables

- TWO CATEGORIES
1. Structs - used to create custom value types
2. Enums - defines a set of named integral constants

## Reference Types ##
- A type that is defined as a class, delegate, array, interface
- At runtime when you declare a variable of a reference type, the variable contains the value null until you explicitly create an object by using the new operator or assign it an object that has been created elsewhere
- Note that reference types are stored in the heap. The stack holds the reference to a place in the that contains the actual value of the object