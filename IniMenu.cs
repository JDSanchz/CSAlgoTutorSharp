using System;

namespace Sorts
{
    public static class IniMenu
    {
        public static void DisplayMenu()
        {
            while (true) // keep the menu looping until the user decides to exit
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Learn about Quick Sort");
                Console.WriteLine("2. Learn about Merge Sort");
                Console.WriteLine("3. Learn about Bubble Sort");
                Console.WriteLine("4. Run a sorting demo");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        QuickSort.LearnQuickSort(); 
                        break;
                    case "2":
                        MergeSort.LearnMergeSort();
                        break;
                    case "3":
                        BubbleSort.LearnBubbleSort(); 
                        break;
                    case "4":
                        RunSortingDemo(); 
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the Sorting Algorithm Educational Program!");
                        return; 
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            }
        }

        private static readonly Dictionary<string, Action> sortDemoActions = new Dictionary<string, Action>
        {
            { "1", RunQuickSortDemo },
            { "2", RunMergeSortDemo },
            { "3", RunBubbleSortDemo }
        };

        private static void RunSortingDemo()
        {
            while (true)
            {
                DisplaySortMenu();

                string demoChoice = Console.ReadLine();

                if (demoChoice == "4") return; // Go back to the main menu

                if (sortDemoActions.TryGetValue(demoChoice, out Action selectedDemo))
                {
                    selectedDemo.Invoke();
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select again.");
                }
            }
        }

        private static void DisplaySortMenu()
        {
            Console.WriteLine("\nSelect a sorting algorithm demo to run:");
            Console.WriteLine("1. Quick Sort Demo");
            Console.WriteLine("2. Merge Sort Demo");
            Console.WriteLine("3. Bubble Sort Demo");
            Console.WriteLine("4. Go back to the main menu");
        }

        private static int[] ReadAndConvertInput()
        {
            Console.WriteLine("Please enter a list of integers separated by spaces:");
            string input = Console.ReadLine();
            return Array.ConvertAll(input.Split(' '), int.Parse);
        }

        private static void RunQuickSortDemo()
        {
            int[] arr = ReadAndConvertInput();
            Console.WriteLine("Performing Quick Sort...");
            QuickSort.PerformQuickSort(arr, 0, arr.Length - 1);
        }

        private static void RunMergeSortDemo()
        {
            int[] arr = ReadAndConvertInput();
            Console.WriteLine("Performing Merge Sort...");
            MergeSort.PerformMergeSort(arr, 0, arr.Length - 1);
        }

        private static void RunBubbleSortDemo()
        {
            int[] arr = ReadAndConvertInput();
            Console.WriteLine("Performing Bubble Sort...");
            BubbleSort.PerformBubbleSort(arr);
        }

    }
}