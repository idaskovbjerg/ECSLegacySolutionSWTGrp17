using ECS.Legacy.Interfaces;

namespace ECS.Legacy.Test.Unit.Fakes
{
    public class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }

        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
