/* Implement division of two positive integers without using the division, multiplication, or modulus operators. 
Return the quotient as an integer, ignoring the remainder. */

using System.Diagnostics.CodeAnalysis;

class Operators 
{
    public void ExecuteTask()
    {
        int divisor, dividend;
        int quotient = 0;

        Console.WriteLine("Enter a dividend: ");
        string input = Console.ReadLine();
        dividend = Convert.ToInt32(input);
        Console.WriteLine("Enter a divisor: ");
        input = Console.ReadLine();
        divisor = Convert.ToInt32(input);

        if(divisor ==0)
        {
            throw new DivideByZeroException();
        }

        if (dividend == 0 || dividend < divisor)
        {
            Console.WriteLine("Result: 0");
        }
        else if (dividend == divisor)
        {
           Console.WriteLine("Result: 1");
        }

        Console.WriteLine("Dividend: {0} Divisor: {1}", dividend, divisor);

        while(dividend >= divisor)
        {
            dividend -= divisor;
            quotient++;
        }

        Console.WriteLine("Quotient: {0}", quotient);
    }
}