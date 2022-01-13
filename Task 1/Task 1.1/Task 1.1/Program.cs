using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    enum TextStyle
    {
        None,
        Bold,
        Italic,
        Underline
    }
    enum TaskNumber
    { 
        Task1=1,
        Task2=2,
        Task3=3,
        Task4=4,
        Task5=5,
        Task6=6,
        Task7=7,
        Task8=8,
        Task9=9,
        Task10=10,
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter task number: ");
                int n = int.Parse(Console.ReadLine());
                TaskNumber number = (TaskNumber)n;
                switch (number)
                {
                    case TaskNumber.Task1:
                        {
                            Task_1_1_1();
                        }
                        break;
                    case TaskNumber.Task2:
                        {
                            Task_1_1_2();
                        }
                        break;
                    case TaskNumber.Task3:
                        {
                            Task_1_1_3();
                        }
                        break;
                    case TaskNumber.Task4:
                        {
                            Task_1_1_4();
                        }
                        break;
                    case TaskNumber.Task5:
                        {
                            Task_1_1_5();
                        }
                        break;
                    case TaskNumber.Task6:
                        {
                            Task_1_1_6();
                        }
                        break;
                    case TaskNumber.Task7:
                        {
                            Task_1_1_7();
                        }
                        break;
                    case TaskNumber.Task8:
                        {
                            Task_1_1_8();
                        }
                        break;
                    case TaskNumber.Task9:
                        {
                            Task_1_1_9();
                        }
                        break;
                    case TaskNumber.Task10:
                        {
                            Task_1_1_10();
                        }
                        break;
                    default:
                        break;
                }
            }

        }
        static void Task_1_1_1()
        {
            Console.Write("Enter lenght of the rectangle (only integer):");
            int a = CheckInput();
            Console.Write("Enter width of the rectangle (only integer):");
            int b = CheckInput();
            Square(a, b);

        }

        static int CheckInput()
        {
            int param = int.Parse(Console.ReadLine());
            if (param > 0)
            {
                return param;
            }
            Console.Write("Entered value is negative or equal to zero, try again:");
            return CheckInput();
        }

        static void Square(int a, int b)
        {
            Console.WriteLine("{0}", a * b);
        }

        static void Task_1_1_2()
        {
            int[] arr = new int[NumEnter()];
            OutputSymbol(arr);
        }
        private static int NumEnter()
        {
            int num;
            string tmp;
            bool check;
            do
            {
                Console.Write("Enter size of pyramide: ");
                tmp = Console.ReadLine();
                check = int.TryParse(tmp, out num);
                if (check)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong number");
                    continue;
                }
            } while (true);
            return num;
        }
        private static void OutputSymbol(int[] arr)
        {
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write("*");
                }
                count++;
                Console.WriteLine();
            }
        }
        static void Task_1_1_3()
        {
            int num;
            Console.Write("Enter size N:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = num - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");

                }
                for (int l = i; l > 0; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Task_1_1_4()
        {

            Console.Write("Enter size N:");
            string n = Console.ReadLine();

            int tre = int.Parse(n);
            int col = int.Parse(n) * 2 - 1;

            char[] mas = new char[col];

            for (int i = 0; i < col; i++)
            {
                mas[i] = '*';
            }
            int middle = col / 2;
            int middleconst = col / 2;
            int length = 1;
            int lengthconst = 1;

            for (int l = 1; l <= tre; l++)
            {
                for (int i = 0; i < l; i++)
                {

                    for (int j = 0; j <= col; j++)
                    {
                        if (j == middle)
                        {
                            for (int k = 1; k <= length; k++)
                            {
                                Console.Write(mas[j]);
                            }

                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                    middle--;
                    length = length + 2;
                    Console.WriteLine();
                    if (middle < 0) { break; }

                }
                middle = middleconst;
                length = lengthconst;
            }
        }
        static void Task_1_1_5()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum = sum + i;
            }
            Console.WriteLine(sum);
        }
        static void Task_1_1_6()
        {
            bool[] arr = { false, false, false };
            while (true)
            {
                Console.WriteLine("Параметры записи: {0} ", DisplayStyle(arr));
                DisplayMenu();
                int n = int.Parse(Console.ReadLine());
                if (n==0)
                {
                    break;
                }
                Toggle(arr, n - 1);
            }
        }
        static string DisplayStyle(bool[] arr)
        {
            string result = "";
            bool none = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    if (result.Length > 0)
                    {
                        result += ", ";
                    }
                    result += ((TextStyle)(i + 1));
                    none = false;
                }

            }
            if (none)
            {
                result = TextStyle.None.ToString();
            }
            return result;
        }
        static void Toggle(bool[] arr, int n)
        {
            arr[n] = !arr[n];

        }
        static void DisplayMenu()
        {
            Console.WriteLine("Enter: ");
            for (int i = 0; i < Enum.GetNames(typeof(TextStyle)).Length - 1; i++)
            {
                Console.WriteLine("    {0}: {1}", i + 1, ((TextStyle)(i + 1)));
                
            }
            Console.WriteLine("Enter 0 for exit from task6");
        }
        static void Task_1_1_7()
        {

            int[] arr1;
            arr1 = CreateArray();
            OutputArray(arr1);
            Minimum(arr1);
            Maximum(arr1);
            Sort(arr1);
            OutputArray(arr1);
        }
        //поиск минимума
        static void Minimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min number of the array: {0}", min);
        }
        //поиск максимума
        static void Maximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max number of the array: {0}", max);
        }
        //сортировка пузырьком
        static int[] Sort(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int z = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = z;
                    }
                }
            }
            return arr;
        }

        static int[] CreateArray()
        {
            int[] arr = new int[20];

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);

            }

            return arr;
        }

        static void OutputArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{1} ", i + 1, arr[i]);
            }
            Console.WriteLine();
        }
        static void Task_1_1_8()
        {

            int[,,] arr = CreateDoubleArray();
            OutputArray(arr);

        }
        static int[,,] CreateDoubleArray()
        {
            int[,,] myarr = new int[10, 10, 10];
            Random r = new Random();
            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr.GetLength(1); j++)
                {
                    for (int k = 0; k < myarr.GetLength(2); k++)
                    {
                        myarr[i, j, k] = r.Next(-250, 250);
                    }
                }
            }

            return myarr;
        }
        static void OutputArray(int[,,] myarr)
        {
            int count = 0;
            for (int i = 0; i < myarr.GetLength(0); i++)
            {
                for (int j = 0; j < myarr.GetLength(1); j++)
                {
                    for (int k = 0; k < myarr.GetLength(2); k++)
                    {
                        if (myarr[i, j, k] > 0)
                        {
                            myarr[i, j, k] = 0;
                            Console.WriteLine("Сoordinates of the modified elements: x={0} y={1} z={2} ", i, j, k);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("All changes: {0}", count);

        }
        static void Task_1_1_9()
        {
            int[] arr = new int[10];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-50, 50);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine("Non-negative sum: {0}", sum);
        }
        static void Task_1_1_10()
        {
            int[,] arr = FillArray();
            OutputArray(arr);

        }

        static int[,] FillArray()
        {
            int[,] arr = new int[10, 10];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-50, 50);
                }
            }
            return arr;

        }

        static void OutputArray(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0 && i + j != 0)
                    {
                        sum += arr[i, j];
                        Console.WriteLine("Even number of the array: {0} {1} = {2}", i, j, arr[i, j]);
                    }
                }
            }
            Console.WriteLine(sum);
        }

    }
}
