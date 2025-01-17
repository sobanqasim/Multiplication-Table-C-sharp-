using System;

class Table
{
    static void Main()
    {
        Console.WriteLine("Enter a number:\n");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Multiplication Table of " + number + ":\n");
        

        for (int i = 0; i <= 10; i++)
        {

            Console.WriteLine(number + " x " + i + " = " + number * i );
        }
      
    }
}
