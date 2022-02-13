using System;

namespace Task_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperString str = new SuperString();
            int[] arr = new[] { 1, 3, 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine($"{SuperArray.Summ(arr)}");
            SuperArray.ActionArray(arr, SuperArray.Pow2);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"{SuperArray.SearchInArray(arr,SuperArray.TheMostOftenElement)}");
        }
    }
}
