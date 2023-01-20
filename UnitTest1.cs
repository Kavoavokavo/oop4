using Microsoft.VisualStudio.TestTools.UnitTesting;
using pasvitaslab;
using System.Collections.Generic;

namespace pasvitaslabtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFindMaxCost1()
        {
            List<Icomponent> scraps = new List<Icomponent>();
            scraps.Add(new Detail(1, 2, 3));
            scraps.Add(new ComPart(24, 16, 8, 10));
            scraps.Add(new Detail(5, 9, 3));
            scraps.Add(new Detail(18, 10, 12));
            scraps.Add(new ComPart(5, 4, 7, 19));
            int expect = Program.FindMaxCost(scraps);
            int assert = 16;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMaxCost2()
        {
            List<Icomponent> scraps = new List<Icomponent>();
            scraps.Add(new Detail(1, 2, 3));
            scraps.Add(new ComPart(24, 19, 8, 10));
            scraps.Add(new Detail(5, 9, 3));
            scraps.Add(new Detail(18, 19, 12));
            scraps.Add(new ComPart(5, 4, 7, 19));
            int expect = Program.FindMaxCost(scraps);
            int assert = 19;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMaxPower1()
        {
            List<Detail> details = new List<Detail>();
            details.Add(new Detail(1, 2, 3));
            details.Add(new ComPart(24, 16, 8, 10));
            details.Add(new Detail(5, 9, 3));
            details.Add(new Detail(18, 10, 12));
            details.Add(new ComPart(5, 4, 20, 19));
            int expect = Program.FindMaxPower(details);
            int assert = 20;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMaxPower2()
        {
            List<Detail> details = new List<Detail>();
            details.Add(new Detail(1, 2, 3));
            details.Add(new ComPart(24, 16, 8, 10));
            details.Add(new Detail(5, 9, 3));
            details.Add(new Detail(18, 10, 12));
            details.Add(new ComPart(5, 4, 23, 19));
            int expect = Program.FindMaxPower(details);
            int assert = 23;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMiddlePower1()
        {
            List<Detail> details = new List<Detail>();
            details.Add(new Detail(1, 2, 3));
            details.Add(new ComPart(24, 16, 8, 10));
            details.Add(new Detail(5, 9, 3));
            details.Add(new Detail(18, 10, 12));
            details.Add(new ComPart(5, 4, 7, 19));
            double expect = Program.FindMiddlePower(details);
            double assert = 6.6;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMiddlePower2()
        {
            List<Detail> details = new List<Detail>();
            details.Add(new Detail(1, 2, 18));
            details.Add(new ComPart(24, 16, 9, 10));
            details.Add(new Detail(5, 9, 14));
            details.Add(new Detail(18, 10, 1));
            details.Add(new ComPart(5, 4, 7, 112));
            double expect = Program.FindMiddlePower(details);
            double assert = 9.8;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMiddleCost1()
        {
            List<Icomponent> scraps = new List<Icomponent>();
            scraps.Add(new Detail(1, 2, 3));
            scraps.Add(new ComPart(24, 16, 8, 10));
            scraps.Add(new Detail(5, 9, 3));
            scraps.Add(new Detail(18, 10, 12));
            scraps.Add(new ComPart(5, 4, 7, 19));
            double expect = Program.FindMiddleCost(scraps);
            double assert = 8.2;
            Assert.AreEqual(expect, assert);
        }
        public void TestFindMiddleCost2()
        {
            List<Icomponent> scraps = new List<Icomponent>();
            scraps.Add(new Detail(1, 2, 3));
            scraps.Add(new ComPart(50, 16, 8, 10));
            scraps.Add(new Detail(1, 9, 3));
            scraps.Add(new Detail(23, 10, 12));
            scraps.Add(new ComPart(5, 4, 7, 19));
            double expect = Program.FindMiddleCost(scraps);
            double assert = 16;
            Assert.AreEqual(expect, assert);
        }
    }
}

