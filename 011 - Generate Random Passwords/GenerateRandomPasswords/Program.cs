using System.Text;

namespace GenerateRandomPasswords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select between 1 and 2 \n 1. Generate Random Number ." +
                "2. Generate Random string .");
            int selectedOption = Convert.ToInt32(Console.ReadLine());
            if(selectedOption==1)
            {
                GenerateRandomNumber();
            }
            else if (selectedOption==2)
            {
                GenerateRandomString();
            }

        }
        public static void GenerateRandomNumber()
        {
            bool validinput = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter minimum and maximum value");
                    Console.Write("Enter Minimum Number: ");
                    int minimum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Maximum Number: ");
                    int Maximum = Convert.ToInt32(Console.ReadLine());
                    if( minimum<0 || Maximum < 0)
                    {
                        Console.WriteLine("Hahaha, you're in a loop, and you won't get out until you enter valid numbers!");
                    }
                    else
                    {
                        Random rand = new Random();
                        var value = rand.Next(minimum, Maximum);
                        Console.WriteLine(" Random Number: " + value);
                        validinput = true;
                    }
                    

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please Enter a valid number, Don't play with my Application ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            } while (!validinput);
            
            
            
        }
        private const string CapitalString ="ABCDEFGHKLMNOPQRSTUVWYXZ";
        private const string SmallString ="abcdefghklmnopqrstuvwyxz";
        private const string SymbolsString ="+-_*&$#@";
        private const string NumbersString ="0123456789";


        public static void GenerateRandomString()
        {
            Console.WriteLine("Please Enter string Length");
            int stringLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want the string include Capital letters? click 1 for YES and 2 for No ");
            int CapitalLetters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want the string include Small letters? click 1 for YES and 2 for No ");
            int SmalllLetters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want the string include Symbols? click 1 for YES and 2 for No ");
            int Symbols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want the string include Numbers? click 1 for YES and 2 for No ");
            int Numbers = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            var sb = new StringBuilder();
            if (CapitalLetters == 1)
            {
                sb.Append(SmallString);
            }
            if (SmalllLetters == 1)
            {
                sb.Append(CapitalString);
            }
            if(Symbols == 1)
            {
                sb.Append(SymbolsString);
            }
            if (Numbers == 1)
            {
                sb.Append(NumbersString);
            }
            if (sb.Length == 0)
            {
                Console.WriteLine("Looking For auto generate? Click 1 For YES 2 For Close Program");
                int autogenerate = Convert.ToInt32(Console.ReadLine());
                if (autogenerate == 1)
                {
                    sb.Append(CapitalString);
                    sb.Append(SmallString);
                    sb.Append(NumbersString);
                    sb.Append(SymbolsString);
                }
                else return;
            }

            var FinalString = new StringBuilder(stringLength);
            while(FinalString.Length < stringLength)
            {
                var RandomIndex = rand.Next(0, sb.Length-1);
                FinalString.Append(sb[RandomIndex]);
            }
            Console.WriteLine("Random string: "+FinalString);
        }
    }
}