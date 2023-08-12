#include <iostream>
#include <random>
using namespace std;
int main() {

    random_device rand;
    mt19937 gen(rand());

    uniform_real_distribution<double> dist(0.0, 1.0);

    for (int i = 0; i < 3; ++i) {
        double randomValue = dist(gen);

        // Adjust the probability of 1 and 0
        if (randomValue < 0.25) {
            cout << "0 ";
        }
        else {
            cout << "1 ";
        }
    }

    cout << std::endl;
}

// The Code in C# 
/*

 static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            double randomValue = random.NextDouble();

            if (randomValue < 0.25)
            {
                Console.Write("0");
            }
            else
            {
                Console.Write("1");
            }
        }

        Console.WriteLine();
    }


*/