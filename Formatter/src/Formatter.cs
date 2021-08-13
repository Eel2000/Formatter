using Formatter.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Formatter.src
{
    public static class Formatter
    {
        /// <summary>
        ///  Get file's extension its from bytes array.
        /// </summary>
        /// <param name="image"><see cref="byte"/>The array containing image bytes converted</param>
        /// <returns><see cref="string"/> extension</returns>
        public static string Extension(byte[] image)
        {
            try
            {
                _ =MimeTypeHelper.FindMimeFromData(IntPtr.Zero, null, image, image.Length, null, 0, out var extension, 0);

                var mime = Marshal.PtrToStringUni(extension);
                Marshal.FreeCoTaskMem(extension);

                return mime ?? null;

            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// Allows to format file to base64 format for displaying purpose
        /// </summary>
        /// <param name="file">The file byte array</param>
        /// <returns><see cref="string"/> fromatted file</returns>
        public static string Format(byte[] file)
        {
            //get the file extension
            var fileExtension = Extension(file);
            var encodeToBase64 = Convert.ToBase64String(file);//convert bytes array to base64 format
            var formattedFile = $"data:{fileExtension};base64,{encodeToBase64}";

            return formattedFile ?? null;
        }

        public static string Format(string path)
        {

        }
    }
}
