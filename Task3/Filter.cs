using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
Задание 3
Напишите метод, фильтрующий массив на основании
переданных параметров. Метод принимает параметры:
оригинальный_массив, массив_с_данными_для_фильтрации.

Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
Например:
1 2 6 -1 88 7 6 — оригинальный массив;
6 88 7 — массив для фильтрации;
1 2 -1 — результат работы метода.
     
     */
    internal static class Filter
    {
        internal static int[] FilterArray(int[] array, int[] filter)
        {

            if (array == null || filter == null)
            {
                throw new ArgumentNullException();
            }

            int [] result =  Array.FindAll(array, element => !filter.Contains(element));

            return result;

        }
    }
}
