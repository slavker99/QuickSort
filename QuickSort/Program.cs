using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{
    class Program
    {        
        static void Main(string[] args)
        {
            var array = QSort.GenerateArray(5, int.MaxValue);
            //Вывод элементов массива до сортировки
            for (var i = 0; i < array.Length; ++i)
                Console.Write(array[i] + " ");
            QSort.QuickSort(array);
            // Вывод элементов массива после сортировки
            Console.WriteLine();
            for (var i = 0; i < array.Length; ++i)
                Console.Write(array[i] + " ");
        }
    }
}
