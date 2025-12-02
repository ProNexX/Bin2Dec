Console.WriteLine("Enter 'q' to quite the program");

string? input = "";

while (input != "q")
{
    Console.Write("Enter a binary number up to 8 digits: ");
    input = Console.ReadLine();

    if (input is null || input.Length > 8)
    {
        Console.WriteLine("Please enter a valid number!");
        continue;
    }

    int sum = 0;
    int expo = 0;
    for (int i = input.Length - 1; i >= 0; i--)
    {
        char num = input[i];
        int numconverted = num - '0';

        if (numconverted > 1 || numconverted < 0)
        {
            Console.WriteLine("Please enter a valid number!");
            break;
        }

        sum += (int)Math.Pow(2, expo) * numconverted;
        expo++;
    }

    Console.WriteLine($"Your decimal number is: {sum}");
}