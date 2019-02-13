using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class ECSTest
    {
        private ECS _uut;
        [SetUp]
        public void SetUpTest()
        {
            _uut = new ECS(5, new FakeTempSensor(), new FakeHeater());
        }

        [Test]
        public void ECS_GetThreshold_ResultIsTrue()
        {
            var result = _uut.GetThreshold();
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void ECS_RunSelfTest_ResultIsTrue()
        {
            var result = _uut.RunSelfTest();
            Assert.That(result, Is.EqualTo(true));
        }


        

    }
}
