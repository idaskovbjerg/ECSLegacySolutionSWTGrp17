using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.Interfaces;

namespace ECS.Legacy.Test.Unit
{
    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
