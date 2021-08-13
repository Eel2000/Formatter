using Formatter.Helpers;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Formatter.src
{
    public static class Formatter
    {
        /// <summary>
        ///  Get file's extension from its bytes array.
        /// </summary>
        /// <param name="file"><see cref="byte"/>The array containing file bytes converted</param>
        /// <returns><see cref="string"/> file's extension</returns>
        public static string GetExtension(byte[] file)
        {
            try
            {
                _ = MimeTypeHelper.FindMimeFromData(IntPtr.Zero, null, file, file.Length, null, 0, out var intPtr, 0);

                var mime = Marshal.PtrToStringUni(intPtr);
                Marshal.FreeCoTaskMem(intPtr);

                return mime ?? null;

            }
            catch (Exception e)
            {
                return $"{e.Message}\r\n{e.StackTrace}\n\r{e.Source}";
            }
        }

        /// <summary>
        /// Get file's extension from its path
        /// </summary>
        /// <param name="filePath">The file's path</param>
        /// <returns><see cref="string"/> file's extension</returns>
        public static string GetExtension(string filePath)
        {
            try
            {
                byte[] fileToArray = File.ReadAllBytes(filePath);

                _ = MimeTypeHelper.FindMimeFromData(IntPtr.Zero, null, fileToArray, fileToArray.Length, null, 0, out var intPtr, 0);
                var mime = Marshal.PtrToStringUni(intPtr);
                Marshal.FreeCoTaskMem(intPtr);

                return mime ?? null;
            }
            catch (Exception e)
            {
                return $"{e.Message}\r\n{e.StackTrace}\n\r{e.Source}";
            }
        }

        /// <summary>
        /// Allows to format file to base64 format for displaying purpose
        /// </summary>
        /// <param name="file">The file byte array</param>
        /// <returns><see cref="string"/> fromatted file</returns>
        public static string Format(byte[] file)
        {
            try
            {
                //get the file extension
                var fileExtension = GetExtension(file);
                var encodeToBase64 = Convert.ToBase64String(file);//convert bytes array to base64 format
                var formattedFile = $"data:{fileExtension};base64,{encodeToBase64}";

                return formattedFile ?? null;
            }
            catch (Exception e)
            {
                return $"{e.Message}\r\n{e.StackTrace}\n\r{e.Source}";
            }
        }

        /// <summary>
        /// Allows to format file from its given path for displaying purpose
        /// </summary>
        /// <param name="path">The path of the file</param>
        /// <returns><see cref="string"/> formatted file</returns>
        public static string Format(string path)
        {
            try
            {
                byte[] convertedFile = File.ReadAllBytes(path);//convert file by reading it into bytes array 
                var encodeToBase64 = Convert.ToBase64String(convertedFile);// convert it to base64 string
                var fileExtension = GetExtension(convertedFile);//get the extension
                var formattedFile = $"data:{fileExtension};base64,{encodeToBase64}"; //format it

                return formattedFile ?? null;
            }
            catch (Exception e)
            {
                return $"{e.Message}\r\n{e.StackTrace}\n\r{e.Source}";
            }
        }
    }
}
