#include <iostream>
using namespace std;
bool x = true;
int loop = 0;

void vowels(string s, int  i) {

	if (s[i] == 'a' || s[i] == 'o' || s[i] == 'y' || s[i] == 'u'
		|| s[i] == 'i' || s[i] == 'e' || s[i] == 'A' || s[i] == 'O' || s[i] == 'Y'
		|| s[i] == 'U'
		|| s[i] == 'I' || s[i] == 'E') {

		x = false;
	}
	else
	{
		cout << ".";

	}
}

void uppercasee(string s, int i) {
	if (s[i] < 97 && x != false) {
		s[i] += 32;

	}

	if (x == false) {
		i++;

	}
	else
	{
		cout << s[i];
		i++;
	}

}

int main() {

	string word;
	cin >> word;
	while (word[loop] != '\0') {
		x = true;
		vowels(word, loop);
		uppercasee(word, loop);
		loop++;
	}

	return 0;
}






/* another way
int main() {
	string s;
	cin >> s;
	int i = 0;
	while (s[i] !='\0') {

		bool x = true;
		if (s[i] == 'a' || s[i] == 'o' || s[i] == 'y' || s[i] == 'u'
			|| s[i] == 'i' || s[i] == 'e' || s[i] == 'A' || s[i] == 'O' || s[i] == 'Y'
			|| s[i] == 'U'
			|| s[i] == 'I' || s[i] == 'E') {
			 x = false;
		}
		else
		{
			cout << ".";
		}
		if (s[i] < 97) {

				s[i] += 32;
				cout << s[i];
			i++;
		}
		else
		{
			if (x == false) {
				i++;
			}
			else {
				cout << s[i];
				i++;
			}
		}
	}
	return 0;
}
*/