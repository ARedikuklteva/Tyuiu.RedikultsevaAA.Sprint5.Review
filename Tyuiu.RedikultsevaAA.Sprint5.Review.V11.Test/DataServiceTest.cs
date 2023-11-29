using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.RedikultsevaAA.Sprint5.Review.V11.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint5.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistionsFile()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.RedikultsevaAA.Sprint5.Review\Tyuiu.RedikultsevaAA.Sprint5.Review.V11\bin\Debug\OutPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
