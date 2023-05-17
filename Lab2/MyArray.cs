using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class MyArray : IArrays
    {
        private double[] _array;
        private int _size;
        public MyArray()
        {
            _size = 3;
            _array = new double[_size];
        }
        public MyArray(int size)
        {
            _size = size;
            _array = new double[size];
        }
        public void FillRand()
        {
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
                _array[i] = rand.Next(-50, 51);
        }
        public void Show()
        {
            for (int i = 0; i < _array.Length; i++)
                Console.Write($"{_array[i]}    ");
            Console.WriteLine();
        }
        public int Search(int value)
        {
            return SearchAlgs.LinearSearch(_array, value);
        }

        public void Sort()
        {
            SortAlgs.BubbleSort(this._array);
        }
        public void Insert()
        {

        }
    }
}
