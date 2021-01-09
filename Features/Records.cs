using System.Text.Json;

using static System.Console;

namespace CSharp9
{
    public class Records
    {

        public static void Run()
        {
            WriteLine(nameof(Records));

            // Record Constructor
            var p1 = new Person("Jared", "Parsons");
            var p2 = new Person("Rich", "Lander");

            // Record Serialisation
            var json = JsonSerializer.Serialize(p1);
            WriteLine(json);
            var p3 = JsonSerializer.Deserialize<Person>(json);

            // Record Equality
            WriteLine($"p1 == p3: {p1 == p3}");  // True
            WriteLine($"p1 Equals p3: {Equals(p1, p3)}");  // True
            WriteLine($"p1 ReferenceEquals p3: {ReferenceEquals(p1, p3)}"); // False

            // Record deconstruction
            var (firstName, lastName) = p1;
            WriteLine($"{lastName}, {firstName}");

            // Record pattern matching
            WriteLine($"Is Rich in the chat {IsInChat(p2)}");

            // Imutability
            // p1.FirstName = "Dan";
            // The above will not work so instead we must mutate the object as follows
            var p4 = p1 with { FirstName = "Dan" };

            // Improve ToString()
            WriteLine(p4.ToString());

            static bool IsInChat(Person p) => p switch
            {
                ("Jared", "Parsons") => true,
                ("Rich", "Lander") => true,
                _ => false
            };
        }

        public record Person(string FirstName, string LastName);
    }
}
