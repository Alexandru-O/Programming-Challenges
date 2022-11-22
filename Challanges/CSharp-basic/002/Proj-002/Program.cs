int firstNumber;
int secondNumber;

try
{
    Console.Write("Please insert the first number: ");
    firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Please insert the second number: ");
    secondNumber = int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Insert only numbers");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}

Console.WriteLine($"The sum: {firstNumber + secondNumber}");

/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();
