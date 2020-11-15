using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public class TargetTypedNew
    {
        public static void Run()
        {
            Point p = new(3, 5);

            Point[] ps = { new(1, 2), new(5, 2), new(5, -3), new(1, -3) };
        }

        public record Point(int X, int Y);
    }
}
