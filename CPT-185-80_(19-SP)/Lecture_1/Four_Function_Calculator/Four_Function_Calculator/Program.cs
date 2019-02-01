/** Created by Dayu Wang (dwang@stchas.edu) on 01-31-19. */

/** Last updated by Dayu Wang (dwang@stchas.edu) on 01-31-19. */

using System;

namespace Four_Function_Calculator {
    class Program {
        static void Main(string[] args) {
            bool again = true;
            while (again) {
                int first, second;
                char operation;
                Console.Clear();
                Console.Write("Please enter the first integer: ");
                first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second integer: ");
                second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please select operation");
                Console.WriteLine("A - Addition");
                Console.WriteLine("S - Subtraction");
                Console.WriteLine("M - Multiplication");
                Console.Write("D - Division: ");
                operation = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                if (operation == 'A') { Console.WriteLine(first.ToString() + " + " + second.ToString() + " = " + (first + second).ToString()); }
                if (operation == 'S') { Console.WriteLine(first.ToString() + " - " + second.ToString() + " = " + (first - second).ToString()); }
                if (operation == 'M') { Console.WriteLine(first.ToString() + " * " + second.ToString() + " = " + (first * second).ToString()); }
                if (operation == 'D') {
                    if (second == 0) { Console.WriteLine("Divide by zero.  Cannot calculate."); }
                    else { Console.WriteLine(first.ToString() + " / " + second.ToString() + " = " + (first * 1.0 / second).ToString()); }
                }
                Console.WriteLine();
                Console.Write("Do you want to try again (Y/N)?  ");
                again = Convert.ToChar(Console.ReadLine()) == 'Y';

                uint var_1 = 3, var_2 = ++var_1;
                Console.WriteLine(var_1++ + ++var_2);
            }
        }
    }
}