using System;

namespace GenericsProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To generics Programming");
            MaxOfThree max = new MaxOfThree();
            Console.WriteLine(max.MaxOfThreeNumbers(45, 75, 35));
        }
    }
}
