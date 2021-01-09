using static System.Console;

namespace CSharp9
{
    public class LogicalPatterns
    {
        public static void Run()
        {
            WriteLine(nameof(LogicalPatterns));

            int? a = 10;

            // NOT NULL logical pattern
            if (a is not null)
                WriteLine("NOT Null");

            // OR logical pattern
            if (a is 10 or 11)
                WriteLine("a is 10 or 11");

            // Relational patterns
            if (a is < 11)
                WriteLine("a is less than 11");

            // AND logical pattern
            if (a is > 9 and < 11)
                WriteLine("a is greated than 9 and less than 11");
        }
    }
}
