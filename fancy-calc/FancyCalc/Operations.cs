using System;

namespace FancyCalc
{
    public static class Operations
    {
        public static int Plus(int x, int y)
        {
            // TODO #1. Uncomment the line below and remove the line that throws NotImplementedException.
            return x + y;
        }

        public static int Minus(int x, int y)
        {
            // TODO #2. Replace "x + y - x" in the next line with "x - y".
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            // TODO #3. Add a breakpoint to the next line, run the unit test in the debug mode, and inspect the result during the program execution.
            int result = x * y;
            return result;
        }

        public static int Sum(int x1, int x2, int x3)
        {
            // TODO #4. Add a breakpoint to the next line, run the unit test in the debug mode, and trace the program execution.
            int sum = x1 + x2 + x3;
            return sum;
        }
    }
}
