using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorterApp.Abstracts
{
    public interface ISortingStrategy
    {
        string Sort(string input);
    }
}
