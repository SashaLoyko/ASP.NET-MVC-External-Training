using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{

    /// <summary>
    ///  В классе Sort
    ///  собранны разные 
    ///  методы сортировки
    /// </summary>
    public class Sort
    {

        /// <summary>
        ///  Метод MergeSort выполняет 
        ///  сортировку методом слияния
        /// </summary>
        public static int[] MergeSort(int[] Array)
        {
            if (Array.Length == 1)
                return Array;
            int MidPoint = Array.Length / 2;
            return Merge(MergeSort(Array.Take(MidPoint).ToArray()), MergeSort(Array.Skip(MidPoint).ToArray()));
        }
        private static int[] Merge(int[] Arr1, int[] Arr2)
        {
            int a = 0, b = 0;
            int[] SortedArray = new int[Arr1.Length + Arr2.Length];
            for (int i = 0; i < Arr1.Length + Arr2.Length; i++)
            {
                if (b < Arr2.Length && a < Arr1.Length)
                    if (Arr1[a] > Arr2[b] && b < Arr2.Length)
                        SortedArray[i] = Arr2[b++];
                    else
                        SortedArray[i] = Arr1[a++];
                else
                    if (b < Arr2.Length)
                    SortedArray[i] = Arr2[b++];
                else
                    SortedArray[i] = Arr1[a++];
            }
            return SortedArray;
        }
    }
}
