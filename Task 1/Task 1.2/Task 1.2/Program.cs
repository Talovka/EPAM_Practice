using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        enum TaskNumber
        {
            Task1 = 1,
            Task2 = 2,
            Task3 = 3,
            Task4 = 4,
            Task5 = 5,
           
        }
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
                            Task_1_2_1();
                        }
                        break;
                    case TaskNumber.Task2:
                        {
                            Task_1_2_2();
                        }
                        break;
                    case TaskNumber.Task3:
                        {
                            Task_1_2_3_first();
                        }
                        break;
                    case TaskNumber.Task4:
                        {
                            Task_1_2_3_second();
                        }
                        break;
                    case TaskNumber.Task5:
                        {
                            //Task_1_1_4();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        static void Task_1_2_1()
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            double sum = 0;
            double count = 0;
            string[] words = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                bool isWord = false;
                foreach (var item in word)
                {
                    if (!char.IsPunctuation(item))
                    {
                        isWord = true;
                        sum++;
                    }
                }
                if (isWord)
                {
                    count++;
                }
            }

            double res = sum / count;
            Console.WriteLine("Average length of stirng: {0}", res);
        }
        static void Task_1_2_2()
        {
            Console.Write("Enter string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            char[] mass1 = str1.ToCharArray();
            char[] mass2 = str2.ToCharArray();
            for (int i = 0; i < mass1.Length; i++)
            {
                Console.Write(mass1[i]);
                for (int j = 0; j < mass2.Length; j++)
                {
                    if (mass1[i] == mass2[j])
                    {
                        Console.Write(mass1[i]);
                        
                        break;
                    }
                }

            }
            Console.WriteLine();
        }
        static void Task_1_2_3_first()
        {
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            int count = 0;

            string[] words = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (Char.IsUpper(word[0]))
                {
                    continue;
                }
                bool isWord = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!char.IsPunctuation(word[i]))
                    {
                        isWord = true;

                    }
                }
                if (isWord)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Task_1_2_3_second()
        {
            
        }
    }
}
