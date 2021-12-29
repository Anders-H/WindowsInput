using System.Drawing;
using System.Runtime.InteropServices;

namespace WindowsInput
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WindowsMessage
    {
        public IntPtr handle;
        public uint msg;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public Point p;
    }
}