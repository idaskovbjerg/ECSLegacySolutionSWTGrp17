using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.Interfaces;

namespace ECS.Legacy.Fakes
{
    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 1;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
