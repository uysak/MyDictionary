using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> d1 = new MyDictionary<int, string>();

            d1.Add(12," aa");

        }




    }


    class MyDictionary<T1, T2>
    {
        T1[] _array;
        T2[] _array2;

        T1[] tempArray;
        T2[] tempArray2;
        public MyDictionary()
        {
            _array = new T1[0];
            _array2 = new T2[0];

        }

        public void Add( T1 key, T2 value)
        {
            tempArray = _array;
            tempArray2 = _array2;

            _array = new T1[_array.Length + 1];
            _array2 = new T2[_array2.Length + 1];

            for ( int i = 0; i < tempArray.Length ; i++)
            {
                _array[i] = tempArray[i];
                _array2[i] = tempArray2[i];
            }
            _array[_array.Length - 1] = key;
            _array2[_array2.Length - 1] = value;
        }


    }
}
