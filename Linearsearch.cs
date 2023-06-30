using System;

namespace LinearSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an array
            int[] array = { 5, 2, 7, 9, 1, 3 };

            // Prompt the user to enter the target element
            Console.Write("Enter the target element: ");
            int target = Convert.ToInt32(Console.ReadLine());

            // Perform linear search
            int result = LinearSearch(array, target);

            // Display the result
            if (result == -1)
            {
                Console.WriteLine("Target element not found.");
            }
            else
            {
                Console.WriteLine("Target element found at index: " + result);
            }
        }

        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i; // Found the target element at index i
            }
            return -1; // Target element not found
        }
    }
}