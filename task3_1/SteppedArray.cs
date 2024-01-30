using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_1
{


    internal class SteppedArray
    {
        private int[][] _array;
        private int _size;

        public SteppedArray(int size, bool isUser = false)
        {
            _size = size;
            _array = new int[size][];

            if (!isUser)
            {
                _array = GetRandomValues(size);
            }
            else
            {
                _array = GetIntValues(size);
            }
        }

        public int[][] GetIntValues(int size)
        {
            int[][] array = new int[size][];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Сколько элементов в ступене массива？");
                int collumn = int.Parse(Console.ReadLine());
                array[i] = new int[collumn];

                for (int j = 0; j < collumn; j++)
                {
                    Console.WriteLine($"элемент № {i}{j}");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public int[][] GetRandomValues(int size)
        {
            int[][] array = new int[size][];
            Random random = new Random();

            for (int i = 0; i < _array.Length; i++)
            {
                int col = random.Next(3, 10);
                array[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    array[i][j]=random.Next(0,10);
                }
            }
            return array;
        }

        public void ShowArray()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    Console.Write(_array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }


        public double AverageValue() 
        { 
            double sum = 0;
            double count = 0;
            foreach (int[] item in _array)
            {
                sum += item.Sum();
                count+=item.Length;
            }
            return sum/count;
        }

        public double[] AverageInEachArray()
        {
            double[] averageArray = new double[_array.Length];
            double sum = 0;
            double count = 0;
            int i = 0;
            foreach (int[] item in _array)
            {
                sum = item.Sum();
                count = item.Length;
                averageArray[i++]=sum/count;
            }
            return averageArray;
        }

        public void ChangeChet()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    if(_array[i][j] % 2 == 0)
                    {
                        _array[i][j] = i * j;
                    }
                }
            }
        }
    }
}
