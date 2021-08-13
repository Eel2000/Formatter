using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Formatter.src;

namespace Formatter.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestImageByteArray()
        {
            var imgArray = File.ReadAllBytes(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");
            var result = FileHelper.GetExtension(imgArray);

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestImageFormatting()
        {
            var imgArray = File.ReadAllBytes(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");
            var result = FileHelper.Format(imgArray);

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestImageFormattingFromPath()
        {
            var result = FileHelper.Format(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestOtherFiles()
        {
            var fileArrayBytes = FileHelper.GetExtension(@"C:\Users\CTRL TECH\Documents\Fonctionalitees.docx");
            Assert.IsInstanceOfType(fileArrayBytes, typeof(string));
        }

        [TestMethod]
        public void TestOtheFileByArrayGetExtension()
        {
            var result = FileHelper.GetExtension(@"C:\Users\CTRL TECH\Documents\Fonctionalitees.docx");

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestOtherFileFormatting()
        {
            var result = FileHelper.Format(@"C:\Users\CTRL TECH\Documents\Fonctionalitees.docx");

            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
