using System;


namespace Sorts
{
    public static class QuickSort
    {
        public static void LearnQuickSort()
        {
            Console.WriteLine("Learning Quick Sort...");
            Console.WriteLine("Definition: Quick Sort is a divide-and-conquer algorithm.");
            Console.WriteLine("Key Fact 1: It has an average time complexity of O(n log n).");
            Console.WriteLine("Key Fact 2: It sorts in-place, requiring no additional storage.");
            Console.WriteLine("Key Fact 3: It is not a stable sort.");

            // Ask the user to return to the main menu
            Console.WriteLine("\nWould you like to return to the main menu? (y/n)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                IniMenu.DisplayMenu(); // Call the menu display method from IniMenu
            }
        }

        public static void PerformQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                Console.WriteLine($"Subarray to sort: {string.Join(",", arr[low..(high + 1)])}");

                int pi = Partition(arr, low, high);

                Console.WriteLine("Press Enter to proceed to the next step.");
                Console.ReadLine();

                PerformQuickSort(arr, low, pi - 1); // Before pi
                PerformQuickSort(arr, pi + 1, high); // After pi
            }
        }
        private static int Partition(int[] arr, int low, int high)
        {
            Console.WriteLine($"Using {arr[high]} as pivot...");
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                Console.WriteLine($"Comparing {arr[j]} with pivot {pivot}...");
                if (arr[j] < pivot)
                {
                    i++;
                    if (arr[i] != arr[j])
                    {
                        Console.WriteLine($"Swapping {arr[i]} and {arr[j]}...");
                    }
                    SortUtility.Swap(ref arr[i], ref arr[j]);
                    Console.WriteLine($"Array after swap: {string.Join(",", arr)}");
                }
            }

            if (arr[i + 1] != arr[high])
            {
                Console.WriteLine($"Final swap: {arr[i + 1]} and {arr[high]}...");
            }
            SortUtility.Swap(ref arr[i + 1], ref arr[high]);
            Console.WriteLine($"Array after final swap: {string.Join(",", arr)}");

            return (i + 1);
        }
    }
}