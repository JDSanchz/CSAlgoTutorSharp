using System;

namespace Sorts
{
    public static class MergeSort
    {
        public static void LearnMergeSort()
        {
            Console.WriteLine("Learning Merge Sort...");
            Console.WriteLine("Definition: Merge Sort is a divide-and-conquer algorithm.");
            Console.WriteLine("Key Fact 1: It has an average time complexity of O(n log n).");
            Console.WriteLine("Key Fact 2: It requires O(n) additional storage.");
            Console.WriteLine("Key Fact 3: It is a stable sort.");

            // Ask the user to return to the main menu
            Console.WriteLine("\nWould you like to return to the main menu? (y/n)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "y")
            {
                IniMenu.DisplayMenu(); // Call the menu display method from IniMenu
            }
        }

        public static void PerformMergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                Console.WriteLine($"Dividing array into two halves: {string.Join(",", arr[left..(middle + 1)])} and {string.Join(",", arr[(middle + 1)..(right + 1)])}");
                
                PerformMergeSort(arr, left, middle);
                PerformMergeSort(arr, middle + 1, right);

                Console.WriteLine("Press Enter to proceed to the next step.");
                Console.ReadLine();

                Merge(arr, left, middle, right);
            }
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            // Copy data to temporary arrays L[] and R[]
            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                R[j] = arr[middle + 1 + j];

            Console.WriteLine($"Left array: {string.Join(",", L)}");
            Console.WriteLine($"Right array: {string.Join(",", R)}");

            // Merging the temp arrays back into arr[left..right]
            int index1 = 0, index2 = 0;

            // Initial index of merged subarray
            int mergedIndex = left;

            while (index1 < n1 && index2 < n2)
            {
                Console.WriteLine($"Comparing {L[index1]} and {R[index2]}...");

                if (L[index1] <= R[index2])
                {
                    arr[mergedIndex] = L[index1];
                    Console.WriteLine($"Adding {L[index1]} to the merged array.");
                    index1++;
                }
                else
                {
                    arr[mergedIndex] = R[index2];
                    Console.WriteLine($"Adding {R[index2]} to the merged array.");
                    index2++;
                }
                mergedIndex++;
            }

            // Copy the remaining elements of L[], if any
            while (index1 < n1)
            {
                arr[mergedIndex] = L[index1];
                Console.WriteLine($"Adding remaining elements. Adding {L[index1]} to the merged array.");
                index1++;
                mergedIndex++;
            }

            // Copy the remaining elements of R[], if any
            while (index2 < n2)
            {
                arr[mergedIndex] = R[index2];
                Console.WriteLine($"Adding remaining elements. Adding {R[index2]} to the merged array.");
                index2++;
                mergedIndex++;
            }

            Console.WriteLine($"Merged array: {string.Join(",", arr[left..(right+1)])}");
        }

    }
}