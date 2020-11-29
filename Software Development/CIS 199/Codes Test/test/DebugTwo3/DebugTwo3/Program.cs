// Defines a base class named Customer
// And a child class FrequentCustomer who receives a discount
// Main program demonstrates a customer of each type
using System;
using static System.Console;
public class DebugTen01
{
    public static void Main()
    {
        int o;
        int z;
        int d = 10000;
        int output, output1, output2;
        Write("Enter origin zip:   ");
        int.TryParse(ReadLine(), out o);
        output1 = o / d;
        Write("Enter Dest zip:   ");
        int.TryParse(ReadLine(), out z);
        output2 = z / d;
        output = Math.Abs(output1 - output2);

        WriteLine($"{output}");

    }
}