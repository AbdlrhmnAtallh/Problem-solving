using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Size Of Array ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for(int i =0; i <size; i++)
            {
                Console.WriteLine($" Enter The Element Number {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine(" Enter Any Key To Search in Array ");
            int key = Convert.ToInt32(Console.ReadLine());
            if (RecursiveLinearSearch((int[])arr, size, key) == 1)
            {
                Console.WriteLine(" Found ");
            }
            else Console.WriteLine(" Not Found ");


        }
         static int RecursiveLinearSearch(int[] arr, int Size, int key)
        {
            Size -= 1;
            if (Size < 0)
            {
                return -1;
            }
            else if (key == arr[Size])
            {
                return 1;
            }

            else return RecursiveLinearSearch((int[])arr, Size, key);
        }
    }
}