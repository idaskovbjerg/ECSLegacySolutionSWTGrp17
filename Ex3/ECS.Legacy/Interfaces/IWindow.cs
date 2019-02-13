using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Interfaces
{
    public interface IWindow
    {
        bool isOpen();
        bool isClosed();
    }
}
