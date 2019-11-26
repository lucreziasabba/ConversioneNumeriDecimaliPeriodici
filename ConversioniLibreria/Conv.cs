using System;

namespace ConversioniLibreria
{
    public class Conv
    {
        public static bool Example1()
        {
            double a = 1.0 / 10.0;
            double prod = a * 10.0;
            if (prod == 1.0)
                return true;
            else
                return false;
        }

        public static bool Example2()
        {
            double a = 1.0 / 10.0;
            double sum = a + a + a + a + a + a + a +a + a + a;
            if (sum == 1)
                return true;
            else
                return false;
        }
    }
}
