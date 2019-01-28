/** Created by Dayu Wang (dwang@stchas.edu) on 01-28-19. */

/** Last updated by Dayu Wang (dwang@stchas.edu) on 01-28-19. */

#include <iostream>

using namespace std;

int main() {
	char again = 'Y';
	while (again == 'Y') {
		system("cls");
		int num1, num2;
		char op;
		cout << "Enter the first number: ";
		cin >> num1;
		cout << "Enter the second number: ";
		cin >> num2;
		cout << "Enter the operation (case sensitive)." << endl;
		cout << "A - Addition" << endl;
		cout << "S - Subtraction" << endl;
		cout << "M - Multiplication" << endl;
		cout << "D - Division: ";
		cin >> op;
		if (op == 'A') { cout << num1 << " + " << num2 << " = " << num1 + num2 << endl; }
		if (op == 'S') { cout << num1 << " - " << num2 << " = " << num1 - num2 << endl; }
		if (op == 'M') { cout << num1 << " * " << num2 << " = " << num1 * num2 << endl; }
		if (op == 'D') {
			if (!num2) { cout << "Denominator is zero.  Cannot calculate." << endl; }
			else { cout << num1 << " / " << num2 << " = " << num1 * 1.0 / num2 << endl; }
		}
		cout << "Do you want to do another calculation (Y/N)? ";
		cin >> again;
	}
	return 0;
}