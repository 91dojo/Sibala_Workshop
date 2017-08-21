using System;
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
        public void Test_Input_1234_return_nopoint()
        {
            Dice d = new Dice(1, 2, 3, 4);
            string result = d.Calculate();
            Assert.AreEqual(DiceResultType.NoPoint.ToString(), result);
        }

        [Test]
        public void Test_Input_1123_return_FivePoint()
        {
            Dice d = new Dice(1, 1, 2, 3);
            string result = d.Calculate();
            Assert.AreEqual("5 Points", result);
        }

        [Test]
        public void Test_Input_1122_return_FivePoint()
        {
            Dice d = new Dice(1, 1, 2, 2);
            string result = d.Calculate();
            Assert.AreEqual("5 Points", result);
        }
    }
}
