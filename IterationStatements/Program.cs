using System;

class Program
{
    // 1. Print numbers from 1000 down to -1000
    static void PrintNumbers()
    {
        for (int i = 1000; i >= -1000; i--)
        {
            Console.WriteLine(i);
        }
    }

    // 2. Print every third number from 3 to 999
    static void PrintEveryThirdNumber()
    {
        for (int i = 3; i <= 999; i += 3)
        {
            Console.WriteLine(i);
        }
    }

    // 3. Check if two numbers are equal
    static bool AreNumbersEqual(int num1, int num2)
    {
        return num1 == num2;
    }

    // 4. Check if a number is even or odd
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // 5. Check if a number is positive or negative
    static bool IsPositive(int number)
    {
        return number > 0;
    }

    // 6. Check if a candidate is eligible to vote
    static bool CanVote(int age)
    {
        return age >= 18;
    }

    // Heatin' Up Section:

    // 1. Check if a number is within the range of -10 to 10
    static bool IsInRange(int number)
    {
        return number >= -10 && number <= 10;
    }

    // 2. Display the multiplication table from 1 to 12 for a given integer
    static void DisplayMultiplicationTable(int number)
    {
        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i} * {number} = {i * number}");
        }
    }

    static void Main(string[] args)
    {
        // Test PrintNumbers method
        Console.WriteLine("Testing PrintNumbers:");
        PrintNumbers();
        Console.WriteLine();

        // Test PrintEveryThirdNumber method
        Console.WriteLine("Testing PrintEveryThirdNumber:");
        PrintEveryThirdNumber();
        Console.WriteLine();

        // Test AreNumbersEqual method
        Console.WriteLine("Testing AreNumbersEqual:");
        Console.WriteLine(AreNumbersEqual(10, 10)); // True
        Console.WriteLine(AreNumbersEqual(10, 5));  // False
        Console.WriteLine();

        // Test IsEven method
        Console.WriteLine("Testing IsEven:");
        Console.WriteLine(IsEven(4)); // True
        Console.WriteLine(IsEven(7)); // False
        Console.WriteLine();

        // Test IsPositive method
        Console.WriteLine("Testing IsPositive:");
        Console.WriteLine(IsPositive(10));  // True
        Console.WriteLine(IsPositive(-5));  // False
        Console.WriteLine();

        // Test CanVote method
        Console.WriteLine("Testing CanVote:");
        Console.WriteLine(CanVote(20));  // True
        Console.WriteLine(CanVote(16));  // False
        Console.WriteLine();

        // Test IsInRange method
        Console.WriteLine("Testing IsInRange:");
        Console.WriteLine(IsInRange(5));   // True
        Console.WriteLine(IsInRange(-11)); // False
        Console.WriteLine(IsInRange(0));   // True
        Console.WriteLine();

        // Test DisplayMultiplicationTable method
        Console.WriteLine("Testing DisplayMultiplicationTable for 5:");
        DisplayMultiplicationTable(5); // Will display multiplication table for 5
    }
}

        
    
