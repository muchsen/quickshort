using System
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Xml;
namespace QuickShort
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int[] cmp_count = 0;
        private int[] mov_count = 0;

        //number of element in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.WriteLine("Enter the number of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n < 20)
                    break;
                else
                    Console.WriteLine("\n Array can have maximum 20 elements \n");

            }
            Console.WriteLine("\n =================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n==================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
         
            
            
        }
        //swaps the element at index x with the elemnts at index y
        void swap(int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }


    }
}