using static System.Console;

namespace CSharp9
{
    public class TargetTypedNew
    {
        public static void Run()
        {
            WriteLine(nameof(TargetTypedNew));

            // no need to specity Point twice
            Point p = new(3, 5);

            // Point can be inferred in all usages in RHS of statement
            Point[] ps = { new(1, 2), new(5, 2), new(5, -3), new(1, -3) };
        }

        public record Point(int X, int Y);
    }
}
