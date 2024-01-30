using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_1
{
    internal class MultiDArray
    {
        
        private int[,] _array;

        public MultiDArray(int row, int collumn, bool isUser = false) 
        {
            _array = new int[row, collumn];
            if (!isUser)
            {
                GetRandomValues();
            }
            else
            {
                GetIntValues();
            }
        }

        public void GetIntValues()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.WriteLine($"элемент № {j}");

                    _array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void GetRandomValues()
        {
            Random random = new Random();
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    _array[i, j] = random.Next(0, 255);
                }
            }
        }

        public void ShowArray()
        {
            int rows = _array.GetLength(0);
            int columns = _array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(_array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ShowReverseLine()
        {
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.Length / _array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                        Console.Write(_array[i, _array.GetLength(1) - j-1] +"\t");
                    else
                        Console.Write(_array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public double AverageValue()
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j=0; j< _array.GetLength(1); j++)
                {
                    sum += _array[i, j];
                    count++;
                }
            }

            return sum / count;
        }

        //public double Opredilitel()
        //{
        //    int[,] a = _array;
        //    return a[0, 0] * a[1,1] * a[2,2] + a[2,0]* a[0,1] * a[1,2] + a[0,2] * a[1,0] * a[2,1] - a[2,0] * a[1,1] * a[0,2] - a[1,0] * a[0,1] * a[2,2] - a[2,1] * a[1,2] * a[0,0];
        //}
    }
}
