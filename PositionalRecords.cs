using System;

namespace CSharp9
{
    public class PositionalRecords
    {
        public static void Run()
        {
            var person = new Person("Mads", "Torgersen"); // positional construction
            var (f, l) = person;                          // positional deconstruction

            Console.WriteLine(f);
            Console.WriteLine(l);
        }

        /// <summary>
        /// This declares the public init-only auto-properties and the constructor and the deconstructor
        /// </summary>
        public record Person(string FirstName, string LastName);
    }
}
