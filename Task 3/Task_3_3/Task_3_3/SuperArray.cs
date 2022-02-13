using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3
{
    class SuperArray
    { 
        public static int Summ(int [] arr) => arr.Sum();
        public static double Summ(double[] arr) => arr.Sum();
        public static double Pow2(double n) => n*n;
        public static int Pow2(int n) => n * n;
        public static double Average<T>(double [] arr) => arr.Average();
       public static double Average(double[] arr) => arr.Average();

        public static T TheMostOftenElement<T>(T [] arr) => arr.GroupBy(x => x).OrderByDescending(x => x.Count()).ToDictionary(x => x.Key, x => x.Count()).FirstOrDefault().Key;         
           
        public static void ActionArray<T>(T [] arr, Func<T,T> action) 
        {        
            try
            {
                if (action != null)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = action.Invoke(arr[i]);
                    }
                }
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        
        }
        public static U SearchInArray<T,U> (T[] arr, Func<T[], U> action)
        {
            if (action != null) 
            {
                return action(arr); 
            }
            return default;
        }
    }
}
