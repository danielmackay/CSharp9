using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class Records
    {
        public static void Run()
        {
            var person = new Person { FirstName = "Mads", LastName = "Nielsen" };

            // Mutation
            var otherPerson = person with { LastName = "Torgersen" };

            var originalPerson = otherPerson with { LastName = "Nielsen" };

            if (person == originalPerson)
                Console.WriteLine("People are equal by ref");
            else
                Console.WriteLine("People are NOT equal by ref");

            if (person.Equals(originalPerson))
                Console.WriteLine("People are equal by val");
            else
                Console.WriteLine("People are NOT equal by val");
        }


        public record Person
        {
            public string? FirstName { get; init; }
            public string? LastName { get; init; }
        }
    }

    
}
