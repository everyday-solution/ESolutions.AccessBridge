# ESolutions.AccessBridge
An ActiveX bridge to use .NET WinForms in Microsoft Access.

# Introduction
There are thousands of MsAccess applications out in the wild. They almost all come from a cycle I call the Excel-Cycle-Of-Death. Young engineer gets a task assignment and created and excel table. Later he uses formulas and macros. In the end he teaches himself VBA and solves a problem in short time for little money. And then this thing grows and increases in size and get slower and unmaintainable. At that point he tries to solve hi new problem with the next level: MsAccess.
Of course this does not solve the problems of a software project but only those of the engineer.

After many years and uncountable hours of work the engineer is prometed or leaves and the mess is complete. At that point a professional is hired and asked to maintain the 'software' and of course he has issues with source code management, multiple programmers to the same mdb, databases and a dozend more hurdles that makes it impossible to keep working in the Access environment.

# Solution
This project can be used to keep the Access solution as it is an incorporate DotNet-Views in the existing Access mdb. This AccessBridge establishes a ActiveX component that can be used by Access and display dotnet views inside the existing access application. By upscaling the Access database to SQL there is a common data store for both worlds and so each Access view can be migrated one by one to the dot net world.
