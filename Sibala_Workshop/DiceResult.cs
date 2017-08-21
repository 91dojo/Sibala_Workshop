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
        BG,
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
            DiceList = new List<int>();
            DiceList.Add(p1);
            DiceList.Add(p2);
            DiceList.Add(p3);
            DiceList.Add(p4);
        }

        public string Calculate()
        {
            return DiceResultType.NoPoint.ToString();
        }

    }
}