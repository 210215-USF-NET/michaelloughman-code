## CLR (Common Language Runtime)

- Runtime that manages a bunch of stuff, garbage collection, etc.
- JIT (Just in time) compiler - Takes in code, transforms code into machine code that machine understands, the machine can run your code

## obj, bin folders

- build output
- result of running dotnet build

## dotnet run

- dotnet build + run the code

## dotnet build

- compiles code

## TLDR compilation process:

.cs file > compiled using MSBUILD > IL (Intermediate Language) > CLR (common language runtime) processed by JIT > machine code

## SDK vs Runtime

- The software dvlpmnt kit (SDK) includes everything you need to build and run .NET core apps
    using command line tools and and any editor (including Visual Studio)

- The runtime include only the resources needed to run existing .NET Core applications
- The runtime is included in the SDK

## .NET

- is a free and opensource development platform for building  many kind of apps such as console apps, web apps,
    games, etc

- in a nutshell, .NET is a collection of libraries and languages that work together to build all kinds of apps

## .NET 5

- cross platform implementation of .NET
- This is the main implementation of .NET going forward
- .NET 5.0 supports more types of apps and more platforms than .NET Core or .NET Framework

## C#

- is a modern, object oriented, type safe, programming language
- object oriented means that everything is based on objects and the relationships between them
- type safe means that once you set a variable type you can't change it. It will cause an error

## Development Platform

- collection of librairies and languages that you can use to develop applications as well as runtime implementations 
    to run your apps on

## Components of a .NET implementation

- 1. One or more runtimes
    ex: .NET Framework CLR, .NET 5 CLR

- 2. A class llibrary
    ex: .NET Framework Base Class Library, .NET 5 BCL

- 3. Optionally, one or more application frameworks
    ex: ASP.NET, Windows Forms, Windows Presentation Foundation are included in .NET Framework and .NET 5

- 4. Optionally, development tools

## .NET Standard

- A set of APIs that are implemented by the Base Class Library of a .NET implementation
- The BCL provides classes and types that are helpful in performing day to day ops
    ex: dealing with string and primitive types, database connection, IO operations