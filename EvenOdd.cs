using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    internal class EvenOdd
    {
        /// <summary>
        /// Checks for Even and Odd number.
        /// </summary>
        /// <param name="N">The n.</param>
        /// <returns></returns>
        public static string CheckEvenOdd(int N)
        {
            if (N % 2 == 0)
            {

                return $"{N} is an even number";

            }
            else
            {

                return $"{N} is an Odd number";
            }
        }
    }
}
