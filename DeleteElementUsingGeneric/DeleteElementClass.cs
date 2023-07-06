using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementUsingGeneric
{
    public class DeleteElementClass
    {
        public void DeleteMethod(int[] intArray, int pos)
        {
            Console.WriteLine("Before Delete the element");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            for (int i = pos - 1; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }
            Console.WriteLine("\nAfter Delete the element");
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine("\n............................");
        }
        public void DeleteMethod(double[] intArray, int pos)
        {
            Console.WriteLine("Before Delete the element");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            for (int i = pos - 1; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }
            Console.WriteLine("\nAfter Delete the element");

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine("\n..............................");
        }
        public void DeleteMethod(char[] intArray, int pos)
        {
            Console.WriteLine("Before Delete the element");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i] + " ");
            }

            for (int i = pos - 1; i < intArray.Length - 1; i++)
            {
                intArray[i] = intArray[i + 1];
            }
            Console.WriteLine("\nBefore Delete the element");           
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                Console.Write(intArray[i] + " ");
            }
        }
    }
}
