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

    public class Dice
    {
        public List<int> DiceList { get; set; }
        public Dice(int p1, int p2, int p3, int p4)
        {

        }
    }
}