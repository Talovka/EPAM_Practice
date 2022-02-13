using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class WeakedLinkStart
    {
        public WeakedLinkStart()
        {
            StartWeakedLink();
        }
        public static void StartWeakedLink()
        {
            Console.WriteLine("Введите число игроков:");
            int count = IntInput();
            Console.WriteLine("Введите, какой по счету человек будет вычеркиваться каждый ход:");
            int weaked_number = IntInput();
            WeakedLink weak = new WeakedLink(count, weaked_number);
            Console.WriteLine("Игра началась");
            weak.Start();
        }
        private static int IntInput()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Ошибка. Введите положительное число: ");
            }
            return n;
        }
    }
}
