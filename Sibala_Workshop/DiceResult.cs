using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala_Workshop
{
    public enum DiceResultType
    {
        NoPoint,
        HasPoint,
        Same
    }

    public class DiceResult
    {
        public int Points { get; set; }
        public DiceResultType Result { get; set; }
    }
}