using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isim = new MyList<string>();
            isim.Add("Mahmut Can");
            isim.Add("Engin");
            Console.WriteLine(isim.Count);

        }

        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;

            public MyList()
            {
                _array = new T[0];
            }

            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _array[i];
                }

                _array[_array.Length - 1] = item;
            }

            public int Count
            {
                get { return _array.Length; }
            }

        }
    }
}
