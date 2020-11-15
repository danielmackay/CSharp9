using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class InitAccessorsAndReadOnlyFields
    {
        public static void Run() 
        {
            var person = new Person { FirstName = "Mads", LastName = "Nielsen" }; // OK
            //person.LastName = "Torgersen"; // ERROR!
        }

        public class Person
        {
            private readonly string firstName = "<unknown>";
            private readonly string lastName = "<unknown>";

            public string FirstName
            {
                get => firstName;
                init => firstName = (value ?? throw new ArgumentNullException(nameof(FirstName)));
            }
            public string LastName
            {
                get => lastName;
                init => lastName = (value ?? throw new ArgumentNullException(nameof(LastName)));
            }
        }
    }
}
