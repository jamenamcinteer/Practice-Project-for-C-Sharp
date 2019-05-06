using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeProject;

namespace PracticeProject.Test.Unit
{
    [TestClass]
    public class _2DTo1DTest
    {
        [TestMethod]
        public void ConvertFourXTwo2DArray()
        {
            int[,] twoDimensionalArray = { { 1, 2 }, { 5, 6 }, { 9, 10 }, { 13, 14 } };
            int[] oneDimesionalArray = _2DTo1D.Convert(twoDimensionalArray);

            Assert.IsTrue(oneDimesionalArray.Length == 8);
            Assert.IsTrue(oneDimesionalArray[0] == 1);
            Assert.IsTrue(oneDimesionalArray[7] == 14);
            Assert.IsTrue(oneDimesionalArray[2] == 5);
        }

        [TestMethod]
        public void ConvertTwoXThree2DArray()
        {
            int[,] twoDimensionalArray = { { 1, 2, 3 }, { 5, 6, 7 } };
            int[] oneDimesionalArray = _2DTo1D.Convert(twoDimensionalArray);

            Assert.IsTrue(oneDimesionalArray.Length == 6);
            Assert.IsTrue(oneDimesionalArray[0] == 1);
            Assert.IsTrue(oneDimesionalArray[5] == 7);
            Assert.IsTrue(oneDimesionalArray[3] == 5);
        }

        [TestMethod]
        public void ConvertFourXFour2DArray()
        {
            int[,] twoDimensionalArray = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int[] oneDimesionalArray = _2DTo1D.Convert(twoDimensionalArray);

            Assert.IsTrue(oneDimesionalArray.Length == 16);
            Assert.IsTrue(oneDimesionalArray[0] == 1);
            Assert.IsTrue(oneDimesionalArray[15] == 16);
            Assert.IsTrue(oneDimesionalArray[4] == 5);
        }
    }
}
