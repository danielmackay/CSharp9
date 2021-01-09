using CSharp9;
using CSharp9.Features;

using System;

InitAccessorsAndReadOnlyFields.Run();
InitOnlyProperties.Run();
LambdaDiscards.Run();
LocalFunctionAttributes.Run();
LogicalPatterns.Run();
PatternMatching.Run();
Records.Run();
StaticLambda.Run();
TargetTypedNew.Run();

Console.ReadKey();

// References

/* Blog
 * 
 * For any small value based types (i.e. classes used for JSON serialisation), ask yourself if this is just a collection of values
 * and if so consider moving them to records. Also, consdering records can be defined in a single line, you may want to re-consider the 
 * standard rule of one file per type. ;-)
 * 
 * For classes that you've written constructers for with read only properties for immutability.  Consider using init properties instead.
 * 
 * Source Code Generators - use roslyn APIs to add new source code to be compiled into the program.  They cannot modify existing source code.
 * 
 * References
 *   https://www.youtube.com/watch?v=qiuzCWwYe0Y&list=WL&index=1&t=239s
 *   https://www.youtube.com/watch?v=x3kWzPKoRXc&list=WL&index=2
 *   https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9
 *   https://devblogs.microsoft.com/dotnet/c-9-0-on-the-record/
 * */