using System;
using System.Collections.Generic;
namespace collections
{
    class GenericListActivity
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3); 
            numbers.Add(4); 
            numbers.Add(5);
            Console.WriteLine("Original List: ");
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            } 
            //sorting
            numbers.Sort();
            Console.WriteLine("\n SORTED LIST: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(numbers);
            }
            //REMOVE
            numbers.Remove(2);
            Console.WriteLine("\n List after removal: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}