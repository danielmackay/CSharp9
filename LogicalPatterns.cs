using System;

namespace CSharp9
{
    public class LogicalPatterns
    {
        public static void Run()
        {
            int? a = 10;

            if (a is not null)
                Console.WriteLine("NOT Null");
            else
                Console.WriteLine("Null");
        }
    }
}
