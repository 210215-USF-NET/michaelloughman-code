## Command Line and Dependencies

 dotnet new console -o HelloWorld
    - make a new console app in a project named HelloWorld
    - It will create a Program.cs file with a Main method
    - It will create a HelloWorld.csproj file


 dotnet new --list
    - provides a list of templates that you might want to choose from

dotnet new classlib -o ToHModels
    - not a console application. It does NOT interact with you by the console. It's a class library, but your console app is going to reference it because it contains your models

dotnet new sln
    - creates the Solution File Template

dotnet sln TourOfHockey.sln add ToHUI
    - add a project to the Solution File
    - checks to see if the Project(folder) has a csproj
    file and if it does, it adds the project to the Solution File

dotnet add reference ../ToHModels 
    - make sure you are in the directory that wants to add the reference
        then make sure you enter the correct path else it won't work. In 
        the example, we went up one directory then into the one we needed

***** .csproj files are there for tracking dependencies ****

dotnet run --project ToHUI 
    -- run the project with program.cs (may need to use dot and slashes to get to the right directory if you are not in it, else just switch into it and run it)

dotnet clean
    -- cleans out previous build