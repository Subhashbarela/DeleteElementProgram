using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementUsingGeneric
{
    public class GenericMethodClass
    {
        public void DeleteMethod<T>(T[] intArray)
        {
            int pos = 3;
            for (int i = pos; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine("\n............................");
        }
    }
}
