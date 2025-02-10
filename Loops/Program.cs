namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Increment Operator (++)
            //The increment operator can be applied to an int variable to increment its value by 1
            //The syntax is:
            // myIntVariable++
            // or
            // ++myIntVariable
            // The position of the ++ (either before or after the variable) will have slightly different results.

            int myIntVariable = 1;

            // There are three ways I can increment the value of myIntVariable by 1.
            // myIntVariable = myIntVariable + 1;
            // myIntVariable += 1;
            // myIntVariable++;
            // ++myIntVariable;

            // All four of the above statements will yield the same results, increasing the value of
            // myIntVariable by 1.

            // If the ++ appears AFTER the variable, then the increment will happen after any operations are performed.
            // For example:

            int myNewInt = myIntVariable++;

            // This line will do the following:
            // 1. Assign the value of myNewInt to the current value of myIntVariable.
            // 2. Increment the value of myIntVariable.
            // After the above line of code, the value of myIntVariable will be 2, and the value of myNewInt will be 1
            // because the increment happened after the assignment of the new variable.

            // If the ++ appears BEFORE the variable, then the increment will happen before any operations are performed.
            // For example:

            myNewInt = ++myIntVariable;

            // This line will do the following:
            // 1. Increment the value of myIntVariable.
            // 2. Assign the value of myNewInt to the current value of myIntVariable.
            // After the above line of code, the value of myIntVariable will be 3 and the value of myNewInt will also be 3
            // because the increment happened before the assignment of the new variable.

            // Decrement Operator (--)
            // The decrement operator (two minus signs) is used the exact same way as the increment operator, except it will decrease the value of the variable by 1
            // instead of increase it.

            // If the -- appears AFTER the variable, then the decrement will happen after any operations are performed.
            // For example:

            myNewInt = myIntVariable--;

            // This line will do the following:
            // 1. Assign the value of myNewInt to the current value of myIntVariable.
            // 2. Decrement the value of myIntVariable.
            // After the above line of code, the value of myIntVariable will be 2, and the value of myNewInt will still be 3
            // because the decrement happened after the assignment of the new variable.

            // If the ++ appears BEFORE the variable, then the increment will happen before any operations are performed.
            // For example:

            myNewInt = --myIntVariable;

            // This line will do the following:
            // 1. Decrement the value of myIntVariable.
            // 2. Assign the value of myNewInt to the current value of myIntVariable.
            // After the above line of code, the value of myIntVariable will be 1 and the value of myNewInt will also be 1
            // because the decrement happened before the assignment of the new variable.

            Console.Write("Give me the first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Give me a second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Pre-test loops

            // FOR LOOPS

            // WHILE LOOPS

            // Post-test loops

            // DO WHILE Loops
        }
    }
}
