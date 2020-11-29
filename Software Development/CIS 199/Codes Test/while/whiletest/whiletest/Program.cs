// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using System;
using static System.Console;
class DebugFive1
{
    static void Main()
    {

        for (int h = 1; h <= 11; ++h)
        {
            for (int m = 0; m <= 59; ++m)
            {
                WriteLine($"{h:D2}:{m:D2} PM");
            }
        }
    }
}