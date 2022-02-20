﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public static double Subtract(double a, double b)
        {
            double c = a - b;
            return c;
        }

        public static double Multiply(double a, double b)
        {
            double c = a * b;
            return c;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("The numerator cannot be 0");
            }

            double c = a / b;
            return c;
        }
    }
}
