namespace Anton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int size = Convert.ToInt32(Console.ReadLine()), Anton = 0,
				Danik = 0;
			string c =Console.ReadLine();	
			for (int i = 0; i< size; i++) 
			{
				if (c[i] == 'A')
				{
					Anton++;

				}
				else Danik++;
			}
            if (Anton > Danik)
            {
				Console.WriteLine("Anton");
            }
			else if (Danik > Anton) { Console.WriteLine("Danik"); }
			else Console.WriteLine("Friendship");



        }
    }
}
/*
 C++

 //Anton and Danik Friendship
	int size = 0, ant = 0, dan = 0; cin >> size;
	string charc;
	cin >> charc;
	for (int i = 0; i < size; i++) {
		if (charc[i] == 'A') {
			ant++;
		}
		else dan++;
	}
	if (ant > dan) {
		cout << "Anton";
	}
	else if (dan > ant) { cout << "Danik"; }
	else  cout << "Friendship";
 */