using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OneDArray array1 = new OneDArray(4);
            //array1.ShowArray();
            //Console.WriteLine(array1.AverageValue());

            //OneDArray array2 = new OneDArray(10, true);
            //array2.ArrayWithoutRepeat();
            //array2.ShowArray();

            MultiDArray multi1 = new MultiDArray(3, 3);
            //Console.WriteLine($"Определитель {multi1.Opredilitel()}");//only for 3x3 array
            multi1.ShowArray();
            multi1.ShowReverseLine();
            //Console.WriteLine(multi1.AverageValue());

            //SteppedArray s1 = new SteppedArray(3);
            //s1.ShowArray();
            //Console.WriteLine($"Среднее значение в массиве { s1.AverageValue()}");
            //Console.WriteLine($"Среднее значение в каждой ступене");
            
            //foreach( double s in s1.AverageInEachArray()) {  
            //    Console.WriteLine(s);
            //}

            //s1.ChangeChet();
            //s1.ShowArray();

            Console.ReadLine();
        }
    }
}
