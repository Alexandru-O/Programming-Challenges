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
    Console.WriteLine("Please insert only numbers");
    /*-- exit --*/
    Console.WriteLine("Press Enter to exit");
    Console.Read();

    return;
}

Console.WriteLine($"Divided result: {((double)firstNumber / secondNumber):N2}");

/*-- exit --*/
Console.WriteLine("Press Enter to exit");
Console.Read();
