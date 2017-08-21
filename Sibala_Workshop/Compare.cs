using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala_Workshop
{
    public class DiceCompare : IComparer<DiceResult>
    {
        public int Compare(DiceResult x, DiceResult y)
        {
            if (x.Result > y.Result) return 1;
            if (x.Result == y.Result) return 0;
            return -1;
        }
    }
}