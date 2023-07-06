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
                Console.WriteLine("1: Delete using general class \n2: Delete using generic method \n3: Delete using generic class" +
                    "\n4: integer minimum value \n5: float Minimum value \n6: string minimum value\n7: Find min using generic method\n8: find minimum using generic class");
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
                    case 3:
                        {
                            int[] intArray = { 20, 40, 10, 50, 70, 5 };
                            GenericClass<int>.DeleteMethod(intArray);

                            double[] doubleArray = { 20.5, 40.5, 10.5, 50.5, 70.1, 5.9 };
                            GenericClass<double>.DeleteMethod(doubleArray);

                            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
                            GenericClass<char>.DeleteMethod(charArray);
                            break;
                        }
                    case 4:
                        {
                            MinValueClass intMin = new MinValueClass();
                            int min=intMin.MinimunIntegerNumber(12,43,10);
                            Console.WriteLine("Minimun value of integer is : "+min);
                            break;
                        } 
                    case 5:
                        {
                            MinValueClass floatMin = new MinValueClass();
                            float min= floatMin.CheckMinimumFloatNumber(12.4f,43.22f,10.10f);
                            Console.WriteLine("Minimun value of float is : "+min);
                            break;
                        } 
                    case 6:
                        {
                            MinValueClass stringMin = new MinValueClass();
                            string min= stringMin.MinimunStringValue("Apple", "Peach", "Banana");
                            Console.WriteLine("Minimun string is : "+min);
                            break;
                        } 
                    case 7:
                        {
                            int intmin = FindMinUsingGenericMethod.CheckMinNumber<int>(40, 20, 30);
                            Console.WriteLine("Minimun integer is : "+intmin);
                            float floatmin = FindMinUsingGenericMethod.CheckMinNumber<float>(4.5f, 2.5f, 30.7f);
                            Console.WriteLine("Minimun float is : "+floatmin);
                            string stringmin = FindMinUsingGenericMethod.CheckMinNumber<string>("Apple", "Peach", "Banana");
                            Console.WriteLine("Minimun string is : "+stringmin);
                            break;
                        } 
                    case 8:
                        {
                            int intmin = FindMinUsingGenericClass<int>.CheckMinNumber(40, 20, 30);
                            Console.WriteLine("Minimun integer is : "+intmin);
                            float floatmin = FindMinUsingGenericClass<float>.CheckMinNumber(4.5f, 2.5f, 30.7f);
                            Console.WriteLine("Minimun float is : "+floatmin);
                            string stringmin = FindMinUsingGenericClass<string>.CheckMinNumber("Apple", "Peach", "Banana");
                            Console.WriteLine("Minimun string is : "+stringmin);
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
