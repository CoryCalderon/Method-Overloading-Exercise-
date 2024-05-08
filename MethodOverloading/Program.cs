using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static void Main()
        {
            var intAdd = Add(2, 2);
            Console.WriteLine(intAdd);

            var doubleAdd = Add(3, 3);
            Console.WriteLine(doubleAdd); 

            var boolAdd = Add(0, 1, true);
            Console.WriteLine(boolAdd);

        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;

            if (isTrue && sum > 1)
            {
                return $"Your total is {sum} dollars!";
            }
            else
            {
                return $"Your total is {sum} dollar!";
            }
        }
    }

}
