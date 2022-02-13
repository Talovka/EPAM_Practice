using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class RunText
    {
        private Dictionary<string, int> words;
        private char[] separators = new char[] { ' ', '.', ',', '!', '?', '"', ';', ':', ')', '(', '-', '+', '=', ',', '/' };
        public RunText()
        {
            TextAnalyser();
            OutputTextAnalyser();
        }
        private void TextAnalyser()
        {
            string text = Check();
            words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).GroupBy(x => x).OrderByDescending(x => x.Count()).ToDictionary(x => x.Key, x => x.Count());
            Console.WriteLine("Count of words");

            foreach (var w in words)
            {
                Console.WriteLine($"{w.Key}: {w.Value}");
            }
        }
        private void OutputTextAnalyser()
        {
            Console.WriteLine("Output");
            if (words.First().Value == words.Last().Value)
            {
                Console.WriteLine($"Each word ised n-times: {words.First().Value}");
            }
            else
            {
                Console.WriteLine("The most useful words:");
                foreach (var w in words)
                {
                    if (w.Value < words.First().Value)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{w.Key}: {w.Value}");
                    }
                }
            }
        }
        private string Check()
        {
            string text;
            try
            {
                do
                {
                    Console.WriteLine("Input text: ");
                    return text = Console.ReadLine();
                } while (string.IsNullOrEmpty(text));
            }
            catch (Exception)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
