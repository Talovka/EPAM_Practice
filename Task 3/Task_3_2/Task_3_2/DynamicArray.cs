using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    class DynamicArray<T> : ICloneable, IEnumerable<T>, IEnumerable
    {

        private const int DefaultCapacity = 8;
        /// <summary>
        /// Закрытый массив, в котором храним данные
        /// </summary>
        private T[] arr;

        /// <summary>
        /// Свойство, показывающее число фактически используемых элементов
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Свойство, показывающее размер массива в памяти
        /// </summary>
        public int Capacity { get; private set; }

        public object Clone()
        {

            return MemberwiseClone();
        }
        /// <summary>
        /// Конструктор по умолчанию, создающий массив из 8-х элементов
        /// </summary>
        public DynamicArray()
        {
            Capacity = DefaultCapacity;
            arr = new T[Capacity];

        }
        /// <summary>
        /// Конструктор , создающий массив из n элементов
        /// </summary>
        public DynamicArray(int n)
        {
            Capacity = n;
            arr = new T[Capacity];
        }
        public DynamicArray(IEnumerable<T> collection)
        {

            arr = new T[collection.Count()];
            Capacity = arr.GetLength(0);
            Length = Capacity;
            for (int i = 0; i < collection.Count(); i++)
            {
                arr[i] = collection.ElementAt(i);
            }
        }
        //Значение свойства Capacity всегда больше или равно значению свойства Length.
        //Если значение свойства Length при добавлении элементов превысит значение свойства Capacity, емкость перед
        //копированием старых элементов и добавлением новых автоматически увеличивается посредством перераспределения внутреннего массива.

        /// Метод добавления элемента
        /// </summary>
        /// <param name="item">добавляемый элемент</param>
        public void Add(T item)
        {
            if (Length == Capacity)// если дошли до конца массива
            {
                IncreaseCapacity();
            }

            // добавляем элемент в конец массива
            arr[Length] = item;
            Length++;
        }
        public void AddRange(IEnumerable<T> collection)
        {
            if (Length == Capacity)// если дошли до конца массива
            {
                IncreaseCapacity(collection.Count());
            }
            for (int i = 0; i < collection.Count(); i++)
            {
                arr[Length] = collection.ElementAt(i);
                Length++;
            }
            // добавляем элемент в конец массива
        }
        public bool Remove(int n)
        {
            if ((n < 0) || (n >= Length))
            {
                return false;
                throw new IndexOutOfRangeException("выход за границу");

            }
            else
                for (int i = n - 1; i < Length - 1; i++)
                {
                    arr[i] = arr[i + 1];

                }
            Length--;
            return true;
        }

        /// <summary>
        /// Свойство-индексатор для получения доступа к элементам массива
        /// </summary>
        /// <param name="n">порядковый номер элемента, с которым будет выполняться
        /// действие</param>    

        // доступ к элементам
        public T this[int n]
        {
            get
            {
                // контроллируем выход за логическую границу массива. Выход за фактическую 
                // границу (n < 0) or (n >= array.Length) контроллирует среда выполнения

                if (n >= Length)
                {
                    throw new ArgumentOutOfRangeException("Выход за границу");

                }
                return arr[n];

            }
            set
            {
                if (n >= Length)
                {
                    throw new ArgumentOutOfRangeException("Выход за границу");

                }
                arr[n] = value;
            }
        }

        public bool Insert(int index, T value)
        {
            if ((index < 0) || (index >= Length))
            {
                throw new ArgumentOutOfRangeException("Выход за границу");
            }
            else
            {
                if (Length == Capacity)// если дошли до конца массива
                {
                    IncreaseCapacity();
                }
                T[] newArray = new T[arr.Length + 1];
                newArray[index] = value;
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = arr[i];
                }
                for (int i = index; i < arr.Length; i++)
                {
                    newArray[i + 1] = arr[i];
                }
                arr = newArray;
                Length++;
                return true;
            }
        }

        private void IncreaseCapacity()
        {
            T[] arr2 = new T[Capacity * 2];

            // копируем в него исходный массив
            for (int i = 0; i < Length; i++)
            {
                arr2[i] = arr[i];
            }

            // переставляем ссылки (память старого массива будет позднее собрана сборщиком мусора)
            arr = arr2;
            this.Capacity *= 2;
        }

        private void IncreaseCapacity(int coll)
        {
            T[] arr2 = new T[Capacity + coll];

            // копируем в него исходный массив
            for (int i = 0; i < Length; i++)
            {
                arr2[i] = arr[i];
            }

            // переставляем ссылки (память старого массива будет позднее собрана сборщиком мусора)
            arr = arr2;
            this.Capacity *= 2;
        }
        public virtual IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
                yield return this[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
