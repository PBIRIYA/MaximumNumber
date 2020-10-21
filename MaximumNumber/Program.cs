using System;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Number Check Using Generics!");
            Console.WriteLine("Find max Number");
            MaximumNumberCheck MaxInt = new MaximumNumberCheck();
            int output = MaxInt.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            float floatoutput = MaxInt.MaximumFloatNumber(111.2f, 22.45f, 78.56f);
            Console.WriteLine(floatoutput);
        }
    }
}
