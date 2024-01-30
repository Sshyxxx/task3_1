using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_1
{
    internal class OneDArray
    {
        private int[] _array;

        public int[] Array { get { return _array; } }

        public OneDArray(int size, bool isUser = false)
        {
            _array = new int[size];

            if (!isUser)
            {
                GetRandomValues(size);
            }
            else
            {
                GetIntValues(size);
            }

        }

        public void GetIntValues(int size)
        {
            Console.WriteLine("введите " + size + " элементов ");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine($"элемент № {i}");
                _array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void GetRandomValues(int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                _array[i] = random.Next(0, 255);
            }
        }

        public void ShowArray()
        {
            foreach (int i in _array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public double AverageValue()
        {
            int count = _array.Length;
            double sum = 0;
            for (int i = 0; count > i; i++)
            {
                sum += _array[i];
            }
            return sum / count;
        }

        public void DeleteSpecialValues()
        {
            int[] b = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                if (Math.Abs(_array[i]) >= 100)
                {
                    b[i] = _array[i];
                }
            }
            _array = b;
        }

        public void ArrayWithoutRepeat()
        {
            int[] temp = new int[_array.Length];

            for (int i = 0, q = 0; i < _array.Length; i++)
            {
                if (!isInArray(temp, _array[i]))
                {
                    temp[q] = _array[i];
                    q++;
                }
            }
            _array = temp;
        }

        static bool isInArray(int[] a, int el)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == el)
                {
                    return true;
                }
            }
            return false;

        }
    }


}
