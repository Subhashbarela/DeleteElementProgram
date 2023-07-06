using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementUsingGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            DeleteElementClass delete = new DeleteElementClass();
            int[] intArr = { 10, 20, 30, 40, 50, 60 };
            delete.DeleteMethod(intArr, 3);
            double[] doubleArr = { 10.3, 20.4, 30.5, 40.3, 50.11, 60.8 };
            delete.DeleteMethod(doubleArr, 3);
            char[] stringArr = { 'A','B','C','D','E','F'};
            delete.DeleteMethod(stringArr, 3);
        Console.ReadLine();
        }
    }
}
