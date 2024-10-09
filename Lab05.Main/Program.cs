using Lab05;

int numerator = GetValidInput("Please input a numerator: ");
int denominator = GetValidInput("Please input a denominator: ");

RationalNumber rationalNumber = new RationalNumber(numerator, denominator);

Console.WriteLine("Numerator: " + rationalNumber.numerator + "\nDenominator: " + rationalNumber.denominator);

int GetValidInput(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        int temp;
        if (int.TryParse(Console.ReadLine(), out temp))
            return temp;
        else
            Console.WriteLine("Invalid input try again.");
    }
}