#include "Stack.h"
#include <iostream>
using namespace std;

const int Size = 10;
class Stack
{
private:
	int stack[Size];
	int top = -1;
public:
	 
	bool IsEmpty() {
		if (top == - 1) {
			return true;
		}
		else
			return false;
	}
	bool IsFull() {
		if (top == Size - 1) {
			return true;

		}
		else
			return false;
	}

	void Push( int value) {
		if (!IsFull()) {

			stack[++top] = value;
		}
		else
			cout << "Stack overflow";
	}
	int pop() {
		if (!IsEmpty()) {
			return stack[--top];
		}
		cout << "Stack is Empty";
	}
	int peek() {
		if (!IsEmpty()) {
			return stack[top];
		}
		cout << "Stack is Empty";
	}
	void Display() {
		if (IsEmpty()) {
			cout << "Stack is Empty";
			return;
		}
		for (int i = top; i >= 0; i--) {
			cout << stack[i] << endl;
		}
	}

};

