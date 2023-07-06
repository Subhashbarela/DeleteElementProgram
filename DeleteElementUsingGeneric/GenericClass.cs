using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementUsingGeneric
{
    internal class GenericClass<T> where T : IComparable    
    {
        public static void DeleteMethod(T[] intArray)
        {
            Console.WriteLine("Before Delete the value");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            var pos = 3;
            for (int i = pos - 1; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }
            Console.WriteLine("\nAfter Deleted the value");

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine("\n......................");
        }
    }
}
