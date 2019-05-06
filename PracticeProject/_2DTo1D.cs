using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class _2DTo1D
    {
        // Convert a two dimensional array into a one dimensional array
        public static int[] Convert(int[,] twoDimensionalArray)
        {
            int[] oneDimensionalArray = new int[twoDimensionalArray.GetLength(0) * twoDimensionalArray.GetLength(1)];
            int index = 0;
            for (int row = 0; row < twoDimensionalArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimensionalArray.GetLength(1); col++)
                {
                    oneDimensionalArray[index] = twoDimensionalArray[row, col];
                    index++;
                }
            }
            return oneDimensionalArray;
        }
    }
}
