using System;
namespace StringLibrary
{
    public class MyString
    {
        private char[] _myString;

        public MyString(char[] myString)
        {
            _myString = myString;
        }
        public char this[int index]
        {
            get => _myString[index];
            set => _myString[index] = value;
        }
      
        public MyString Concat(char c)
        {
            var res = new char[_myString.Length + 1];
            _myString.CopyTo(res, 0);
            res[res.Length - 1] = c;
            return new MyString(res);
        }
        public MyString Concat(MyString secondString)
        {
            var res = new char[_myString.Length + secondString._myString.Length];
            _myString.CopyTo(res, 0);
            secondString._myString.CopyTo(res, _myString.Length);
            return new MyString(res);
        }
        public bool IsDifforEquals(char[] firstString, char[] otherString)
        {
            if (firstString.Length != otherString.Length)
                return false;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (Equals(firstString[i], otherString[i]))
                    return false;
            }
            return true;
        }     
        public int FindNumberChar(char c)
        {
            for (int i = 0; i < _myString.Length; i++)
            {

                if (Equals(c, _myString[i]))
                    return i;
            }
            Console.WriteLine("Такого символа в строке нет");
            return -1;      
        }

        public char[] ToCharArray()
        {
            var arr = new char[_myString.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = _myString[i];
            }

            return arr;
        }
        public override string ToString()
        {
            return new string(_myString);
        }
        public MyString FunnyString()
            {
            char[] test = new char[this._myString.Length];
            for (int i = 0; i < _myString.Length; i++)
            {
                if (i%2==0)
                {
                     test[i]= char.ToUpper(_myString[i]);
                }
                else { test[i] = char.ToLower(_myString[i]); }             
            }
            return new MyString(test);
            }
    }
}
