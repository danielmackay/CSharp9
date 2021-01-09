using static System.Console;

namespace CSharp9.Features
{
    public class StaticLambda
    {
        public static void Run()
        {
            WriteLine(nameof(StaticLambda));

            RunInternal();

            // Previously this static expression, would have to be a static local function
            static void RunInternal() => WriteLine("Static Lambda");
        }
    }
}
