#include <iostream>
#include <string.h>
using namespace std;
int main() {

	int x = 0, n = 0;
	cin >> n;
	string statement;
	while (n--) {
		cin >> statement;
		if (statement[1] == '+') {
			++x;
		}
		else
		{
			--x;
		}
	}

	/* Another way
	for (int i = 1; i <= n; i++) {
		cin >> statement;
		if (statement[0] == '+') ++x;
		if (statement[2] == '+') x++;
		if (statement[0] == '-') --x;
		if (statement[2] == '-') x--;
	} */

	cout << x << endl;
	return 0;
}