using System;
using System.Collections.Generic;


namespace Task_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int>();
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr4 = new int[] { 1, 2, 3, 4, 5 };
            List<double> list1 = new List<double>();
            list1.Add(1.2);
            DynamicArray<double> arr3 = new DynamicArray<double>(list1);
            DynamicArray<int> arr2 = new DynamicArray<int>(arr1);
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            PrintArray(arr3);
            arr2.Insert(3, 5);

            arr2.AddRange(arr4);
            PrintArray(arr2);
            CycledDynamicArray<int> arr6 = new CycledDynamicArray<int>(arr1);

            foreach (var item in arr6)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintArray<T>(DynamicArray<T> arr)
        {
            Console.WriteLine("Capacity: {0} Count: {1}", arr.Capacity, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
