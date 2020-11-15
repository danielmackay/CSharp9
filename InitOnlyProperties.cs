namespace CSharp9
{
    public class InitOnlyProperties
    {        
        public static void Run()
        {
            var person = new Person { FirstName = "Mads", LastName = "Nielsen" }; // OK
            //person.LastName = "Torgersen"; // ERROR!
        }

        public class Person
        {
            public string? FirstName { get; init; }
            public string? LastName { get; init; }
        }
    }
}
