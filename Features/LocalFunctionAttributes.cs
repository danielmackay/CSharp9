using System.Diagnostics.CodeAnalysis;

using static System.Console;

namespace CSharp9.Features
{
    public class LocalFunctionAttributes
    {
        public static void Run()
        {
            WriteLine(nameof(LocalFunctionAttributes));

            RunInternal();

            // Nullabe attributes are now allowed on local functions
            [return: NotNull]
            static int? RunInternal()
            {
                WriteLine("Local Function Attributes");
                return 1;
            }
        }
    }
}
