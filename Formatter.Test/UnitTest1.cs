using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

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
            var result = src.Formatter.GetExtension(imgArray);

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestImageFormatting()
        {
            var imgArray = File.ReadAllBytes(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");
            var result = src.Formatter.Format(imgArray);

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestImageFormattingFromPath()
        {
            var result = src.Formatter.Format(@"C:\Users\CTRL TECH\Pictures\Ambulance.jpg");

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestOtherFiles()
        {
            var fileArrayBytes = src.Formatter.GetExtension(@"C:\Users\CTRL TECH\Documents\Fonctionalitees.docx");
            Assert.IsInstanceOfType(fileArrayBytes, typeof(string));
        }

        [TestMethod]
        public void TestOtheFileByArrayGetExtension()
        {
            var result = src.Formatter.GetExtension(@"C:\Users\CTRL TECH\Documents\Fonctionalitees.docx");

            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestOtherFileFormatting()
        {
            var result = src.Formatter.Format(@"C:\Users\CTRL TECH\Documents\Fonctionalitees.docx");

            Assert.IsInstanceOfType(result, typeof(string));
        }
    }
}
