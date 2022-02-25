using System;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point n = new Point(1,2);
            Point n2 = new Point(1, 3);
            Raynor ran = new Raynor(n2);
            GunPatron bonus = new GunPatron(n);
            Console.WriteLine($"Местоположение Рейнора:{ran.ItemLocation}, Количество патронов:{ran.GunCapacity}, Уровень:{ran.Level}");
            Console.WriteLine($"Обозначение бонуса добавления патрона:{bonus}");
            bonus.BonusEffect(ran);
            Console.WriteLine($"Количество патронов:{ran.GunCapacity}");
            ran.Move(n);
            Console.WriteLine($"Местоположение Рейнора:{ran.ItemLocation}");
            if (ran.ItemLocation == bonus.ItemLocation) 
            {
                bonus.BonusEffect(ran);
                Console.WriteLine($"Количество патронов:{ran.GunCapacity}");
            }
            Console.WriteLine($"Количество здоровья {ran.Health}");
            Console.WriteLine($"Количество патронов:{ran.GunCapacity}");
            
            //*необходимо добавить заполнение массива элементами в нужном порядке и настроить коллизию объектов+ движение монстров и игрока
        }
    }
}
