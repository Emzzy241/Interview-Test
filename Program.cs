using System;

namespace MyApp;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, There");

        // Task 1:
        Console.WriteLine("Task 1");
        Console.WriteLine();
        string name = "John Doe";
        int age = 25;
        bool isAdmin = true;
        Console.WriteLine("All variables created, Task 1 completed");
        Console.WriteLine();

        // Task 2:
        Console.WriteLine("Task 2");
        Console.WriteLine();
        Console.WriteLine("Enter an integer");
        try
        {
            string userInput = Console.ReadLine();
            int userInputInt = int.Parse(userInput);

            if(userInputInt % 2 == 0)
            {
                Console.WriteLine("Even");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Odd");
                Console.WriteLine();
            }
        }
        catch
        {
            Console.WriteLine("Please check again, what you entered is not an integer");
            Console.WriteLine();
        }
        Console.WriteLine("Task 2 completed");
        Console.WriteLine();

        // Task 3:
        Console.WriteLine("Task 3");
        Console.WriteLine();
        for (var i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
            Console.WriteLine();

        Console.WriteLine("Task 3 completed");
        Console.WriteLine();

        // Task 4:
        Console.WriteLine("Task 4");
        Console.WriteLine();
        int[] arr = {2, 4, 6, 8, 10};
        int sum = 0;

        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine(sum);
        Console.WriteLine();

        Console.WriteLine("Task 4 completed");
        Console.WriteLine();

        // Task 5:
        Console.WriteLine("Task 5");
        Console.WriteLine();

        void Greet(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        Greet("Alice");
        Console.WriteLine();
                
        Console.WriteLine("Task 5 completed");
        Console.WriteLine();
    }    
}