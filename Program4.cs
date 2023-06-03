using System;

public class ReverseNumber
{
    public static int Reverse(int number)
    {
        int reverse = 0;
        while (number != 0)
        {
            int remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number /= 10;
        }
        return reverse;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = Reverse(number);

        Console.WriteLine("Reversed number: " + reversedNumber);
    }
}
