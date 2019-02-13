using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.Test.Unit.Fakes;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class ECSTest
    {
        private ECS _uut;
        private FakeTempSensor _fakeTemp;
        private FakeHeater _fakeHeater;
        [SetUp]
        public void SetUpTest()
        {
            _fakeTemp = new FakeTempSensor();
            _fakeHeater = new FakeHeater();
            _uut = new ECS(5, _fakeTemp, _fakeHeater);
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

        [Test]
        public void ECS_GetCurTemp_ResultEqualsTwenty()
        {
            _fakeTemp.Temp = 20;
            Assert.That(_uut.GetCurTemp(), Is.EqualTo(20));
        }

        [Test]
        public void ECS_Regulate_CallHeaterOff()
        {
            _fakeTemp.Temp = 10; 
            _uut.Regulate();
            Assert.That(_fakeHeater.TurnOffCounter, Is.EqualTo(1));
        }

        [Test]
        public void ECS_Regulate_CallHeaterOn()
        {
            _fakeTemp.Temp = 2;
            _uut.Regulate();
            Assert.That(_fakeHeater.TurnOnCounter, Is.EqualTo(1));
        }

        [Test]
        public void ECS_Regulate_CallHeaterOffThreeTimes()
        {
            _fakeTemp.Temp = 10;
            _uut.Regulate();
            _uut.Regulate();
            _uut.Regulate();
            Assert.That(_fakeHeater.TurnOffCounter, Is.EqualTo(3));
        }


        [Test]
        public void ECS_Regulate_CallHeaterOffAndOnTwoTimes()
        {
            _fakeTemp.Temp = 10;
            _uut.Regulate();
            _fakeTemp.Temp = 2; 
            _uut.Regulate();

            _fakeTemp.Temp = 10;
            _uut.Regulate();
            _fakeTemp.Temp = 2;
            _uut.Regulate();

            Assert.That(_fakeHeater.TurnOffCounter, Is.EqualTo(2));
            Assert.That(_fakeHeater.TurnOnCounter, Is.EqualTo(2));
        }
    }
}
