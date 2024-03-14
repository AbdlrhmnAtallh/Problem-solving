namespace StaircaseDetail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staircase(5);
        }
        public static void Staircase(int n)
        {
            int x = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == x)
                    {
                        Console.Write("#");
                        x--;
                    }
                    else if (j > x)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}