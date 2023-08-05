namespace IPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ip = new IP(112, 332, 55, 33);
            Console.WriteLine(ip.ipAddress);

        }
        class IP
        {
            private int[] segments = new int[4];

            public IP(int segment1, int segment2, int segment3, int segment4)
            {
                segments[0] = segment1;
                segments[1] = segment2;
                segments[2] = segment3;
                segments[3] = segment4;
            }
            public string ipAddress => string.Join('.', segments);


        }
        
    }
}