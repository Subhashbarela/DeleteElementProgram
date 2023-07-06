using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementUsingGeneric
{
    public class FindMinUsingGenericClass<T> where T : IComparable  

    {
        public T firstValue, secondValue, thirdValue;
        public FindMinUsingGenericClass(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T CheckMinNumber(T firstValue, T secondValue, T thirdValue)
        {
            // Assume first value is minimun becouse, we need to assign string value in min var
            T min = firstValue;
            //if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) < 0 ||
            //    firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) < 0 ||
            //    firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) <= 0)
            //{
            //    min= firstValue;
            //}
            if (secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) <= 0 && secondValue.CompareTo(thirdValue) < 0 ||
                secondValue.CompareTo(firstValue) < 0 && secondValue.CompareTo(thirdValue) <= 0)
            {
                min = secondValue;
            }
            if (thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) <= 0 && thirdValue.CompareTo(secondValue) < 0 ||
                thirdValue.CompareTo(firstValue) < 0 && thirdValue.CompareTo(secondValue) <= 0)
            {
                min = thirdValue;
            }
            return min;
        }      

    }
}
