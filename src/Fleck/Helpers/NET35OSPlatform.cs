#if NET35
namespace System.Runtime.InteropServices
{
    public struct OSPlatform : IEquatable<OSPlatform>
    {
        public static readonly string Literal_Windows = "Windows";
        public static readonly string Literal_OSX = "OSX";
        public static readonly string Literal_Linux = "Linux";
        public static readonly string Literal_Unknown = "Unknown";

        public static OSPlatform Windows
        {
            get
            {
                return Create(Literal_Windows);
            }
        }

        public static OSPlatform OSX
        {
            get
            {
                return Create(Literal_OSX);
            }
        }

        public static OSPlatform Linux
        {
            get
            {
                return Create(Literal_Linux);
            }
        }

        public static OSPlatform Create(string osPlatform)
        {
            return new OSPlatform()
            {
                data = osPlatform
            };
        }

        private string data;

        public bool Equals(OSPlatform other)
        {
            return data.Equals(other.data);
        }
    }
}
#endif
