using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding()
        {
            StringLibrary.CalCulator sq = new StringLibrary.CalCulator();
            int result = sq.Add(10, 15);
            Assert.AreEqual<int>(25, result);
        }
        
        [TestMethod]
        public void Subtract()
        {
            StringLibrary.CalCulator sq = new StringLibrary.CalCulator();
            int result = sq.Subtract(10, 15);
            Assert.AreEqual<int>(5, result);
        }

        [TestMethod]
        public void Multiply()
        {
            StringLibrary.CalCulator sq = new StringLibrary.CalCulator();
            int result = sq.Multiply(10, 15);
            Assert.AreEqual<int>(150, result);
        }
        
        [TestMethod]
        public void Division()
        {
            StringLibrary.CalCulator sq = new StringLibrary.CalCulator();
            float result = sq.Division(15, 5);
            Assert.AreEqual<float>(3, result);
        }
    }
}