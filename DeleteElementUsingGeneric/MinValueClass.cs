﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementUsingGeneric
{
    internal class MinValueClass
    {
        public int MinimunIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) < 0 ||
                 firstValue.CompareTo(secondValue) <= 0 && firstValue.CompareTo(thirdValue) < 0 ||
                 firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) <= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) <= 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) <= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) <= 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) <= 0)
            {
                return thirdValue;
            }

            return firstValue;
        }
        public float CheckMinimumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) < 0 ||
                firstValue.CompareTo(secondValue) <= 0 && firstValue.CompareTo(thirdValue) < 0 ||
                firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) <= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) <= 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) <= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) <= 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) <= 0)
            {
                return thirdValue;
            }

            return firstValue;
        }
        public string MinimunStringValue(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) < 0 ||
                firstValue.CompareTo(secondValue) <= 0 && firstValue.CompareTo(thirdValue) < 0 ||
                firstValue.CompareTo(secondValue) < 0 && firstValue.CompareTo(thirdValue) <= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) <= 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) <= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) <= 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) <= 0)
            {
                return thirdValue;
            }

            return firstValue;
        }
    }
}
