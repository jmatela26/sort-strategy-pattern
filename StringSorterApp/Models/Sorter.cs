using StringSorterApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorterApp.Models
{
    public class Sorter
    {
        private ISortingStrategy _sortingStrategy;

        public Sorter(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        public void SetStrategy(ISortingStrategy strategy)
        {
            _sortingStrategy = strategy;
        }

        public string Sort(string input)
        {
            return _sortingStrategy.Sort(input);
        }
    }
}
