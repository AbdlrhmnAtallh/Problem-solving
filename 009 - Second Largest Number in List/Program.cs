namespace Second_Largest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the size of list ");
             int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter the list of numbers \n");
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length-1; i++) // Time Complexity: O(N^2)
            {
                for (int j = 0; j < numbers.Length- i - 1; j++)
                {
                     if (numbers[j] > numbers[j + 1])
                     {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                     }
                }
            }
            Console.WriteLine(" The Second Longest Numbers is: "+ numbers[size - 2]);

        }
    }
}