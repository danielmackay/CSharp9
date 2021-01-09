using static System.Console;

namespace CSharp9
{
    public class InitOnlyProperties
    {        
        public static void Run()
        {
            WriteLine(nameof(InitOnlyProperties));

            // Properties can only be set during object initialisers
            var person = new Person { FirstName = "Mads", LastName = "Nielsen" }; // OK
            
            //person.LastName = "Torgersen"; // ERROR!
        }

        public class Person
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }
    }
}
