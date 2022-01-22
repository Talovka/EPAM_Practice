using System;
using StringLibrary;

namespace _2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringforexample = new char[13] { 'I','t','s',' ','m','u','s','t', ' ', 'h','a','v','e'};
            var MyStringforexample = new char[1] { '!' };
            MyString firstString = new MyString(stringforexample);
            MyString secondString = new MyString(MyStringforexample);
            MyString cocnatString = firstString.Concat(secondString);
            Console.WriteLine(cocnatString.ToString());
            Console.WriteLine(firstString[7]);
            Console.WriteLine(cocnatString.FindNumberChar('!')); 
           
            Console.WriteLine(cocnatString.FunnyString()); 
        }
    }


}
