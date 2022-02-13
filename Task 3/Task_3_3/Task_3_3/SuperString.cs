using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_3_3
{
    enum Language
    {
        None = 0,
        Russian = 1,
        English = 2,
        Number = 3,
        Mixed = 4
    }
    class SuperString
    {
        private List<Language> _langs = new List<Language>();
        private string _str;
        public SuperString()
        {
            CheckLanguage();
        }
        private void CheckLanguage()
        {
            _str = Check();
            if (Regex.IsMatch(_str, "[а-яА-ЯеЁ]"))
            {
                _langs.Add(Language.Russian);
            }
            if (Regex.IsMatch(_str, "[a-zA-Z]"))
            {
                _langs.Add(Language.English);
            }
            if (Regex.IsMatch(_str, "[0-9]"))
            {
                _langs.Add(Language.Number);
            }
            if (_langs.Count > 1)
            {
                Console.WriteLine(Output(Language.Mixed));
            }
            else
                Console.WriteLine(Output(_langs.FirstOrDefault()));
        }
        private string Output(Language lang) => lang switch
        {
            Language.Russian => "Russian",
            Language.English => "English",
            Language.Number => "Number",
            Language.Mixed => "Mixed",
            _ => "none"
        };
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
