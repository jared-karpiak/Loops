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
            // Pre-test loops will check if a condition is true BEFORE executing the code inside of the loop
            // FOR loops and While loops are examples of Pre-test loops

            // FOR LOOPS /////////////
            // For loops are used to execute a block of code a specific number of times.
            // They require three parts.
            // 1. The variable that will be used as the counter
            // 2. The logical condition that will break the loop
            // 3. The operation to perform on the variable being used as the counter.

            //     (1)       (2)   (3)
            //      |         |     |
            //      |         |     |
            //      V         V     V
            for (int i = 0; i < 3; i++)
            {
                // This will write three times, each time it executes, the value of i will increase by 1
                Console.WriteLine($"The value of i is {i}.");
            }

            // More often than not, a constant is not used in the conditional statement.
            // It is more common to see a variable used as part of it.

            int loopCount = 5;
            for (int i = 0; i < loopCount; i++)
            {
                Console.WriteLine($"The value of i is {i}.");
            }


            // WHILE LOOPS ///////////
            // A while loop will repeat the code inside of the loop when a certain condition evaluates to true.

            // Using the following while loop:
            // - if firstNum = 5 and secondNumber = 3, this loop will not execute at all,
            //   because (firstNum < secondNumber) evaluates to false.
            // - if firstNum = 3 and secondNumber = 5, then the loop will execute,
            //   because (firstNum < secondNumber) evaluates to true.

            while (firstNum < secondNumber)
            {
                // This will execute until (firstNum < secondNumber) evaluates to false.
                // In this scenario, we must increase the value of firstNum or else we will have an infinite loop
                Console.WriteLine($"The value of the first number is {firstNum++}.");

                // We could also decrease secondNumber to prevent an infinite loop.
                Console.WriteLine($"The value of the second number is {secondNumber--}.");
            }

            // While loops can easily slip into an infinite loop if care is not taken to make sure the logical
            // condition is met.


            // Post-test loops
            // Post-test loops will check if a condition is true AFTER the code inside of the loop has been executed.
            // This guarantees that each block of code inside of a loop is executed at least once.
            // In C#, this is mostly done using do-while loops

            // DO WHILE Loops

            // Do while loops will always execute the code at least once. After the code is run, the logical check is
            // performed which determines if we break out of the loop.
            
            // The following example will present a menu of options to a user that will reprint until
            // the character a user enters is 'q'.

            // First we must declare the variable "letter" outside of the do-while loop so it can be used inside
            // of our logical condition. If it is declared inside of the loop, it will be out of scope and inaccessible to
            // the logical condition.

            char letter;
            do
            {
                Console.WriteLine("""
                    Give me an action:
                    [a] = Write 'awesome'
                    [b] = Write 'Boedica'
                    [c] = Write 'cool'
                    [q] = Quit program
                    """);
                Console.Write("Enter a letter: ");
                letter = char.Parse(Console.ReadLine());

                switch (letter)
                {
                    case 'a':
                        Console.WriteLine("Awesome!");
                        break;
                    case 'b':
                        Console.WriteLine("Boedica is a British Hero who rebelled against the Romans.");
                        break;
                    case 'c':
                        Console.WriteLine("Cool!");
                        break;
                    default:
                        Console.WriteLine($"You entered {letter}.");
                        break;
                }
            } while (letter != 'q');
        }
    }
}
