using StringSorterApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorterApp.Models
{
    public class QuickSortStrategy : ISortingStrategy
    {
        public string Sort(string input)
        {
            char[] chars = input.ToCharArray();
            QuickSort(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private void QuickSort(char[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private int Partition(char[] array, int low, int high)
        {
            char pivot = array[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    // Swap
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            // Swap
            char temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
