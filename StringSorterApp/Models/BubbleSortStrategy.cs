using StringSorterApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorterApp.Models
{
    public class BubbleSortStrategy : ISortingStrategy
    {
        public string Sort(string input)
        {
            char[] chars = input.ToCharArray();
            int n = chars.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        // Swap
                        char temp = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                    }
                }
            }

            return new string(chars);
        }
    }
}
