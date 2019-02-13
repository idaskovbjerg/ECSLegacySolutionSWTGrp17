using ECS.Legacy.Interfaces;

namespace ECS.Legacy.Test.Unit.Fakes
{
    public class FakeWindow : IWindow
    {
        public bool window { get; set; } = False;

        public bool isOpen() => window;

        public bool isClosed() => !window;
    }
}
