using System;
using System.Runtime.InteropServices;

namespace Formatter.Helpers
{
    public static class MimeTypeHelper
    {
        /// <summary>
        /// Get a pointer value on the passed bytes array
        /// </summary>
        /// <param name="pBC"></param>
        /// <param name="pwzUrl"></param>
        /// <param name="pBuffer"></param>
        /// <param name="cbSize"></param>
        /// <param name="pwzMimeProposed"></param>
        /// <param name="dwMimeFlags"></param>
        /// <param name="ppwzMimeOut"></param>
        /// <param name="dwReserved"></param>
        /// <returns><see cref="IntPtr"/> pointer</returns>
        [DllImport("urlmon.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = false)]
        public static extern int FindMimeFromData(IntPtr pBC,
        [MarshalAs(UnmanagedType.LPWStr)] string pwzUrl,
        [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.I1, SizeParamIndex=3)]
        byte[] pBuffer,
        int cbSize,
        [MarshalAs(UnmanagedType.LPWStr)] string pwzMimeProposed,
        int dwMimeFlags,
        out IntPtr ppwzMimeOut,
        int dwReserved);
    }
}
