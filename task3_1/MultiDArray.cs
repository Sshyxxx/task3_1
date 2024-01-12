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
        private int _row;
        private int _col;

        public MultiDArray(int row, int collumn, bool isUser = false) 
        {
            _array = new int[row, collumn];
            _row = row;
            _col = collumn;
            if (!isUser)
            {
                _array = GetRandomValues(row, collumn);
            }
            else
            {
                _array = GetIntValues(row, collumn);
            }
        }

        public int[,] GetIntValues(int row, int collumn)
        {
            int[,] array = new int[row, collumn];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < collumn; j++)
                {
                    Console.WriteLine($"элемент № {j}");

                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        public int[,] GetRandomValues(int row, int collumn)
        {
            int[,] array = new int[row, collumn];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < collumn; j++)
                {
                    array[i, j] = random.Next(0, 255);
                }
            }
            return array;
        }

        public void ShowArray()
        {
            for (int i = 0; i < _array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < _array.Length / (_array.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(_array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void ShowReverseLine()
        {
            for (int i = 0; i < _array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < _array.Length / (_array.GetUpperBound(0) + 1); j++)
                {
                    if (i % 2 == 0)
                        Console.Write(_array[i, _col - j-1] +"\t");
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
            for (int i = 0; i < _row; i++)
            {
                for (int j=0; j<_col; j++)
                {
                    sum += _array[i, j];
                    count++;
                }
            }

            return sum / count;
        }
    }
}
