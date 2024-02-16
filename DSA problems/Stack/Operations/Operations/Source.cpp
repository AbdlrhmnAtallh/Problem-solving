#include <iostream>
#include "Stack.cpp"
using namespace std;
int main() {

	Stack stack;
	stack.pop();
	stack.Display();
	stack.IsEmpty();
	stack.IsFull();
	stack.peek();
	stack.Push(1);
	stack.Push(2);
	stack.Push(3);
	stack.Push(4);
	stack.Push(5);
	stack.Display();
	stack.peek();
	stack.pop();
	stack.Display();
}