using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayAssign
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop");
            int[] num = new int[] { 1, 2, 3, 4, 5 };

            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n2.WAP to create an array of 5 strings to store students name, sort names in " +
                "ascending order & display using foreach loop.");

            string[] names = { "snehal", "pankaj", "Rohan", "pratik", "om" };

            Array.Sort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n3.WAP to create jagged array, initialized data & display the details");

            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 10, 11, 12, 13 };
            jaggedArray[2] = new int[] { 600, 700 };
            jaggedArray[3] = new int[] { 5000 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("5.WAP to store rain fall in a week using 1Darray,accept & display the rain fall");

            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a day of week =");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"How many inches of rain did you get on ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("\n6.Wap to Accept an array of 5 integers.perform sort,reverse,copy,clear operations");
            int[] intArr = new int[5];
            int[] intArr1 = new int[5] {4,5,6,8,9};
            Console.WriteLine("Enter a set of 5 integers aaray=");
            for (int i = 0; i < intArr.Length; i++)
            {                
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(intArr);
            Console.WriteLine("After sort");
            foreach (int i in intArr)
            {
                Console.WriteLine(i);
            }

            Array.Copy(intArr, 0, intArr1, 0, 2);
            Console.WriteLine("After copy =");
            foreach (int i in intArr1)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(intArr);
            Console.WriteLine("After reverse");
            foreach(int i in intArr)
            {
                Console.WriteLine(i);
            } 
            Array.Clear(intArr,1,2);
            Console.WriteLine("After clear");
            foreach (var item in intArr1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("7.Wap to create a list using Arraylist.Iterate over collections to display data"); 
        }
    }
}
