using StringSorterApp.Abstracts;
using StringSorterApp.Enums;
using StringSorterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringSorterApp.Controllers
{
    public class SorterController
    {
        private Sorter _sorter;

        public SorterController()
        {
            // Default strategy
            _sorter = new Sorter(new BubbleSortStrategy());
        }

        public void SetStrategy(ISortingStrategy strategy)
        {
            _sorter.SetStrategy(strategy);
        }

        public string SortInput(string input)
        {
            return _sorter.Sort(input);
        }
    }
}
