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
                            Task_1_2_4();
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
            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(str1[i]);
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str2.Contains(str1[i]))
                    {
                        Console.Write(str1[i]);                    
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
                        break;
                    }
                }
                if (isWord)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Task_1_2_4()
        {
            string separators = ".!?";
            bool isUpper = true;
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                char appendedChar = str[i];
                if (isUpper)
                {
                    if (char.IsLetter(str[i]))
                    {
                        appendedChar = char.ToUpper(appendedChar);
                        isUpper = false;
                    }
                }
                else if (separators.Contains(str[i]))
                {
                    isUpper = true;
                }
                result.Append(appendedChar);
            }
            Console.WriteLine(result);
        }
    }
}
