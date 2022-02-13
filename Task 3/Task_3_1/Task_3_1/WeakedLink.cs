using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_1
{
    class WeakedLink
    {
		private List<int> list;
		private const int ConstWeaked = 2;

		public int Count { get; init; }
		public int WeakedNumber { get; init; }
		public WeakedLink(int count)
		{
			Count = count;
			WeakedNumber = ConstWeaked;
			list = new List<int>(Count);
			FillList();
		}
		public WeakedLink(int count, int weaked_number)
		{
			Count = count;
			WeakedNumber = weaked_number;
			list = new List<int>(Count);
			FillList();
		}

		private void FillList()
		{
			for (int i = 1; i < list.Capacity + 1; i++)
			{
				this.list.Add(i);
			}
		}
		public void Start()
		{
			for (int i = 1; ; i++)
			{
				if (list.Count >= WeakedNumber)
				{
					list.RemoveAt(WeakedNumber - 1);
					list.Sort();
					Console.WriteLine($"Раунд {i}. Вычеркнут человек. Людей осталось {list.Count}");
				}
				else break;
			}
			Console.WriteLine("Игра окончена, невозможно вычеркнуть больше людей");
		}
	}
}
