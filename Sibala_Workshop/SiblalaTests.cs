﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sibala_Workshop
{
    [TestFixture]
    public class SiblalaTests
    {
        [Test]
        public void SameBiggerThanHasPoint()
        {
            var deceResult1 = new DiceResult
            {
                Result = DiceResultType.HasPoint,
                Points = 10
            };
            var deceResult2 = new DiceResult
            {
                Result = DiceResultType.Same,
                Points = 4
            };
            var compare = new DiceCompare();
            Assert.AreEqual(-1, compare.Compare(deceResult1, deceResult2));
        }

        [Test]
        public void Test_Input_1234_return_nopoint()
        {
            Dice d = new Dice(1, 2, 3, 4);
            string result = d.Calculate();
            Assert.AreEqual(DiceResultType.NoPoint.ToString(), result);
        }
    }
}