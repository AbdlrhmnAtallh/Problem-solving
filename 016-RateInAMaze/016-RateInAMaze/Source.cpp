#include <iostream>
using namespace std;
int main() {
	// reat in a maze 
	int arr[4][4] = {
		1,1,0,1,
		0,1,1,1,
		1,0,1,1,
		0,1,1,0
	};
	char road[12];
	int roadcounter = 0;
	bool up=true;
	bool left=true;
	bool right=true;
	for (int i = 3; i >=0; i--) {
		for (int j =3; j>=0; j--) {
			if (i != 0&& arr[i - 1][j] == 1 && up != false) { // up
				road[roadcounter] = 'U';
				roadcounter++;
				up = true;
				left = true;
				right = true;
				j = 0;
			}
			else if (j!=0&&arr[i][j - 1] == 1 &&left!=false) { // Left
				road[roadcounter] = 'L';
				roadcounter++;
				left = true;
				up = true;
				right = true;
			}
			//else if (j!=3&&arr[i][j + 1]&&right!=false) { // Right
			//	road[roadcounter] = 'R';
			//	roadcounter++;
			//	right = true;
			//	left = true;
			//	up = true;
			//}
			else {
				roadcounter--;
				if (road[roadcounter] == 'U') {
					up = false;
				}
				else if (road[roadcounter] == 'L') {
					left = false;
				}
				else if (road[roadcounter] == 'R') {
					right = false;
				}	
				road[roadcounter] = 'D';
				roadcounter++;
				i += 2;
			}
		}
	}
	for (int i = 0; i < roadcounter; i++) {
		cout << road[roadcounter];
	}
}