using System;
using System.Linq.Expressions;

using static System.Console;

namespace CSharp9.Features
{
    public static class LambdaDiscards
    {
        public static void Run()
        {
            WriteLine(nameof(LambdaDiscards));

            Expression<Func<object, object>> expression = _ => new String("Dan");        
        }
    }
}
