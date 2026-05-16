using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Random ran = new Random();
        for (int i = 0; i < 20; i ++)
        {
            string output = "";
            fraction.SetNumerator(ran.Next(1, 101));
            fraction.SetDenominator(ran.Next(1, 101));
            output += $"Fraction {i + 1}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimal()}";
            Console.WriteLine(output + "\r\n");
        }
    }
}