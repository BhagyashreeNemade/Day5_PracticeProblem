﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    public class PowerOfTwo
    {
        /// <summary>
        /// Calculates the power of two.
        /// </summary>
        /// <param name="N">The n.</param>
        public static void CalculatePowerOfTwo(int N)
        {
            if (N < 31)
            {
                for (int i = 0; i < N; i++)
                {
                    double PowOf2 = Math.Pow(2, i);

                    Console.WriteLine(PowOf2);
                }
            }
            else
            {
                Console.WriteLine("Enter the value within 0 and 30");
            }

        }
    }
}
