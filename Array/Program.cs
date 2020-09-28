using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppingList = { "milk", "bread", "WC paper", "cookies", "pork"};

            int arrayLength = shoppingList.Length;
            Console.WriteLine($"You have {arrayLength} items on your list.");

        }
    }
}
