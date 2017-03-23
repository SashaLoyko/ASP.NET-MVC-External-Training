using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serch
{
    public class Serch
        {

        /// <summary>
        /// Метод EqualSumLeftRightSides преднозначен
        /// для поиска индекса, для которого сумма элементов слева от него 
        /// равно сумме элементов справа
        /// </summary>
        public static int EqualSumLeftRightSides(int[] Arr)
        {
            int[] Left = new int[Arr.Length];
            int[] Right = new int[Arr.Length];
            
            for (int i = 0; i < Arr.Length; i++)
            {

                Array.Copy(Arr, Left, i); // Копирование левой части
                int SumLeft = Left.Sum(); // Сумма для левой части

                int j = Arr.Length - (i + 1);         //интервал копирования для правой части 
                Array.Copy(Arr, i + 1, Right, 0, j);  // копирование правой части
                int SumRight = Right.Sum();           // Сумма для правой части


                if (SumLeft == SumRight)
                {
                    return i;
                }
                Array.Clear(Right, 0, Arr.Length);
            }

            return -1;

        }

        /// <summary>
        /// Метод StringСoncatenation 
        /// конкатенирует строки без повторений
        /// </summary>
        public static string StringСoncatenation(string a, string b)
        {

            string AllSrting = a + b;
            AllSrting = new string(AllSrting.Distinct().ToArray());
            return AllSrting;

        }

        /// <summary>
        /// Метод StringAlphabet
        /// Сортирует строку по алфавиту
        /// </summary>
        public static string StringAlphabet(string a)
        {
            char[] letters = a.ToCharArray();
            IEnumerable<char> query = from letter in letters
                                      orderby letter
                                      select letter;         
            string Result = String.Concat<char>(query);
            return Result;

        }

        /// <summary>
        /// Вставки одного числа в другое 
        /// </summary>
        public static int Insert(int number1, int number2, int index1, int index2)
        {
           
            var array1 = new BitArray(new int[] { number1 });
            var array2 = new BitArray(new int[] { number2 });

            int j = 0;
            for (int i = index1; i <= index2; i++, j++)
            {
                array1[i] = array1[i] | array2[j];
            }

            int[] array3 = new int[1];
            array1.CopyTo(array3, 0);
            return array3[0];
        }
    }
}
