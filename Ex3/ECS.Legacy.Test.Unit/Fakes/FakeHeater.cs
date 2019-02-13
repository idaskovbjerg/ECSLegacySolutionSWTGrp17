using ECS.Legacy.Interfaces;

namespace ECS.Legacy.Test.Unit.Fakes
{
    public class FakeHeater : IHeater
    {
        public int TurnOffCounter { get; set; }
        public int TurnOnCounter { get; set; } = 0;

        public void TurnOn()
        {
            TurnOnCounter++;
        }

        public int TurnOnTimesCalled()
        {
            return TurnOnCounter;
        }


        public void TurnOff()
        {
            TurnOffCounter++;
        }

        public int TurnOffTimeCalled()
        {
            return TurnOffCounter; 
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
