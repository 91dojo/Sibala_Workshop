﻿using System;
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
        Points,
        Same,
        EighteenLa
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
            int diceCount = DiceList.GroupBy(x => x).Where(g => g.Count() > 1).Count();
            var temp = DiceList.GroupBy(x => x);
            foreach (var item in temp)
            {
                item.ToString();
            }
            if (diceCount == 0) {
                return DiceResultType.NoPoint.ToString();
            }

<<<<<<< HEAD
            return "5 " + DiceResultType.Points.ToString();
        }
=======
        public DiceResult GetResult()
        {
            return new DiceResult();
        }
    }

    public class DiceResult
    {
        public int MaxPoint { get; set; }
        public int Points { get; set; }
        public DiceResultType Result { get; set; }
>>>>>>> e03e88590d360f0bcb764938fe554551b5ab238a
    }
}