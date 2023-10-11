using System;

namespace Sorts
{
    public static class BubbleSort
    {
        public static void LearnBubbleSort()
        {
            Console.WriteLine("Learning Bubble Sort...");
            Console.WriteLine("Definition: Bubble Sort is a simple comparison-based sorting algorithm.");
            Console.WriteLine("Key Fact 1: It has an average time complexity of O(n^2).");
            Console.WriteLine("Key Fact 2: It sorts in-place, requiring no additional storage.");
            Console.WriteLine("Key Fact 3: It is a stable sort.");

            // Ask the user to return to the main menu
            Console.WriteLine("\nWould you like to return to the main menu? (y/n)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                IniMenu.DisplayMenu(); // Call the menu display method from IniMenu
            }
        }

        public static void PerformBubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            Console.WriteLine($"Initial array: {string.Join(",", arr)}");

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.WriteLine($"Comparing {arr[j]} and {arr[j + 1]}...");
                    if (arr[j] > arr[j + 1])
                    {
                        Console.WriteLine($"Swapping {arr[j]} and {arr[j + 1]}...");
                        SortUtility.Swap(ref arr[j], ref arr[j + 1]);
                        Console.WriteLine($"Array after swap: {string.Join(",", arr)}");
                        swapped = true;
                    }
                }

                // If the inner loop didn't swap any elements, the array is sorted
                if (!swapped)
                {
                    Console.WriteLine("Array is sorted. Exiting.");
                    break;
                }

                Console.WriteLine("Press Enter to proceed to the next step.");
                Console.ReadLine();
            }

            Console.WriteLine($"Sorted array: {string.Join(",", arr)}");
        }
    }
}
