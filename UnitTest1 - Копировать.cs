using Microsoft.VisualStudio.TestTools.UnitTesting;
using pasvitaslab;
using System.Collections.Generic;
using System.Linq;

namespace pasvitaslabtest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void DataProcessingTest1()
        {
            List<Icomponent> scraps = new List<Icomponent>();
            scraps.Add(new Detail(1, 2, 3));
            scraps.Add(new ComPart(24, 16, 8, 10));
            scraps.Add(new Detail(5, 9, 3));
            scraps.Add(new Detail(18, 10, 12));
            scraps.Add(new ComPart(5, 4, 7, 19));
            List<Icomponent> assert = DataProcessor<Icomponent>.DataProcessing(scraps);
            Assert.IsTrue(assert.Count() == 1);

        }
        public void DataProcessingTest2()
        {
            List<Icomponent> scraps = new List<Icomponent>();
            scraps.Add(new Detail(1, 2, 3));
            scraps.Add(new ComPart(24, 16, 8, 10));
            scraps.Add(new Detail(5, 9, 3));
            scraps.Add(new Detail(18, 11, 12));
            scraps.Add(new ComPart(5, 4, 7, 19));

            List<Icomponent> expect = new List<Icomponent>();

            expect.Add(new ComPart(24, 16, 8, 10));
            expect.Add(new Detail(18, 11, 12));

            List<Icomponent> assert = DataProcessor<Icomponent>.DataProcessing(scraps);
            Assert.AreEqual(expect[1].Cost, assert[1].Cost);

            Assert.AreEqual(expect[3].Cost, assert[3].Cost);


        }
        [TestMethod]
        public void Search_Test1()
        {
            List<Icomponent> scraps = new List<Icomponent>();

            scraps.Add(new Detail(12, 5, 1));
            scraps.Add(new Detail(12, 10, 2));
            scraps.Add(new ComPart(4, 8, 3, 17));
            scraps.Add(new Detail(12, 12, 1));
            scraps.Add(new ComPart(5, 11, 1, 74));

            List<Icomponent> expect = new List<Icomponent>();
            List<Icomponent> assert = DataProcessor<Icomponent>.Search(scraps, 12);
            expect.Add(new Detail(12, 12, 1));

            Assert.AreEqual(expect[0].Cost, assert[0].Cost);
        }
        public void Search_Test2()
        {
            List<Icomponent> scraps = new List<Icomponent>();

            scraps.Add(new Detail(12, 5, 1));
            scraps.Add(new Detail(12, 10, 2));
            scraps.Add(new ComPart(4, 8, 3, 17));
            scraps.Add(new Detail(12, 12, 1));
            scraps.Add(new ComPart(5, 11, 1, 74));

            List<Icomponent> expect = new List<Icomponent>();
            List<Icomponent> assert = DataProcessor<Icomponent>.Search(scraps, 5);
            expect.Add(new Detail(12, 5, 1));

            Assert.AreEqual(expect[0].Cost, assert[0].Cost);
        }

    }
}

