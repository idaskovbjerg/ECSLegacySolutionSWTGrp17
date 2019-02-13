using System;
using ECS.Legacy.Interfaces;

namespace ECS.Legacy
{
    internal class Window : IWindow
    {
        private bool open = false;
        public bool isOpen()
        {
            open = true;
            return open;
        }
        
        public bool isClosed()
        {
            open = false;
            return open;
        }
    }
}