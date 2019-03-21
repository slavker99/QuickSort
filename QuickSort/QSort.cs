using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{
   public class QSort
    {
       public static int[] GenerateArray(int lenght, int value = int.MaxValue)
       {
           var rnd = new Random();
           //rnd.Next(); // возвращает случайное число от 0 до int.MaxValue
           //rnd.Next(0, 10); // возвращает случайное число от 0 до 4 включительно
           var array = new int[lenght];
           for (var i = 0; i < lenght; ++i)
               array[i] = rnd.Next(0, value);
           return array;
       }

        public static void QuickSort(int[] array)
        {
           Sort(array, 0, array.Length-1);            
        }

        public static void Sort(int[] array, int left, int right)
        {
            ///////////////////////////////////
            int pivot; // разрешающий элемент
            int l_hold = left; //левая граница
            int r_hold = right; // правая граница
            pivot = array[left];
            while (left < right) // пока границы не сомкнутся
            {
                while ((array[right] >= pivot) && (left < right))
                    right--; // сдвигаем правую границу пока элемент [right] больше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    array[left] = array[right]; // перемещаем элемент [right] на место разрешающего
                    left++; // сдвигаем левую границу вправо 
                }
                while ((array[left] <= pivot) && (left < right))
                    left++; // сдвигаем левую границу пока элемент [left] меньше [pivot]
                if (left != right) // если границы не сомкнулись
                {
                    array[right] = array[left]; // перемещаем элемент [left] на место [right]
                    right--; // сдвигаем правую границу вправо 
                }
            }
            array[left] = pivot; // ставим разрешающий элемент на место
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot) // Рекурсивно вызываем сортировку для левой и правой части массива
                Sort(array, left, pivot - 1);
            if (right > pivot)
                Sort(array, pivot + 1, right);
        }
    }
}
