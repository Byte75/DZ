using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using coords;

namespace coordsTests
{
    [TestFixture]
    public class coordsTests
    {
        [Test]
        public void CoordsCreated()
        {
            var c = new Coords("23.8976,12.3218");
            Assert.NotNull(c);
        }
        [Test]
        public void Coords1Works()
        {
            var c = new Coords("23.8976,12.3218");
            Assert.AreEqual("X: 23,8976 Y: 12,3218", c.FineForm());
        }
        [Test]
        public void Coords2Works()
        {
            var c = new Coords("25.76,11.9463");
            Assert.AreEqual("X: 25,76 Y: 11,9463", c.FineForm());
        }
        [Test]
        public void Coords3Works()
        {
            var c = new Coords("24.8293,12.2");
            Assert.AreEqual("X: 24,8293 Y: 12,2", c.FineForm());
        }
        [Test]
        public void WhatTheFuckWeHaveInData()
        {
            var c = new Coords("24.8293,12,2");
            Assert.AreEqual("Координаты введены в неверном формате : 24.8293,12,2", c.FineForm());
        }
        [Test]
        public void WhatTheFuckWeHaveInData2()
        {
            var c = new Coords("дебил");
            Assert.AreEqual("Координаты введены в неверном формате : дебил", c.FineForm());
        }
        [Test]
        public void WhatTheFuckWeHaveInData3()
        {
            var c = new Coords("12.1");
            Assert.AreEqual("Координаты введены в неверном формате : 12.1", c.FineForm());
        }
        [Test]
        public void WhatTheFuckWeHaveInData4()
        {
            var c = new Coords("12.1.3.14");
            Assert.AreEqual("Координаты введены в неверном формате : 12.1.3.14", c.FineForm());
        }
        [Test]
        public void WhatTheFuckWeHaveInData5()
        {
            var c = new Coords("12 , 15.3.4");
            Assert.AreEqual("Координаты введены в неверном формате : 12 , 15.3.4", c.FineForm());
        }
    }
}
