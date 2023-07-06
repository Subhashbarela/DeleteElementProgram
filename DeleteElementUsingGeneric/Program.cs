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
            string ans = "";
            do
            {
                Console.WriteLine("1: Delete using general class \n2: Delete using generic method");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            DeleteElementClass delete = new DeleteElementClass();
                            int[] intArr = { 10, 20, 30, 40, 50, 60 };
                            delete.DeleteMethod(intArr, 3);
                            double[] doubleArr = { 10.3, 20.4, 30.5, 40.3, 50.11, 60.8 };
                            delete.DeleteMethod(doubleArr, 3);
                            char[] stringArr = { 'A', 'B', 'C', 'D', 'E', 'F' };
                            delete.DeleteMethod(stringArr, 3);
                            break;
                        }
                    case 2:
                        {
                            GenericMethodClass delete = new GenericMethodClass();
                            int[] intArr = { 10, 20, 30, 40, 50, 60 };
                            delete.DeleteMethod<int>(intArr);
                            double[] doubleArr = { 10.3, 20.4, 30.5, 40.3, 50.11, 60.8 };
                            delete.DeleteMethod<double>(doubleArr);
                            char[] charArr = { 'A', 'B', 'C', 'D', 'E', 'F' };
                            delete.DeleteMethod<char>(charArr);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please insert the valid option");
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue..?");
                ans = Console.ReadLine();
            } while (ans == "yes" || ans == "y");

            Console.ReadLine();
        }
    }
}
