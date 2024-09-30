using StringSorterApp.Abstracts;
using StringSorterApp.Dto;
using StringSorterApp.Enums;
using StringSorterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorterApp.Service.SortService
{
    public class SortService
    {
        public SortResponseDto SortString(SortRequestDto request)
        {
            ISortingStrategy selectedStrategy;

            switch (request.SortStrategy)
            {
                case SortStrategyType.BubbleSort:
                    selectedStrategy = new BubbleSortStrategy();
                    break;
                case SortStrategyType.QuickSort:
                    selectedStrategy = new QuickSortStrategy();
                    break;
                default:
                    throw new InvalidOperationException("Invalid sorting strategy selected.");
            }

            var sortedString = selectedStrategy.Sort(request.InputString);

            return new SortResponseDto { SortedString = sortedString };
        }
    }
}
