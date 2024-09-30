using StringSorterApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorterApp.Dto
{
    public class SortRequestDto
    {
        public string InputString { get; set; }
        public SortStrategyType SortStrategy { get; set; }
    }
}
