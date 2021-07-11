using System;

namespace GenericsProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To generics Programming");
            int[] array = { 5, 8, 3, 4, 7 };
            MaxOfThree<int> findMaxArray = new MaxOfThree<int>(array);
            findMaxArray.FindMaxOfArray();
            
        }
    }
}
