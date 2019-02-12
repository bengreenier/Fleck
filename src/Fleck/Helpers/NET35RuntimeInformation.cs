#if NET35
namespace System.Runtime.InteropServices
{
    public static class RuntimeInformation
    {
        public static bool IsOSPlatform(OSPlatform osPlatform)
        {
            // compare the platform in the environment to the given osPlatform
            return CreateFromEnvironmentOS().Equals(osPlatform);
        }

        /// <summary>
        /// Helper to generate environment OSPlatform for the above
        /// </summary>
        /// <returns></returns>
        private static OSPlatform CreateFromEnvironmentOS()
        {
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                case PlatformID.Xbox:
                    return OSPlatform.Windows;
                case PlatformID.MacOSX:
                    return OSPlatform.OSX;
                case PlatformID.Unix:
                    return OSPlatform.Linux;
                default:
                    return OSPlatform.Create(OSPlatform.Literal_Unknown);
            }
        }
    }
}
#endif
