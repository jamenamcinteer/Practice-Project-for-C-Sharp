using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimensionalArray = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            _2DTo1D.Convert(twoDimensionalArray);
        }
    }
}
